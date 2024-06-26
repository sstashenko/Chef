using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chef
{
    // Форма для видалення рецепту з списку рецептів
    public partial class RemoveRecipeForm : Form
    {
        private List<Recipe> recipes; // Список рецептів
        private DataManager dataManager; // Менеджер даних для збереження та завантаження інформації

        // Конструктор форми, приймає список рецептів та менеджера даних
        public RemoveRecipeForm(List<Recipe> recipes, DataManager dataManager)
        {
            InitializeComponent();
            this.recipes = recipes; // Ініціалізація списку рецептів
            this.dataManager = dataManager; // Ініціалізація менеджера даних
            PopulateRecipeList(); // Заповнення списку рецептів
        }

        // Метод для заповнення списку рецептів
        private void PopulateRecipeList()
        {
            lstRecipes.Items.Clear(); // Очищення списку рецептів у ListBox

            // Перебір кожного рецепту у списку
            foreach (var recipe in recipes)
            {
                // Додаємо назву рецепту до ListBox
                lstRecipes.Items.Add(recipe.Name);
            }
        }

        // Обробник події натискання на кнопку "Remove"
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Отримання назви вибраного рецепту
            var selectedRecipe = lstRecipes.SelectedItem?.ToString();

            if (selectedRecipe != null)
            {
                // Пошук рецепту у списку за назвою
                var recipe = recipes.Find(r => r.Name == selectedRecipe);

                if (recipe != null)
                {
                    // Видалення рецепту зі списку
                    recipes.Remove(recipe);

                    // Збереження змін у списку рецептів до файлу
                    dataManager.SaveRecipes(recipes, "recipes.xml");

                    // Повідомлення про успішне видалення рецепту
                    MessageBox.Show("Recipe removed successfully!");

                    // Оновлення списку рецептів
                    PopulateRecipeList();
                }
            }
            else
            {
                // Повідомлення про те, що рецепт не вибраний
                MessageBox.Show("Please select a recipe to remove.");
            }
        }
    }
}
