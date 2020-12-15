using Lab2Example1_2_;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab2Example1_2_
{
    class Person 
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            this.Name = name;
            Age = age;
        }

        public int CompareTo(Person other)
        {
            return this.Age.CompareTo(other.Age);
        }

        public void GetInfo()
        {
            Console.WriteLine("Name: {0}, Age: {1}", Name, Age);
        }
    }

    class SortPersonByName : IComparer<Person>
    {
        public int Compare([AllowNull] Person x, [AllowNull] Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    class SortPersonByAge : IComparer<Person>
    {
        public int Compare([AllowNull] Person x, [AllowNull] Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }

    class Program
    {
        static List<Person> PersonList = new List<Person>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; //Hiển thị unicode của tên các Idol =))
            PersonList.Add(new Person("Nguyen Minh Hieu", 20));
            PersonList.Add(new Person("Cristiano Ronaldo", 35));
            PersonList.Add(new Person("Lionel Messi", 31));

            PersonList.Sort(new SortPersonByName());
            foreach (Person person in PersonList)
            {
                person.GetInfo();
            }
        }
    }
}
