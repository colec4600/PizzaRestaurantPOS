using System;
using System.IO;
using System.Windows.Forms;

namespace TestUserMenu
{
    public partial class SpecialsScreen : Form
    {
        public SpecialsScreen()
        {
            InitializeComponent();
        }

        string filename = NewCustomerScreen.filename;

        private void wingsSpecialButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string specialName = clickedButton.Text.ToString();
            PizzaScreen.totalPrice -= 4;
            int totalWidth = 78; // Total width of the line/page
            int leadingSpaces = (totalWidth - ((int)specialName.Length) - 3);
            string centeredText = specialName + new string('.', leadingSpaces) + "-$4.00";
            WriteSpecial(centeredText);
        }

        public void WriteSpecial(string centeredText)
        {
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                writer.WriteLine(centeredText);
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void specialtyPizzaSpecialButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string specialName = clickedButton.Text.ToString();
            PizzaScreen.totalPrice -= 3;
            int totalWidth = 78; // Total width of the line/page
            int leadingSpaces = (totalWidth - ((int)specialName.Length) - 3);
            string centeredText = specialName + new string('.', leadingSpaces) + "-$3.00";
            WriteSpecial(centeredText);
        }

        private void singleToppingSpecialButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string specialName = clickedButton.Text.ToString();
            PizzaScreen.totalPrice -= 3;
            int totalWidth = 78; // Total width of the line/page
            int leadingSpaces = (totalWidth - ((int)specialName.Length) - 3);
            string centeredText = specialName + new string('.', leadingSpaces) + "-$3.00";
            WriteSpecial(centeredText);
        }

        private void pastaSpecialButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string specialName = clickedButton.Text.ToString();
            PizzaScreen.totalPrice -= 2;
            int totalWidth = 78; // Total width of the line/page
            int leadingSpaces = (totalWidth - ((int)specialName.Length) - 3);
            string centeredText = specialName + new string('.', leadingSpaces) + "-$2.00";
            WriteSpecial(centeredText);
        }
    }
}
