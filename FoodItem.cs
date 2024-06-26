using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef
{
    // Абстрактний клас, який представляє харчовий елемент
    public abstract class FoodItem
    {
        // Захищена змінна, яка зберігає назву продукту, яку можна використовувати лише в класах, які наслідуються
        // Для вимоги змінної protected
        protected string ProductName;
        // Абстрактний метод, який повинен бути реалізований в похідних класах
        public abstract string GetInfo();
    }

}
