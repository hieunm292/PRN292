using System;

namespace Lab1bai4
{
    public class People
    {
        public String name;
        public String birthday;
        public String degree;

        public People()
        {
            name = "";
            birthday = "";
            degree = "";
        }

        public People(string name, string birthday, string degree)
        {
            this.name = name;
            this.birthday = birthday;
            this.degree = degree;
        }

        public void Input()
        {
            Console.WriteLine("Enter name : ");
            name=Console.ReadLine();
            Console.WriteLine("Enter birthday : ");
            birthday = Console.ReadLine();
            Console.WriteLine("Enter degree : ");
            degree = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine("Name {0}" , name);
            Console.WriteLine("Birthday {0}" , birthday);
            Console.WriteLine("Degree {0}" , degree);
        }
    }

    public class Scientist : People
    {
        public String position;
        public int totalNews;
        public int totalWorkDays;
        public double salary;

        public Scientist() : base()
        {
            position = "";
            totalNews = 0;
            totalWorkDays = 0;
            salary = 0;
        }

        public Scientist(string name, string birthday, string degree,String position,
            int totalNews, int totalWorkDays, double salary) : base(name, birthday, degree)
        {
            this.position = position;
            this.totalNews = totalNews;
            this.totalWorkDays = totalWorkDays;
            this.salary = salary;
        }

        public void Input()
        {
            base.Input();
            Console.WriteLine("Enter position : ");
            position = Console.ReadLine();
            Console.WriteLine("Enter total News : ");
            totalNews = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter total Work Days : ");
            totalWorkDays = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Wage Salary : ");
            salary = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("position {0}" , position);
            Console.WriteLine("total News {0}" , totalNews);
            Console.WriteLine("total Work Days {0}" , totalWorkDays);
            Console.WriteLine("Salary of the Scientist {0} is {1}" ,name, totalWorkDays * salary);
        }

        public double Sum()
        {
            double r;
            r = (totalWorkDays * salary);
            return (r);
        }

    }

    public class Manager : People
    {
        public String position;
        public int totalWorkDays;
        public double salary;

        public Manager() : base()
        {
            position = "";
            totalWorkDays = 0;
            salary = 0;
        }

        public Manager(string name, string birthday, string degree, String position, int totalWorkDays, double salary) : base(name, birthday, degree)
        {
            this.position = position;
            this.totalWorkDays = totalWorkDays;
            this.salary = salary;
        }

        public void Input()
        {
            base.Input();
            Console.WriteLine("Enter position : ");
            position = Console.ReadLine();
            Console.WriteLine("Enter total Work Days : ");
            totalWorkDays = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Wage Salary : ");
            salary = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("position {0}" , position);
            Console.WriteLine("total Work Days {0}" , totalWorkDays);
            Console.WriteLine("Salary of th Manager {0} is {1}" ,name, totalWorkDays * salary);
        }

        public double Sum()
        {
            double r;
            r = (totalWorkDays * salary);
            return (r);
        }

    }

    public class Worker : People
    {
        public double salary;

        public Worker() : base()
        {
            salary = 0;
        }

        public Worker(string name, string birthday, string degree, double salary) : base(name, birthday, degree)
        {
            this.salary = salary;
        }

        public void Input()
        {
            base.Input();
            Console.WriteLine("Enter Salary : ");
            salary = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("Salary of the worker {0} is {1}" ,name, salary);
        }

        public double Sum()
        {
            return salary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n, p, o;
            Console.Write("Enter a number of Worker : ");
            n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a number of Manager:");
            p = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a number of Scientist :");
            o = Int32.Parse(Console.ReadLine());

            Worker[] nv = new Worker[n];
            Manager[] ql = new Manager[p];
            Scientist[] kh = new Scientist[o];
            {
                Console.WriteLine("Enter a data for worker :  ");
                for (int i = 0; i < n; i++)
                {
                    nv[i] = new Worker();
                    nv[i].Input();
                }
            }
            {
                Console.WriteLine();
                Console.WriteLine("Enter a data for Manager : ");
                for (int j = 0; j < p; j++)
                {
                    ql[j] = new Manager();
                    ql[j].Input();
                }
            }
            {
                Console.WriteLine();
                Console.WriteLine("Enter a data for Scientist : ");
                for (int k = 0; k < o; k++)
                {
                    kh[k] = new Scientist();
                    kh[k].Input();
                }
            }
            Console.Clear();
            double m, q, b;
            m = 0;
            q = 0;
            b = 0;
            for (int i = 0; i < n; i++) nv[i].Output();
            for (int j = 0; j < p; j++) ql[j].Output();
            for (int k = 0; k < o; k++) kh[k].Output();
            for (int i = 0; i < n; i++) m = m + nv[i].Sum();
            for (int j = 0; j < p; j++) q = q + ql[j].Sum();
            for (int k = 0; k < o; k++) b = b + kh[k].Sum();
            Console.WriteLine();
            Console.WriteLine("Total salary of Worker  {0}", m);
            Console.WriteLine("Total salary or Manager {0}", q);
            Console.WriteLine("Total salary of Scientist {0}", b);
            Console.ReadKey();

        }

    }

}