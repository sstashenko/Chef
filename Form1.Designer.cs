namespace Chef
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstRecentMenus = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.recipesToolStripMenuItem,
            this.menusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.removeProductToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.productsToolStripMenuItem.Text = "Products";
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            this.removeProductToolStripMenuItem.Name = "removeProductToolStripMenuItem";
            this.removeProductToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.removeProductToolStripMenuItem.Text = "Remove Product";
            this.removeProductToolStripMenuItem.Click += new System.EventHandler(this.removeProductToolStripMenuItem_Click);
            this.recipesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecipeToolStripMenuItem,
            this.viewRecipesToolStripMenuItem,
            this.removeRecipeToolStripMenuItem});
            this.recipesToolStripMenuItem.Name = "recipesToolStripMenuItem";
            this.recipesToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.recipesToolStripMenuItem.Text = "Recipes";
            this.addRecipeToolStripMenuItem.Name = "addRecipeToolStripMenuItem";
            this.addRecipeToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.addRecipeToolStripMenuItem.Text = "Add Recipe";
            this.addRecipeToolStripMenuItem.Click += new System.EventHandler(this.addRecipeToolStripMenuItem_Click);
            this.viewRecipesToolStripMenuItem.Name = "viewRecipesToolStripMenuItem";
            this.viewRecipesToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.viewRecipesToolStripMenuItem.Text = "View Recipes";
            this.viewRecipesToolStripMenuItem.Click += new System.EventHandler(this.viewRecipesToolStripMenuItem_Click);
            this.removeRecipeToolStripMenuItem.Name = "removeRecipeToolStripMenuItem";
            this.removeRecipeToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.removeRecipeToolStripMenuItem.Text = "Remove Recipe";
            this.removeRecipeToolStripMenuItem.Click += new System.EventHandler(this.removeRecipeToolStripMenuItem_Click);
            this.menusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMenuToolStripMenuItem,
            this.checkStockToolStripMenuItem});
            this.menusToolStripMenuItem.Name = "menusToolStripMenuItem";
            this.menusToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.menusToolStripMenuItem.Text = "Menus";
            this.createMenuToolStripMenuItem.Name = "createMenuToolStripMenuItem";
            this.createMenuToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.createMenuToolStripMenuItem.Text = "Create Menu";
            this.createMenuToolStripMenuItem.Click += new System.EventHandler(this.createMenuToolStripMenuItem_Click);
            this.checkStockToolStripMenuItem.Name = "checkStockToolStripMenuItem";
            this.checkStockToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.checkStockToolStripMenuItem.Text = "Check Stock";
            this.checkStockToolStripMenuItem.Click += new System.EventHandler(this.checkStockToolStripMenuItem_Click);
            this.lstRecentMenus.FormattingEnabled = true;
            this.lstRecentMenus.ItemHeight = 20;
            this.lstRecentMenus.Location = new System.Drawing.Point(12, 40);
            this.lstRecentMenus.Name = "lstRecentMenus";
            this.lstRecentMenus.Size = new System.Drawing.Size(776, 400);
            this.lstRecentMenus.TabIndex = 1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstRecentMenus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Chef Application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkStockToolStripMenuItem;
        private System.Windows.Forms.ListBox lstRecentMenus;
    }
}
