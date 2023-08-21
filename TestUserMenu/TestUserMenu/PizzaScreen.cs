using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TestUserMenu
{
    public partial class PizzaScreen : Form
    {

        public PizzaScreen()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-H8375L8\SQLEXPRESS;Initial Catalog=MenuTestDB;Integrated Security=True");
        public static decimal totalPrice = 0;
        public static string inputSize;

        private void specialtyPizzaButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string pizzaName = clickedButton.Text;
            SpecialtyPizzaPopup(pizzaName);
        }

        private void singleToppingButton_Click(object sender, EventArgs e)
        {
            ToppingSelectForm toppingSelect = new ToppingSelectForm();
            toppingSelect.Show();
            this.Hide();
        }

        public void MenuSearch(string pizzaSearch)
        {
            string querry = "SELECT * FROM MenuTestDB WHERE pizza = '" + pizzaSearch + "'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            decimal price = (from DataRow dr in dataTable.Rows
                             where (string)dr["pizza"] == pizzaSearch
                             select (decimal)dr["price"]).FirstOrDefault();
            if (pizzaSearch.Contains("Single Topping"))
            {
                string size = ToppingSelectForm.inputSingleSize;
                string input = ToppingSelectForm.inputTopping;
                string pizzaSingleSearch = size + " " + input + " Pizza";
                PrintReceipt(pizzaSingleSearch, price);
            }
            else if (pizzaSearch.Contains("Sauce") && !pizzaSearch.Contains("Meat"))
            {
                string sauceName = SauceSelectForm.sauceName;
                string sauceSearch = "Add " + sauceName;
                PrintReceipt(sauceSearch, price);
            }

            else
            {
                PrintReceipt(pizzaSearch, price);
            }

        }

        public void PrintReceipt(string pizzaSearch, decimal price)
        {
            string filename = NewCustomerScreen.filename;
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                int totalWidth = 80; // Total width of the line/page
                int leadingSpaces = (totalWidth - ((int)pizzaSearch.Length) - 4);
                string centeredText = pizzaSearch + new string('.', leadingSpaces) + price.ToString("C");
                writer.WriteLine(centeredText);
                totalPrice += price;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        public void SpecialtyPizzaPopup(string pizzaName)
        {
            Form inputBox = new Form();
            inputBox.Text = "Enter a value";

            // Create a label and a textbox for the input box
            Label label = new Label();
            label.Text = "Value:";
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
                inputSize = textBox.Text;
                MessageBox.Show("Customer has input size: " + inputSize);
                string pizzaSearch = inputSize + " " + pizzaName;
                MenuSearch(pizzaSearch);
            }
        }
    }
}
