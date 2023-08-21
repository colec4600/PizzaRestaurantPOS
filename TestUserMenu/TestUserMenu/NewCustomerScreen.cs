using System;
using System.IO;
using System.Windows.Forms;

namespace TestUserMenu
{
    public partial class NewCustomerScreen : Form
    {
        public NewCustomerScreen(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        public string username;
        public static string filename;

        public void newCustomerButton_Click(object sender, EventArgs e)
        {
            int i = TestUserMenu.Menu.i;
            string now = DateTime.Now.ToString("yyyyMMdd");
            string defFileName = "C:\\Users\\coled\\Desktop\\receipt";
            string fileEnding = ".txt";
            filename = defFileName + now + i.ToString() + fileEnding;
            string text = "Receipt";
            int totalWidth = 80;
            int leadingSpaces = (totalWidth - (int)text.Length) / 2;
            string centeredText = new string(' ', leadingSpaces) + text;
            using (StreamWriter writer = File.CreateText(filename))
            {
                writer.WriteLine(centeredText);
                writer.WriteLine("Employee Name  " + username.Substring(0, 1).ToUpper() + username.Substring(1));
                writer.WriteLine("Transaction ID  " + i);
                writer.WriteLine();
            }
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
