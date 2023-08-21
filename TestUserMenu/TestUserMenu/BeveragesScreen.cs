using System;
using System.Windows.Forms;

namespace TestUserMenu
{
    public partial class BeveragesScreen : Form
    {
        public BeveragesScreen()
        {
            InitializeComponent();
        }

        private void beverageButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string beverageName = clickedButton.Text.ToString();
            PizzaScreen beverageSearch = new PizzaScreen();
            beverageSearch.MenuSearch(beverageName);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
