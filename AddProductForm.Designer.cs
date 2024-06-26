namespace Chef
{
    partial class AddProductForm
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
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            cmbProductType = new ComboBox();
            lblName = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblProductType = new Label();
            btnAdd = new Button();
            SuspendLayout();
            txtName.Location = new Point(110, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 27);
            txtName.TabIndex = 0;
            txtPrice.Location = new Point(110, 65);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 27);
            txtPrice.TabIndex = 1;
            txtQuantity.Location = new Point(110, 105);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 27);
            txtQuantity.TabIndex = 2; 
            cmbProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductType.FormattingEnabled = true;
            cmbProductType.Location = new Point(126, 145);
            cmbProductType.Name = "cmbProductType";
            cmbProductType.Size = new Size(121, 28);
            cmbProductType.TabIndex = 3;
            lblName.AutoSize = true;
            lblName.Location = new Point(25, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Name"; 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(25, 68);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(25, 108);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity";
            lblProductType.AutoSize = true;
            lblProductType.Location = new Point(25, 148);
            lblProductType.Name = "lblProductType";
            lblProductType.Size = new Size(95, 20);
            lblProductType.TabIndex = 7;
            lblProductType.Text = "Product Type";
            btnAdd.Location = new Point(110, 190);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 26);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            ClientSize = new Size(284, 261);
            Controls.Add(btnAdd);
            Controls.Add(lblProductType);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(cmbProductType);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Name = "AddProductForm";
            Text = "Add Product";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Button btnAdd;
    }
}