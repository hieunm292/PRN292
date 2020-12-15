using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab2TVEx4
{
    class Account : IComparable
    {
        private string accountID;
        private string fName;
        private string lName;
        private double balance;

        public Account()
        {
        }

        public Account(string accountID, string fName, string lName, double balance)
        {
            this.AccountID = accountID;
            this.FName = fName;
            this.LName = lName;
            this.Balance = balance;
        }

        public string AccountID { get => accountID; set => accountID = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public double Balance { get => balance; set => balance = value; }

        public int CompareTo(object obj)
        {
            Account a1 = (Account)obj;
            return this.fName.CompareTo(a1.fName);
        }

        public override string ToString()
        {
            return "Account: " + accountID + "\nFirst Name: " + fName + "\nLast Name: " + lName + "\nBalance: " + balance;
        }

    }



    class accountList
    {
        static List<Account> a1 = new List<Account>();
        public accountList()
        {
            a1.Add(new Account("DE140048", "Hieu", "Nguyen", 400000));
            a1.Add(new Account("DE140049", "Minh", "Ha", 400000));
            a1.Add(new Account("DE140050", "Lam", "Nguyen", 20000));
            a1.Add(new Account("DE140051", "Hieu'", "Trung", 10000));
            a1.Add(new Account("DE140051", "Nhi", "Tran", 500000));
        }
        public void Input()
        {
            while (true)
            {
                Console.Write("Nhap account: ");
                string account = Console.ReadLine();
                Console.Write("Nhap first name: ");
                string fName = Console.ReadLine();
                Console.Write("Nhap last name: ");
                string lname = Console.ReadLine();
                Console.Write("Nhap balance: ");
                int balance = int.Parse(Console.ReadLine());

                a1.Add(new Account(account, fName, lname, balance));

                Console.Write("You wanna continue(Yes or No): ");
                string a = Console.ReadLine();
                if (a.Equals("n"))
                    break;
            }

        }
        public void Show()
        {
            foreach (Account a2 in a1)
            {
                Console.WriteLine(a2);
                Console.WriteLine("-------------------------------");
            }
        }
        public void saveFile()
        {
            Console.WriteLine("Enter file to save data: ");
            string fileName = Console.ReadLine();

            try
            {
                FileStream output = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write);
                StreamWriter writer = new StreamWriter(output);

                foreach (Account a2 in a1)
                {
                    writer.WriteLine("AccountID: {0}", a2.AccountID);
                    writer.WriteLine("FirstName: {0}", a2.FName);
                    writer.WriteLine("Last Name: {0}", a2.LName);
                    writer.WriteLine("Balance  : {0}", a2.Balance);
                    writer.WriteLine("----------------------------");
                }
                Console.WriteLine("Save File Success!!!");
                writer.Close();
                output.Close();
            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public void loadFile()
        {
            Console.WriteLine("Enter file to load data: ");
            string fileName = Console.ReadLine();

            a1.Clear();

            try
            {
                FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                StreamReader reader = new StreamReader(input);
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] list = str.Split(',');
                    Account acc = new Account(list[0], list[1], list[2], double.Parse(list[3]));
                    a1.Add(acc);
                }
                input.Close();
                reader.Close();
            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public void remove()
        {
            Console.Write("Enter accountID to delete: ");
            string a2 = Console.ReadLine();
            if (a1 == null)
                Console.WriteLine("List is null");
            for (int i = 0; i < a1.Count(); i++)
            {
                if (a2.Equals(a1[i].AccountID))
                {
                    a1.Remove(a1[i]);
                    break;
                }
            }
        }
        public void search()
        {

            Console.Write("Enter accountID to search: ");
            string a2 = Console.ReadLine();
            if (a1 == null)
                Console.WriteLine("List is null");
            for (int i = 0; i < a1.Count(); i++)
            {
                if (a2.Equals(a1[i].AccountID))
                {
                    Console.WriteLine(a1[i]);
                    break;
                }
            }
        }
        internal void Sort(IComparer<Account> Compare)
        {
            a1.Sort(Compare);
        }
    }


    class NameCompare : IComparer<Account>
    {
        int IComparer<Account>.Compare(Account x, Account y)
        {
            return x.FName.CompareTo(y.FName);
        }
    }


    class Program
    {

        static void menu()
        {
            Console.WriteLine("-----------Menu--------------");
            Console.WriteLine("1. New Account");
            Console.WriteLine("2. Save file");
            Console.WriteLine("3. Load file");
            Console.WriteLine("4. Report");
            Console.WriteLine("5. Sort");
            Console.WriteLine("6. Search");
            Console.WriteLine("7. Remove");
            Console.WriteLine("8. Exit");
        }
        static void Main(string[] args)
        {
            accountList a1 = new accountList();
            IComparer<Account> compare = new NameCompare();

            int choice;
            menu();
            do
            {
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Add acount");
                        a1.Input();
                        break;
                    case 2:
                        Console.WriteLine("Load file");
                        a1.saveFile();
                        break;
                    case 3:
                        Console.WriteLine("Save file");
                        a1.loadFile();
                        break;
                    case 4:
                        Console.WriteLine("Show account");
                        a1.Show();
                        break;
                    case 5:
                        Console.WriteLine("Sort account");
                        a1.Sort(compare);
                        Console.WriteLine("-------After Sort--------");
                        a1.Show();
                        break;
                    case 6:
                        Console.WriteLine("Search account");
                        a1.search();
                        break;
                    case 7:
                        Console.WriteLine("------Remove-------");
                        a1.remove();
                        break;
                    case 8:
                        Console.WriteLine("----------------Exit----------------");
                        break;
                }
            } while (choice > 0 && choice < 8);
        }
    }
}
