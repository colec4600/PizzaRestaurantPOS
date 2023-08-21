using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TestUserMenu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public static int i = 1;
        public static decimal refundValue = 0;
        public static string username;

        private void pizzaScreenButton_Click(object sender, EventArgs e)
        {
            PizzaScreen pizzaScreen = new PizzaScreen();
            pizzaScreen.Show();
            this.Hide();
        }

        private void submitReceiptButton_Click(object sender, EventArgs e)
        {
            double stateTax = 0.04225;
            string filename = NewCustomerScreen.filename;

            if (refundValue > 0)
            {
                using (StreamWriter writer = new StreamWriter(filename, true))
                {
                    int totalWidth = 78; // Total width of the line/page
                    string intro = "Customer has been given refund of";
                    int leadingSpaces = (totalWidth - (intro.Length) - 2);
                    string centeredText = intro + new string('.', leadingSpaces) + refundValue.ToString("C");
                    writer.WriteLine(centeredText);
                }

            }
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                writer.WriteLine("Total" + string.Concat(Enumerable.Repeat(".", 71)) + PizzaScreen.totalPrice.ToString("C"));
                double totalPriceTax = Math.Round(Convert.ToDouble(PizzaScreen.totalPrice) * stateTax, 2);
                double totalPricewithTax = Math.Round(totalPriceTax + Convert.ToDouble(PizzaScreen.totalPrice), 2);
                writer.WriteLine("Tax" + string.Concat(Enumerable.Repeat(".", 73)) + totalPriceTax.ToString("C"));
                writer.WriteLine("Grand Total" + string.Concat(Enumerable.Repeat(" ", 65)) + totalPricewithTax.ToString("C"));
            }
            PizzaScreen.totalPrice = 0;
            NewCustomerScreen newCustomerScreen = new NewCustomerScreen(username);
            newCustomerScreen.Show();
            this.Hide();
            i++;
        }

        private void cancelReceiptButton_Click(object sender, EventArgs e)
        {
            NewCustomerScreen newCustomerScreen = new NewCustomerScreen(username);
            newCustomerScreen.Show();
            this.Hide();
        }

        private void cancelLastItemButton_Click(object sender, EventArgs e)
        {
            string filename = NewCustomerScreen.filename;
            List<string> lines = File.ReadAllLines(filename).ToList();
            File.WriteAllLines(filename, lines.GetRange(0, lines.Count - 1).ToArray());
        }

        private void specialsScreenButton_Click(object sender, EventArgs e)
        {
            SpecialsScreen specialsScreen = new SpecialsScreen();
            specialsScreen.Show();
            this.Hide();
        }

        private void refundButton_Click(object sender, EventArgs e)
        {
            Form inputBox = new Form();
            inputBox.Text = "Enter amount: ";

            // Create a label and a textbox for the input box
            Label label = new Label();
            label.Text = "Refund Amount:";
            TextBox textBox = new TextBox();

            // Add the label and the textbox to the input box
            inputBox.Controls.Add(label);
            inputBox.Controls.Add(textBox);

            // Create a button to submit the input
            Button button = new Button();
            button.Text = "OK";
            button.DialogResult = DialogResult.OK;
            inputBox.Controls.Add(button);

            // Set the size and position of the input box controls
            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            button.SetBounds(309, 72, 75, 23);

            // Set the input box properties
            inputBox.ClientSize = new System.Drawing.Size(396, 107);
            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;
            inputBox.StartPosition = FormStartPosition.CenterScreen;

            // Display the input box and get the input value
            DialogResult result = inputBox.ShowDialog();
            if (result == DialogResult.OK)
            {
                string inputValue = textBox.Text;
                MessageBox.Show("Customer has been refunded: " + inputValue);
                refundValue = decimal.Parse(inputValue);
                PizzaScreen.totalPrice -= refundValue;
            }
        }

        private void sidesScreenButton_Click(object sender, EventArgs e)
        {
            SidesScreen sidesScreen = new SidesScreen();
            sidesScreen.Show();
            this.Hide();
        }

        private void pastaScreenButton_Click(object sender, EventArgs e)
        {
            PastaScreen pastaScreen = new PastaScreen();
            pastaScreen.Show();
            this.Hide();
        }

        private void saladsScreenButton_Click(object sender, EventArgs e)
        {
            SaladsScreen saladsScreen = new SaladsScreen();
            saladsScreen.Show();
            this.Hide();
        }

        private void beveragesScreenButton_Click(object sender, EventArgs e)
        {
            BeveragesScreen beveragesScreen = new BeveragesScreen();
            beveragesScreen.Show();
            this.Hide();
        }
    }
}
