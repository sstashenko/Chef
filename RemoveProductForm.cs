using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chef
{
    // Форма для видалення продукту з інвентарю
    public partial class RemoveProductForm : Form
    {
        private Inventory inventory; // Посилання на об'єкт інвентарю
        private DataManager dataManager; // Посилання на об'єкт менеджера даних

        // Конструктор форми, приймає об'єкт інвентарю та менеджера даних
        public RemoveProductForm(Inventory inventory, DataManager dataManager)
        {
            InitializeComponent();
            this.inventory = inventory; // Ініціалізація інвентарю
            this.dataManager = dataManager; // Ініціалізація менеджера даних
            PopulateProductList(); // Заповнення списку продуктів
        }

        // Метод для заповнення списку продуктів
        private void PopulateProductList()
        {
            lstProducts.Items.Clear(); // Очищення списку продуктів у ListBox

            // Перебір кожного продукту в інвентарі
            foreach (var product in inventory.GetProducts())
            {
                // Додаємо назву продукту до ListBox
                lstProducts.Items.Add(product.Name);
            }
        }

        // Обробник події натискання на кнопку "Remove"
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Отримання назви вибраного продукту
            var selectedProduct = lstProducts.SelectedItem?.ToString();

            if (selectedProduct != null)
            {
                // Видалення продукту з інвентарю за назвою
                inventory.RemoveProductByName(selectedProduct);

                // Збереження змін в інвентарі до файлу
                dataManager.SaveInventory(inventory, "inventory.xml");

                // Повідомлення про успішне видалення продукту
                MessageBox.Show("Product removed successfully!");

                // Оновлення списку продуктів
                PopulateProductList();
            }
            else
            {
                // Повідомлення про те, що продукт не вибраний
                MessageBox.Show("Please select a product to remove.");
            }
        }
    }
}
