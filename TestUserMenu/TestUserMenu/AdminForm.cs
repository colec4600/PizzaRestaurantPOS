using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TestUserMenu
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        string fileName = "receipt" + AdminPopup.date;
        string directoryPath = "C:\\Users\\coled\\Desktop\\";

        private void salesByItemButton_Click(object sender, EventArgs e)
        {
            //Sales by Item
            /*Search file by date
             * search for lines with "$"
             * remove the lines that have total, tax, grand total, refund?, special?
             * store in array
             * count the number of same items in array
             * write the name and the number of sales
             */

            string[] foodItemArray = new string[50];
            string[] distinctFoodItemArray;
            int currentIndex = 0;
            int count = 0;
            string salesByItemFile = directoryPath + "SalesbyItem" + AdminPopup.date + ".txt";
            string[] files = Directory.GetFiles(directoryPath, fileName + "*");

            foreach (string receipt in files)
            {
                string[] lines = File.ReadAllLines(receipt);
                string searchPhrase = "$";

                foreach (string foodItem in lines)
                {
                    if (foodItem.Contains(searchPhrase) && !foodItem.Contains("Total") && !foodItem.Contains("Tax"))
                    {
                        foodItemArray[currentIndex] = foodItem;  // Add the string to the array
                        currentIndex++;
                    }
                }
            }
            Array.Resize(ref foodItemArray, currentIndex);
            distinctFoodItemArray = foodItemArray.Distinct().ToArray();

            foreach (string thing in distinctFoodItemArray)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine();
            foreach (string thing in foodItemArray)
            {
                Console.WriteLine(thing);
            }

            using (StreamWriter writer = File.CreateText(salesByItemFile))
            {
                writer.WriteLine("Sales by Item Report for " + AdminPopup.date);
                foreach (string thing in distinctFoodItemArray) // for each search result
                {
                    for (int i = 0; i < foodItemArray.Length; i++) // corrected condition
                    {
                        if (thing.Contains(foodItemArray[i]))
                        {
                            count++;
                        }
                    }
                    char delimeter = '.';
                    int delimiterIndex = thing.IndexOf(delimeter);
                    string finalFoodItem = thing.Substring(0, delimiterIndex);
                    writer.WriteLine(finalFoodItem + " has " + count.ToString() + " occurrences");
                    count = 0; // reset count for each search result

                }
            }
        }

        private void numberOfSalesButton_Click(object sender, EventArgs e)
        {
            //Number of Sales by Date
            string numberOfSalesFile = directoryPath + "NumberOfSales" + AdminPopup.date + ".txt";
            string[] files = Directory.GetFiles(directoryPath, fileName + "*");

            string lastFileName = files[files.Length - 1];
            string fileTotalPath = directoryPath + fileName;
            string modifiedString = lastFileName.Replace(fileTotalPath, "");
            string modifiedString2 = modifiedString.Replace(".txt", "");
            using (StreamWriter writer = File.CreateText(numberOfSalesFile))
            {
                writer.WriteLine("Number of Sales for " + AdminPopup.date);
                writer.WriteLine("The total number of sales for " + AdminPopup.date + " is " + modifiedString2);
            }
        }

        private void employeeSalesButton_Click(object sender, EventArgs e)
        {
            //Sales by Employee
            //search all files
            //search each files for Employee ID and store in array
            //count the number of same items in array
            //write the name and the number of sales

            string salesByEmployeeFile = directoryPath + "SalesbyEmployee" + AdminPopup.date + ".txt";
            string[] files = Directory.GetFiles(directoryPath, fileName + "*");
            string[] employeeNameListArray = new string[50];
            string[] distinctEmployeeNameListArray = new string[50];
            int currentIndex = 0;
            int count = 0;

            foreach (string file in files)
            {
                string[] lines = File.ReadAllLines(file);
                string searchPhrase = "Employee Name";
                foreach (string line in lines)
                {
                    if (line.Contains(searchPhrase))
                    {
                        employeeNameListArray[currentIndex] = line;  // Add the string to the array
                        currentIndex++;
                    }
                }
            }
            Array.Resize(ref employeeNameListArray, currentIndex);
            distinctEmployeeNameListArray = employeeNameListArray.Distinct().ToArray();

            currentIndex = 0;
            string search = distinctEmployeeNameListArray[currentIndex];
            foreach (string employeeName in employeeNameListArray) //for each search result
            {
                if (employeeName.Contains(search)) //if the element contains "Employee Name Cole"
                {
                    count += 1;
                }
            }
            string phraseToDelete = "Employee Name  ";
            string editedEmployee = search.Replace(phraseToDelete, string.Empty);
            using (StreamWriter writer = File.CreateText(salesByEmployeeFile))
            {
                writer.WriteLine("Sales by Employee for " + AdminPopup.date);
                writer.WriteLine(editedEmployee + " has " + count.ToString() + " occurences");
            }
        }


        private void salesByDateButton_Click(object sender, EventArgs e)
        {
            //Total Number of Sales
            /*search all files by date
             * for each file, search for the line of Grand Total
             * remove the Grand total number and store
             * using a for loop, it will search the file and when storing the variable, it will add to a grand total
             */

            string totalNumberOfSalesFile = directoryPath + "TotalNumberOfSales" + AdminPopup.date + ".txt";
            string[] files = Directory.GetFiles(directoryPath, fileName + "*");
            string[] totalArray = new string[50];
            int currentIndex = 0;
            double sum = 0;

            foreach (string file in files)
            {
                string[] lines = File.ReadAllLines(file);
                string searchPhrase = "Grand Total";

                foreach (string line in lines)
                {
                    if (line.Contains(searchPhrase))
                    {
                        string tmp1 = line.Replace("Grand Total", "");
                        string tmp2 = tmp1.Replace(" ", "");
                        string finalTotal = tmp2.Replace("$", "");
                        totalArray[currentIndex] = finalTotal;  // Add the string to the array
                        currentIndex++;
                    }
                }
            }
            Array.Resize(ref totalArray, currentIndex);
            double[] doubleArray = Array.ConvertAll(totalArray, Double.Parse);

            foreach (double total in doubleArray)
            {
                sum += total;
            }
            using (StreamWriter writer = File.CreateText(totalNumberOfSalesFile))
            {
                writer.WriteLine("Total number of sales for " + AdminPopup.date);
                writer.WriteLine("The total number of sales for today is " + sum.ToString("C"));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string directoryPath = "C:\\Users\\coled\\Desktop\\";

            /*
             * user will input 20230528
             * user will input 20230530
             * 
             */
            int fileName = 20230528;
            int fileName2 = 20230530;
            List<string> stringList = new List<string>();

            for (int i = fileName; i <= fileName2; i++)
            {
                string fileSearch = "receipt" + fileName;
                string[] files = Directory.GetFiles(directoryPath, fileSearch + "*");
                stringList.AddRange(files);
            }

        }
    }
}

