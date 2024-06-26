namespace Chef
{
    partial class AddRecipeForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.clbIngredients = new System.Windows.Forms.CheckedListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.txtName.Location = new System.Drawing.Point(110, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 0;
            this.txtInstructions.Location = new System.Drawing.Point(110, 65);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(200, 60);
            this.txtInstructions.TabIndex = 1;
            this.clbIngredients.FormattingEnabled = true;
            this.clbIngredients.Location = new System.Drawing.Point(110, 145);
            this.clbIngredients.Name = "clbIngredients";
            this.clbIngredients.Size = new System.Drawing.Size(200, 92);
            this.clbIngredients.TabIndex = 2;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(25, 68);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(84, 20);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "Instructions";
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(25, 145);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(83, 20);
            this.lblIngredients.TabIndex = 5;
            this.lblIngredients.Text = "Ingredients";
            this.btnAdd.Location = new System.Drawing.Point(110, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.clbIngredients);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.txtName);
            this.Name = "AddRecipeForm";
            this.Text = "Add Recipe";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.CheckedListBox clbIngredients;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Button btnAdd;
    }
}