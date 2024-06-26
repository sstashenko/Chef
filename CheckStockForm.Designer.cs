namespace Chef
{
    partial class CheckStockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            listViewStock = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderPrice = new ColumnHeader();
            columnHeaderQuantity = new ColumnHeader();
            btnCalculateTotalCost = new Button();
            SuspendLayout();
            listViewStock.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderPrice, columnHeaderQuantity });
            listViewStock.Location = new Point(12, 50);
            listViewStock.Name = "listViewStock";
            listViewStock.Size = new Size(360, 200);
            listViewStock.TabIndex = 0;
            listViewStock.UseCompatibleStateImageBehavior = false;
            listViewStock.View = View.Details;
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 120;
            columnHeaderPrice.Text = "Price";
            columnHeaderPrice.Width = 120;
            columnHeaderQuantity.Text = "Quantity";
            columnHeaderQuantity.Width = 120;
            btnCalculateTotalCost.Location = new Point(12, 12);
            btnCalculateTotalCost.Name = "btnCalculateTotalCost";
            btnCalculateTotalCost.Size = new Size(150, 30);
            btnCalculateTotalCost.TabIndex = 1;
            btnCalculateTotalCost.Text = "Calculate Total Cost";
            btnCalculateTotalCost.UseVisualStyleBackColor = true;
            btnCalculateTotalCost.Click += btnCalculateTotalCost_Click;
            ClientSize = new Size(384, 261);
            Controls.Add(listViewStock);
            Controls.Add(btnCalculateTotalCost);
            Name = "CheckStockForm";
            Text = "Check Stock";
            ResumeLayout(false);
        }

        private System.Windows.Forms.ListView listViewStock;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantity;
        private System.Windows.Forms.Button btnCalculateTotalCost;
    }
}