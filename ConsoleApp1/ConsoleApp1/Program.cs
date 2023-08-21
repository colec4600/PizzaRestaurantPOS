replusing System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMenu();
            Console.WriteLine("Welcome to retirement calc");
            Console.WriteLine("Please enter the information");
            int annualyspent = int.Parse(Console.ReadLine());
            int retirementmoney = annualyspent * 25;
            int age = int.Parse(Console.ReadLine());
            int retirementage = int.Parse(Console.ReadLine());
            int savingsyears = retirementage - age;
            RunSpendinginRetirementModule(retirementmoney);
            RunSavingsRightNowModule(savingsyears, retirementage);
            RunSavingsNeededModule(savingsyears, retirementmoney);

        }

        public static void RunSpendinginRetirementModule(int moneyinretirement)
        {
            Console.WriteLine("How much do you anuually spend");
            double retirementspent = moneyinretirement * 0.03;
            Console.WriteLine("You will need {0} for retirement", moneyinretirement);
            Console.WriteLine("You can spend {0} each year during retirement", retirementspent);
        }

        public static void RunSavingsRightNowModule(int num1, int num2)
        {
            Console.WriteLine("how much you are currently saving");
            Console.WriteLine("how much are you saving a month");
            double savingmonth = double.Parse(Console.ReadLine());
            double savinginyear = savingmonth * 12;
            double retirementsavings = savinginyear * num1;
            Console.WriteLine("at the rate you are saving you will have {0} when you retire at age {1}", retirementsavings, num2);
        }

        public static void RunSavingsNeededModule(int num1, int moneyinretirement)
        {
            Console.WriteLine("how to save");
            Console.WriteLine("how much in savings do you have now");
            int savingsnow = int.Parse(Console.ReadLine());
            int savingsneeded = moneyinretirement - savingsnow;
            Console.WriteLine("Since you need {0} total but you already have {1}, then you will need {2}", moneyinretirement, savingsnow, savingsneeded);
            int savingsperyear = savingsneeded / num1;
            int savingspermonth = savingsperyear / 12;
            Console.WriteLine("You will have {0} years to save so you have to save {1} per year or {2} per month", num1, savingsperyear, savingspermonth);
            double interestrate = 0.06;
            double rate = interestrate / 12;
            double yearrate = num1 * 12;
            double compoundinterestform = savingsnow * Math.Pow(1 + rate, yearrate);
            double futurevalue = moneyinretirement - compoundinterestform;
            double monthlycont = 1 / (((Math.Pow(1 + rate, yearrate) - 1) / rate) / futurevalue);
            Console.WriteLine(monthlycont);
            Console.WriteLine(futurevalue);
        }

        public static void RunMenu()
        {
            Console.WriteLine("Retirement Calculator");
            Console.WriteLine("1) Spending in Retirement");
            Console.WriteLine("2) Savings Right Now");
            Console.WriteLine("3) Savings needed");
        }

    }