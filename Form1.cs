namespace Chef
{
    public partial class Form1 : Form
    {
        private Inventory inventory = new Inventory();
        private List<Recipe> recipes = new List<Recipe>();
        private DataManager dataManager = new DataManager();
        private List<Menu> recentMenus = new List<Menu>();

        public Form1()
        {
            InitializeComponent();
            LoadData();
            DisplayRecentMenus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm(inventory, dataManager);
            addProductForm.ShowDialog();
        }

        private void removeProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var removeProductForm = new RemoveProductForm(inventory, dataManager);
            removeProductForm.ShowDialog();
        }

        private void addRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addRecipeForm = new AddRecipeForm(recipes, inventory, dataManager);
            addRecipeForm.ShowDialog();
        }

        private void viewRecipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewRecipesForm = new ViewRecipesForm(recipes);
            viewRecipesForm.ShowDialog();
        }

        private void removeRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var removeRecipeForm = new RemoveRecipeForm(recipes, dataManager);
            removeRecipeForm.ShowDialog();
        }

        private void createMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createMenuForm = new CreateMenuForm(recipes, inventory, dataManager, recentMenus);
            createMenuForm.ShowDialog();
            DisplayRecentMenus();
        }

        private void checkStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var checkStockForm = new CheckStockForm(inventory);
            checkStockForm.ShowDialog();
        }

        private void SaveData()
        {
            dataManager.SaveInventory(inventory, "inventory.xml");
            dataManager.SaveRecipes(recipes, "recipes.xml");
        }

        private void LoadData()
        {
            dataManager.LoadInventory(inventory, "inventory.xml");
            dataManager.LoadRecipes(recipes, "recipes.xml");
        }

        private void DisplayRecentMenus()
        {
            lstRecentMenus.Items.Clear();
            foreach (var menu in recentMenus)
            {
                lstRecentMenus.Items.Add(menu.GetInfo());
            }
        }
    }
}
