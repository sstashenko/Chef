using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Chef
{
    // Форма для створення меню
    public partial class CreateMenuForm : Form
    {
        private List<Recipe> recipes; // Список рецептів, //для вимоги використання параметризованої колекції
        private Inventory inventory; // Інвентар, що містить продукти
        private DataManager dataManager; // Менеджер даних для збереження та завантаження інформації
        private List<Menu> recentMenus; // Список останніх створених меню

        // Конструктор форми, приймає список рецептів, інвентар, менеджера даних та список останніх меню
        public CreateMenuForm(List<Recipe> recipes, Inventory inventory, DataManager dataManager, List<Menu> recentMenus)
        {
            InitializeComponent();
            this.recipes = recipes; // Ініціалізація списку рецептів
            this.inventory = inventory; // Ініціалізація інвентарю
            this.dataManager = dataManager; // Ініціалізація менеджера даних
            this.recentMenus = recentMenus; // Ініціалізація списку останніх меню
            PopulateRecipes(); // Заповнення списку рецептів
        }

        // Метод для заповнення списку рецептів
        private void PopulateRecipes()
        {
            // Додавання назви кожного рецепту до CheckListBox
            foreach (var recipe in recipes)
            {
                clbRecipes.Items.Add(recipe.Name);
            }
        }

        // Обробник події натискання на кнопку "Create Menu"
        private void btnCreateMenu_Click(object sender, EventArgs e)
        {
            // Отримання кількості людей з NumericUpDown
            int numberOfPeople = (int)nudNumberOfPeople.Value;

            // Створення нового меню та встановлення кількості людей
            Menu menu = new Menu();
            menu.SetNumberOfPeople(numberOfPeople);

            // Додавання вибраних рецептів до меню
            foreach (var item in clbRecipes.CheckedItems)
            {
                var recipe = recipes.Find(r => r.Name == item.ToString());
                if (recipe != null)
                {
                    menu.AddRecipe(recipe);
                }
            }

            // Отримання списку необхідних продуктів для створеного меню
            var requiredProducts = menu.GetRequiredProducts(numberOfPeople);

            // Перевірка наявності необхідних продуктів в інвентарі
            if (inventory.CheckStock(requiredProducts))
            {
                // Оновлення кількості продуктів в інвентарі
                inventory.UpdateStock(requiredProducts);

                // Збереження змін в інвентарі до файлу
                dataManager.SaveInventory(inventory, "inventory.xml");

                // Додавання меню до списку останніх меню
                recentMenus.Add(menu);

                // Повідомлення про успішне створення меню та оновлення запасів
                MessageBox.Show("Menu created and stock updated successfully!");
            }
            else
            {
                // Повідомлення про недостатні запаси для вибраного меню
                MessageBox.Show("Insufficient stock for the selected menu.");
            }

            this.Close(); // Закриття форми
        }
    }
}
