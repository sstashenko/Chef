using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chef
{
    // Форма для перегляду списку рецептів
    public partial class ViewRecipesForm : Form
    {
        private List<Recipe> recipes; // Список рецептів

        // Конструктор форми, приймає список рецептів
        public ViewRecipesForm(List<Recipe> recipes)
        {
            InitializeComponent();
            this.recipes = recipes; // Ініціалізація списку рецептів
            DisplayRecipes(); // Відображення рецептів у ListView
        }

        // Метод для відображення списку рецептів
        private void DisplayRecipes()
        {
            listViewRecipes.Items.Clear(); // Очищення ListView перед заповненням

            // Перебір кожного рецепту у списку
            foreach (var recipe in recipes)
            {
                // Створення нового елемента ListView для кожного рецепту
                var item = new ListViewItem(new[]
                {
                    recipe.Name, // Назва рецепту
                    recipe.Instructions // Інструкції до рецепту
                });

                listViewRecipes.Items.Add(item); // Додавання елемента до ListView
            }
        }
    }
}
