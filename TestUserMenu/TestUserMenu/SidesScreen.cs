using System;
using System.Windows.Forms;

namespace TestUserMenu
{
    public partial class SidesScreen : Form
    {
        public SidesScreen()
        {
            InitializeComponent();
        }

        private void sideButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string sideName = clickedButton.Text.ToString();
            PizzaScreen sideSearch = new PizzaScreen();
            sideSearch.MenuSearch(sideName);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            SauceSelectForm sauceSelectForm = new SauceSelectForm();
            sauceSelectForm.Show();
        }
    }
}
