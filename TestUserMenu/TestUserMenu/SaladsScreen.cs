using System;
using System.Windows.Forms;

namespace TestUserMenu
{
    public partial class SaladsScreen : Form
    {
        public SaladsScreen()
        {
            InitializeComponent();
        }

        private void saladButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string beverageName = clickedButton.Text.ToString();
            PizzaScreen saladSearch = new PizzaScreen();
            saladSearch.MenuSearch(beverageName);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
