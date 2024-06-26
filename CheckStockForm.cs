using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chef
{
    // Форма для перевірки запасів продуктів на складі
    public partial class CheckStockForm : Form
    {
        private Inventory inventory; // Посилання на об'єкт інвентарю

        // Конструктор форми, приймає об'єкт інвентарю
        public CheckStockForm(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory; // Ініціалізація інвентарю
            DisplayStock(); // Відображення запасів продуктів на складі
        }

        // Метод для відображення запасів продуктів на складі
        private void DisplayStock()
        {
            listViewStock.Items.Clear(); // Очищення списку продуктів у ListView

            // Перебір кожного продукту в інвентарі
            foreach (var product in inventory.GetProducts())
            {
                // Створення нового елемента ListView для кожного продукту
                var item = new ListViewItem(new[]
                {
                    product.Name, // Назва продукту
                    product.Price.ToString(), // Ціна продукту
                    product.Quantity.ToString() // Кількість продукту
                });

                listViewStock.Items.Add(item); // Додавання елемента до ListView
            }
        }

        // Обробник події натискання на кнопку "Calculate Total Cost"
        private void btnCalculateTotalCost_Click(object sender, EventArgs e)
        {
            // Обчислення загальної вартості всіх продуктів у інвентарі
            double totalCost = inventory.CalculateTotalCost();

            // Відображення загальної вартості у MessageBox
            MessageBox.Show($"Total inventory cost: {totalCost:C}", "Total Cost", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
