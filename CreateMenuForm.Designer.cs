namespace Chef
{
    partial class CreateMenuForm
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
            this.clbRecipes = new System.Windows.Forms.CheckedListBox();
            this.nudNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.lblRecipes = new System.Windows.Forms.Label();
            this.lblNumberOfPeople = new System.Windows.Forms.Label();
            this.btnCreateMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).BeginInit();
            this.SuspendLayout();
            this.clbRecipes.FormattingEnabled = true;
            this.clbRecipes.Location = new System.Drawing.Point(12, 29);
            this.clbRecipes.Name = "clbRecipes";
            this.clbRecipes.Size = new System.Drawing.Size(260, 184);
            this.clbRecipes.TabIndex = 0;
            this.nudNumberOfPeople.Location = new System.Drawing.Point(162, 233);
            this.nudNumberOfPeople.Name = "nudNumberOfPeople";
            this.nudNumberOfPeople.Size = new System.Drawing.Size(110, 27);
            this.nudNumberOfPeople.TabIndex = 1;
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Location = new System.Drawing.Point(12, 6);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(61, 20);
            this.lblRecipes.TabIndex = 2;
            this.lblRecipes.Text = "Recipes";
            this.lblNumberOfPeople.AutoSize = true;
            this.lblNumberOfPeople.Location = new System.Drawing.Point(12, 235);
            this.lblNumberOfPeople.Name = "lblNumberOfPeople";
            this.lblNumberOfPeople.Size = new System.Drawing.Size(135, 20);
            this.lblNumberOfPeople.TabIndex = 3;
            this.lblNumberOfPeople.Text = "Number of People";
            this.btnCreateMenu.Location = new System.Drawing.Point(197, 266);
            this.btnCreateMenu.Name = "btnCreateMenu";
            this.btnCreateMenu.Size = new System.Drawing.Size(75, 23);
            this.btnCreateMenu.TabIndex = 4;
            this.btnCreateMenu.Text = "Create";
            this.btnCreateMenu.UseVisualStyleBackColor = true;
            this.btnCreateMenu.Click += new System.EventHandler(this.btnCreateMenu_Click);
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.btnCreateMenu);
            this.Controls.Add(this.lblNumberOfPeople);
            this.Controls.Add(this.lblRecipes);
            this.Controls.Add(this.nudNumberOfPeople);
            this.Controls.Add(this.clbRecipes);
            this.Name = "CreateMenuForm";
            this.Text = "Create Menu";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckedListBox clbRecipes;
        private System.Windows.Forms.NumericUpDown nudNumberOfPeople;
        private System.Windows.Forms.Label lblRecipes;
        private System.Windows.Forms.Label lblNumberOfPeople;
        private System.Windows.Forms.Button btnCreateMenu;
    }
}