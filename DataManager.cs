using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Chef
{
    // Клас для управління збереженням та завантаженням даних (інвентар та рецепти)
    // Для вимоги збережень інфи до файлу XML
    public class DataManager
    {
        // Метод для збереження інвентарю у файл
        public void SaveInventory(Inventory inventory, string filePath)
        {
            // Створення серіалізатора для списку продуктів
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            // Відкриття потоку для запису у файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Серіалізація та запис списку продуктів у файл
                serializer.Serialize(writer, inventory.GetProducts());
            }
        }

        // Метод для завантаження інвентарю з файлу
        public void LoadInventory(Inventory inventory, string filePath)
        {
            // Перевірка наявності файлу та його непорожнього вмісту
            if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
            {
                CreateInitialInventoryFile(filePath); // Створення початкового файлу інвентарю, якщо файл відсутній або порожній
            }
            // Створення серіалізатора для списку продуктів
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            // Відкриття потоку для читання з файлу
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Десеріалізація списку продуктів з файлу
                List<Product> products = (List<Product>)serializer.Deserialize(reader);
                // Додавання кожного продукту до інвентарю
                foreach (var product in products)
                {
                    inventory.TryAddProduct(product);
                }
            }
        }

        // Метод для збереження рецептів у файл
        public void SaveRecipes(List<Recipe> recipes, string filePath)
        {
            // Створення серіалізатора для списку рецептів
            XmlSerializer serializer = new XmlSerializer(typeof(List<Recipe>));
            // Відкриття потоку для запису у файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Серіалізація та запис списку рецептів у файл
                serializer.Serialize(writer, recipes);
            }
        }

        // Метод для завантаження рецептів з файлу
        public void LoadRecipes(List<Recipe> recipes, string filePath)
        {
            // Перевірка наявності файлу та його непорожнього вмісту
            if (!File.Exists(filePath) || new FileInfo(filePath).Length == 0)
            {
                CreateInitialRecipesFile(filePath); // Створення початкового файлу рецептів, якщо файл відсутній або порожній
            }
            // Створення серіалізатора для списку рецептів
            XmlSerializer serializer = new XmlSerializer(typeof(List<Recipe>));
            // Відкриття потоку для читання з файлу
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Десеріалізація списку рецептів з файлу
                List<Recipe> loadedRecipes = (List<Recipe>)serializer.Deserialize(reader);
                // Додавання кожного рецепту до списку рецептів
                recipes.AddRange(loadedRecipes);
            }
        }

        // Приватний метод для створення початкового файлу інвентарю з прикладом продукту
        private void CreateInitialInventoryFile(string filePath)
        {
            var initialProducts = new List<Product>
            {
                new Product("Sample Product", 1.99, 10, "Sample Type")
            };

            // Створення серіалізатора для списку продуктів
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            // Відкриття потоку для запису у файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Серіалізація та запис початкового списку продуктів у файл
                serializer.Serialize(writer, initialProducts);
            }
        }

        // Приватний метод для створення початкового файлу рецептів з прикладом рецепту
        private void CreateInitialRecipesFile(string filePath)
        {
            var initialRecipes = new List<Recipe>
            {
                new Recipe("Sample Recipe", new List<Product>
                {
                    new Product("Sample Ingredient", 0.99, 1, "Sample Type")
                }, "Sample instructions")
            };

            // Створення серіалізатора для списку рецептів
            XmlSerializer serializer = new XmlSerializer(typeof(List<Recipe>));
            // Відкриття потоку для запису у файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Серіалізація та запис початкового списку рецептів у файл
                serializer.Serialize(writer, initialRecipes);
            }
        }
    }
}
