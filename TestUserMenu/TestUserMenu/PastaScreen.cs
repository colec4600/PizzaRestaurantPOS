using System;
using System.Windows.Forms;

namespace TestUserMenu
{
    public partial class PastaScreen : Form
    {
        public PastaScreen()
        {
            InitializeComponent();
        }

        private void pastaButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string pastaName = clickedButton.Text.ToString().Substring(0, 5) + " Pasta";
            PizzaScreen pastaSearch = new PizzaScreen();
            pastaSearch.MenuSearch(pastaName);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void addSide_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string pastaName = clickedButton.Text.ToString();
            PizzaScreen pastaSearch = new PizzaScreen();
            pastaSearch.MenuSearch(pastaName);
        }
    }
}
