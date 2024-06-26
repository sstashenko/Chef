using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chef
{
    // Форма для додавання нового продукту до інвентарю
    public partial class AddProductForm : Form
    {
        private Inventory inventory; // Посилання на об'єкт інвентарю
        private DataManager dataManager; // Посилання на об'єкт менеджера даних

        // Конструктор форми, приймає об'єкт інвентарю та менеджера даних
        public AddProductForm(Inventory inventory, DataManager dataManager)
        {
            InitializeComponent();
            this.inventory = inventory; // Ініціалізація інвентарю
            this.dataManager = dataManager; // Ініціалізація менеджера даних
            PopulateProductTypes(); // Заповнення списку типів продуктів
        }

        // Метод для заповнення списку типів продуктів
        private void PopulateProductTypes()
        {
            // Додавання типів продуктів до випадаючого списку
            cmbProductType.Items.AddRange(new string[] { "Овочі", "Фрукти", "М'ясо", "Хліб", "Молочні продукти" });
            cmbProductType.SelectedIndex = 0; // Встановлення першого елементу за замовчуванням
        }

        // Обробник події натискання на кнопку "Add"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Зчитування даних з полів введення
            string name = txtName.Text;
            double price;
            int quantity;

            // Валідація введених даних
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Будь ласка, введіть дійсне ім'я продукту.");
                return;
            }

            if (!double.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Будь ласка, введіть дійсну ціну.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Будь ласка, введіть дійсну кількість.");
                return;
            }

            string productType = cmbProductType.SelectedItem.ToString();

            // Створення нового об'єкта продукту
            Product product = new Product(name, price, quantity, productType);

            // Спроба додати продукт до інвентарю
            if (inventory.TryAddProduct(product))
            {
                try
                {
                    // Збереження інвентарю до файлу
                    dataManager.SaveInventory(inventory, "inventory.xml");
                    MessageBox.Show("Продукт успішно додано!"); // Повідомлення про успішне додавання
                    ClearForm(); // Очистити форму після успішного додавання
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка при збереженні інвентарю: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Продукт вже існує."); // Повідомлення про те, що продукт вже існує
            }
        }

        // Метод для очищення форми
        private void ClearForm()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            cmbProductType.SelectedIndex = 0;
        }
    }
}

