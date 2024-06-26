using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chef
{
    // Форма для додавання нового рецепту
    public partial class AddRecipeForm : Form
    {
        private List<Recipe> recipes; // Список рецептів. Також - для вимоги використання параметризованої колекції
        private Inventory inventory; // Інвентар, що містить продукти
        private DataManager dataManager; // Менеджер даних для збереження та завантаження інформації
        private Dictionary<string, TextBox> quantityTextBoxes = new Dictionary<string, TextBox>(); // Словник для зберігання текстових полів для кількості продуктів

        // Конструктор форми, приймає список рецептів, інвентар та менеджер даних
        public AddRecipeForm(List<Recipe> recipes, Inventory inventory, DataManager dataManager)
        {
            InitializeComponent();
            this.recipes = recipes; // Ініціалізація списку рецептів
            this.inventory = inventory; // Ініціалізація інвентарю
            this.dataManager = dataManager; // Ініціалізація менеджера даних
            PopulateProductList(); // Заповнення списку продуктів
        }

        // Метод для заповнення списку продуктів
        private void PopulateProductList()
        {
            int yOffset = 0; // Відступ по вертикалі для текстових полів кількості

            // Перебираємо всі продукти в інвентарі
            foreach (var product in inventory.GetProducts())
            {
                // Додаємо назву продукту до CheckListBox
                clbIngredients.Items.Add(product.Name);

                // Створення нового текстового поля для введення кількості продукту поруч із кожним продуктом
                TextBox quantityTextBox = new TextBox
                {
                    Name = $"txtQuantity_{product.Name}",
                    Size = new System.Drawing.Size(50, 27),
                    Location = new System.Drawing.Point(320, 145 + yOffset) // Розташування текстового поля
                };
                Controls.Add(quantityTextBox); // Додаємо текстове поле до форми
                quantityTextBoxes.Add(product.Name, quantityTextBox); // Додаємо текстове поле до словника
                yOffset += 30; // Збільшуємо відступ для наступного текстового поля
            }
        }

        // Обробник події натискання на кнопку "Add"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Зчитування даних з полів введення
            string name = txtName.Text;
            string instructions = txtInstructions.Text;
            List<Product> selectedIngredients = new List<Product>(); // Список вибраних інгредієнтів

            // Перебираємо всі вибрані елементи в CheckListBox
            foreach (var item in clbIngredients.CheckedItems)
            {
                var product = inventory.GetProducts().Find(p => p.Name == item.ToString());
                if (product != null)
                {
                    // Зчитування введеної кількості продукту з відповідного текстового поля
                    if (quantityTextBoxes.TryGetValue(product.Name, out TextBox quantityTextBox))
                    {
                        int quantity = int.Parse(quantityTextBox.Text); // Перетворення тексту на ціле число
                        // Додаємо продукт до списку інгредієнтів з вказаною кількістю
                        selectedIngredients.Add(new Product(product.Name, product.Price, quantity, product.ProductType));
                    }
                }
            }

            // Створення нового об'єкта Recipe
            Recipe recipe = new Recipe(name, selectedIngredients, instructions);
            recipes.Add(recipe); // Додаємо новий рецепт до списку рецептів

            // Збереження оновленого списку рецептів до файлу
            dataManager.SaveRecipes(recipes, "recipes.xml");

            MessageBox.Show("Recipe added successfully!"); // Повідомлення про успішне додавання рецепту
            this.Close(); // Закриття форми
        }
    }
}
