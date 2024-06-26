using System;
using System.Collections.Generic;
using System.Linq;

namespace Chef
{
    // Клас Menu відповідає за управління списком рецептів та розрахунок необхідних продуктів для меню.
    public class Menu
    {
        // Приватні поля класу Menu
        private List<Recipe> recipes; // Список рецептів, що входять до меню
        private int numberOfPeople; // Кількість людей, на яку розраховане меню

        // Конструктор за замовчуванням, ініціалізує список рецептів
        public Menu()
        {
            recipes = new List<Recipe>();
        }

        // Метод для додавання рецепту до меню
        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe); // Додає рецепт до списку
        }

        // Метод для отримання списку рецептів з меню
        public List<Recipe> GetRecipes()
        {
            return recipes; // Повертає список рецептів
        }

        // Метод для встановлення кількості людей, на яку розраховане меню
        public void SetNumberOfPeople(int numberOfPeople)
        {
            this.numberOfPeople = numberOfPeople; // Встановлює кількість людей
        }

        // Метод для отримання списку необхідних продуктів для меню на задану кількість людей
        public List<Product> GetRequiredProducts(int numberOfPeople)
        {
            List<Product> requiredProducts = new List<Product>(); // Створює новий список необхідних продуктів

            // Перебирає кожен рецепт у меню
            foreach (var recipe in recipes)
            {
                // Перебирає кожен інгредієнт у рецепті
                foreach (var ingredient in recipe.Ingredients)
                {
                    // Шукає, чи є вже цей інгредієнт у списку необхідних продуктів
                    var existingProduct = requiredProducts.Find(p => p.Name == ingredient.Name);
                    if (existingProduct == null)
                    {
                        // Якщо інгредієнта ще немає у списку, додає його з кількістю, помноженою на кількість людей
                        requiredProducts.Add(new Product(ingredient.Name, ingredient.Price, ingredient.Quantity * numberOfPeople, ingredient.ProductType));
                    }
                    else
                    {
                        // Якщо інгредієнт вже є у списку, збільшує його кількість на кількість, помножену на кількість людей
                        existingProduct.Quantity += ingredient.Quantity * numberOfPeople;
                    }
                }
            }

            return requiredProducts; // Повертає список необхідних продуктів
        }

        // Метод для отримання інформації про меню
        public string GetInfo()
        {
            string info = $"Menu for {numberOfPeople} people:\n"; // Початковий рядок з інформацією про кількість людей
            for (int i = 0; i < recipes.Count; i++)
            {
                info += recipes[i].Name; // Додає назву кожного рецепту до рядка
                if (i < recipes.Count - 1)
                {
                    info += ", "; // Додає кому між назвами рецептів, окрім останнього
                }
            }
            return info; // Повертає сформований рядок
        }
    }
}
