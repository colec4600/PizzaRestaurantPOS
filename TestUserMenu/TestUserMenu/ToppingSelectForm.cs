using System;
using System.Windows.Forms;

namespace TestUserMenu
{
    public partial class ToppingSelectForm : Form
    {
        public ToppingSelectForm()
        {
            InitializeComponent();
        }
        public static string inputTopping;
        public static string inputSingleSize;

        private void submitButton_Click(object sender, EventArgs e)
        {
            inputSingleSize = sizeTextBox.Text;
            inputTopping = toppingTextBox.Text;
            string pizzaSearch = inputSingleSize + " Single Topping Pizza";
            PizzaScreen pizzaScreen = new PizzaScreen();
            pizzaScreen.MenuSearch(pizzaSearch);
            this.Hide();
            pizzaScreen.Show();
        }
    }
}
