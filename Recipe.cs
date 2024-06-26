using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef
{
    // Клас Recipe, що наслідує FoodItem
    public class Recipe : FoodItem
    {
        private string name; // Назва рецепту
        private List<Product> ingredients; // Список інгредієнтів
        private string instructions; // Інструкції з приготування

        // Конструктор без аргументів, викликає інший конструктор з дефолтними значеннями
        public Recipe() : this("Unknown", new List<Product>(), "No instructions") { }

        // Конструктор з аргументами для ініціалізації всіх змінних
        public Recipe(string name, List<Product> ingredients, string instructions)
        {
            this.name = name;
            this.ingredients = ingredients;
            this.instructions = instructions;
        }

        // Властивості для доступу до змінних
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Product> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        public string Instructions
        {
            get { return instructions; }
            set { instructions = value; }
        }

        // Перевизначення методу для отримання інформації про рецепт
        public override string GetInfo()
        {
            string info = $"Recipe: {name}, Instructions: {instructions}\nIngredients:\n";
            foreach (var ingredient in ingredients)
            {
                info += ingredient.GetInfo() + "\n";
            }
            return info;
        }

        // Для статичного поліморфізму метод з тою ж назвою але іншим вхідним параметром (не придумав все таки, куди всунути)
        public string GetInfo(bool showInstructions)
        {
            string info = $"Recipe: {name}\nIngredients:\n";
            foreach (var ingredient in ingredients)
            {
                info += ingredient.GetInfo() + "\n";
            }
            if (showInstructions)
            {
                info += $"Instructions: {instructions}\n";
            }
            return info;
        }
    }
}
