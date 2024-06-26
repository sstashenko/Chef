using System;
using System.Collections.Generic;
using System.Linq;

namespace Chef
{
    // Клас Inventory відповідає за управління списком продуктів на складі.
    public class Inventory
    {
        // Приватне поле, що зберігає список продуктів.
        private List<Product> products;

        // Конструктор за замовчуванням ініціалізує список продуктів.
        public Inventory()
        {
            products = new List<Product>();
        }

        // Метод для додавання продукту до інвентарю.
        // Використовує метод порівняння CompareTo для перевірки, чи вже існує продукт з такою ж назвою.
        // Якщо продукту з такою назвою немає, додає новий продукт і повертає true.
        // Якщо продукт з такою назвою вже існує, повертає false.
        public bool TryAddProduct(Product product)
        {
            if (products.FirstOrDefault(p => p.CompareTo(product) == 0) == null)
            {
                products.Add(product);
                return true;
            }
            return false;
        }

        // Метод для видалення продукту з інвентарю за його назвою.
        // Використовує метод FirstOrDefault для пошуку продукту за назвою.
        // Якщо продукт знайдено, видаляє його зі списку.
        public void RemoveProductByName(string productName)
        {
            var product = products.FirstOrDefault(p => p.Name == productName);
            if (product != null)
            {
                products.Remove(product);
            }
        }

        // Метод для отримання списку всіх продуктів у інвентарі.
        // Повертає список продуктів.
        public List<Product> GetProducts()
        {
            return products;
        }

        // Метод для перевірки наявності достатньої кількості необхідних продуктів у інвентарі.
        // Перебирає список необхідних продуктів і перевіряє їх наявність та достатню кількість у інвентарі.
        // Якщо хоча б один продукт відсутній або його кількість недостатня, повертає false.
        // Якщо всі продукти є у достатній кількості, повертає true.
        public bool CheckStock(List<Product> requiredProducts)
        {
            foreach (var required in requiredProducts)
            {
                var stockProduct = products.FirstOrDefault(p => p.Name == required.Name);
                if (stockProduct == null || stockProduct.Quantity < required.Quantity)
                {
                    return false;
                }
            }
            return true;
        }

        // Метод для оновлення кількості продуктів у інвентарі після їх використання.
        // Перебирає список використаних продуктів і зменшує їх кількість у інвентарі.
        public void UpdateStock(List<Product> usedProducts)
        {
            foreach (var used in usedProducts)
            {
                var stockProduct = products.FirstOrDefault(p => p.Name == used.Name);
                if (stockProduct != null)
                {
                    stockProduct.Quantity -= used.Quantity;
                }
            }
        }

        // Метод для підрахунку загальної вартості всіх продуктів у інвентарі.
        public double CalculateTotalCost()
        {
            return products.Sum(p => p.CalculateTotalCost());
        }
    }
}
