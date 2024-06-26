namespace Chef
{
    partial class RemoveRecipeForm
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
            this.lstRecipes = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lstRecipes.FormattingEnabled = true;
            this.lstRecipes.ItemHeight = 20;
            this.lstRecipes.Location = new System.Drawing.Point(12, 12);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(260, 184);
            this.lstRecipes.TabIndex = 0;
            this.btnRemove.Location = new System.Drawing.Point(197, 202);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.ClientSize = new System.Drawing.Size(284, 237);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstRecipes);
            this.Name = "RemoveRecipeForm";
            this.Text = "Remove Recipe";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox lstRecipes;
        private System.Windows.Forms.Button btnRemove;
    }
}