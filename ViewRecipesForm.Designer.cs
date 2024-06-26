namespace Chef
{
    partial class ViewRecipesForm
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
            listViewRecipes = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderInstructions = new ColumnHeader();
            SuspendLayout();
            // 
            // listViewRecipes
            // 
            listViewRecipes.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderInstructions });
            listViewRecipes.Location = new Point(12, 12);
            listViewRecipes.Name = "listViewRecipes";
            listViewRecipes.Size = new Size(482, 316);
            listViewRecipes.TabIndex = 0;
            listViewRecipes.UseCompatibleStateImageBehavior = false;
            listViewRecipes.View = View.Details;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 120;
            // 
            // columnHeaderInstructions
            // 
            columnHeaderInstructions.Text = "Instructions";
            columnHeaderInstructions.Width = 240;
            // 
            // ViewRecipesForm
            // 
            ClientSize = new Size(527, 391);
            Controls.Add(listViewRecipes);
            Name = "ViewRecipesForm";
            Text = "View Recipes";
            ResumeLayout(false);
        }

        private System.Windows.Forms.ListView listViewRecipes;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderInstructions;

    }
}