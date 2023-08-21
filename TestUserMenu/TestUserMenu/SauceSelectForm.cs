using System;
using System.Windows.Forms;

namespace TestUserMenu
{
    public partial class SauceSelectForm : Form
    {
        public SauceSelectForm()
        {
            InitializeComponent();
        }

        public static string sauceName;

        private void submitSauceButton_Click(object sender, EventArgs e)
        {
            sauceName = sauceTextBox.Text;
            PizzaScreen pizzaScreen = new PizzaScreen();
            pizzaScreen.MenuSearch("Add Sauce");
            this.Hide();
        }
    }
}
