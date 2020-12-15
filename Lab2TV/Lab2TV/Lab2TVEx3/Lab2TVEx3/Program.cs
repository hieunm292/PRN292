using System;
using System.Collections;
using System.IO;

namespace Lab2TVEx3
{

    class Account
    {
        private int accountID;
        private string firstName;
        private string lastName;
        private double balance;

        public Account()
        {
        }

        public Account(int accountID, string firstName, string lastName, double balance)
        {
            this.AccountID = accountID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Balance = balance;
        }

        public int AccountID { get => accountID; set => accountID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double Balance { get => balance; set => balance = value; }
        public void Input()
        {
            Console.WriteLine("Account ID: ");
            accountID = int.Parse(Console.ReadLine());
            Console.WriteLine("First Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Balance: ");
            balance = double.Parse(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine("Account ID: {0}", accountID);
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("Balance: {0}", balance);
        }
    }
    class Program
    {
        static ArrayList list = new ArrayList();
        public static void NewAccount()
        {
            Account acc = new Account();
            acc.Input();
            list.Add(acc);
        }
        public static void ShowList()
        {
            foreach (Account acc in list)
                acc.Show();
        }
        public static void InputList()
        {
            Console.WriteLine("Input amount accounts : ");
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                NewAccount();
                n--;
            }
        }
        public static void Savefile()
        {
            Console.WriteLine("Input file name to save: ");
            string fileName = Console.ReadLine();
            try
            {
                FileStream output = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write);
                StreamWriter writer = new StreamWriter(output);
                foreach (Account acc in list)
                {
                    writer.WriteLine("{0}, {1}, {2}, {3}", acc.AccountID, acc.FirstName, acc.LastName, acc.Balance);
                }
                writer.Close();
                output.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void LoadFile()
        {
            Console.WriteLine("Input file name to load: ");
            string fileName = Console.ReadLine();
            list.Clear();
            try
            {
                FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] ls = str.Split(',');
                    Account acc = new Account(int.Parse(ls[0]), ls[1], ls[2], double.Parse(ls[3]));
                    list.Add(acc);
                }
                input.Close();
                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            InputList();
            ShowList();
            Savefile();
        }
    }
}
