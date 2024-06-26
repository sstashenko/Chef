using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef
{
    // Клас Product, що наслідує FoodItem і реалізує IComparable<Product> та ICostCalculable
    public class Product : FoodItem, IComparable<Product>, ICostCalculable
    {
        // Поля класу Product (вимога полей)
        private double price; // Ціна продукту
        private int quantity; // Кількість продукту
        private string productType; // Тип продукту

        // Конструктор без аргументів, викликає інший конструктор з дефолтними значеннями
        // Це забезпечує реалізацію вимоги про наявність конструктора без аргументів.
        public Product() : this("Unknown", 0.0, 0, "Unknown") { }


        // Конструктор з аргументами для ініціалізації всіх змінних
        // Це забезпечує реалізацію вимоги про делегування конструкторів.
        public Product(string name, double price, int quantity, string productType)
        {
            this.ProductName = name;
            this.price = price;
            this.quantity = quantity;
            this.productType = productType;
        }

        // Властивості для доступу до змінних
        // Властивості дозволяють контролювати доступ до приватних полів класу.
        public string Name
        {
            get { return ProductName; } // Геттер для отримання назви продукту
            set { ProductName = value; } // Сеттер для встановлення назви продукту
        }

        public double Price
        {
            get { return price; } // І так далі аналогічно для ціни, кількості і типу продукту
            set { price = value; } 
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string ProductType
        {
            get { return productType; }
            set { productType = value; }
        }

        // Реалізація методу порівняння який використовуватимемо для того, щоб не було додавань продуктів з однаковою назвою
        // За вимогою реалізацій інтерфейсу Comparable
        public int CompareTo(Product other)
        {
            return this.Name.CompareTo(other.Name);
        }

        // Перевизначення методу для отримання інформації про продукт
        public override string GetInfo()
        {
            return $"Product: {Name}, Price: {price}, Quantity: {quantity}";
        }

        // Реалізація методу з інтерфейсу ICostCalculable (не бібліотечний, для вимоги) для підрахунку загальної вартості продукту
        public double CalculateTotalCost()
        {
            return this.price * this.quantity;
        }
    }
}
