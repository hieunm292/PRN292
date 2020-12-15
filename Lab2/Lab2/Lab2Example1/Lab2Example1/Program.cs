using System;
using System.Collections.Generic;

namespace Lab2Example1
{
    class Program
    {
        class Person : IComparable<Person>
        {
            public int ID { get; set; }
            public int DiemTB { get; set; }
            public string Name { get; set; }

            public int CompareTo(Person other)
            {
                return this.ID.CompareTo(other.ID);
            }
        }

        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            personList.Add(new Person { ID = 10,DiemTB=9, Name = "John" });
            personList.Add(new Person { ID = 15, DiemTB = 9, Name = "Ann" });
            personList.Add(new Person { ID = 8, DiemTB = 9, Name = "Kevin" });
            personList.Sort(); 
            foreach (var item in personList)
            {
                Console.WriteLine(item.Name + ":" + item.ID+ ":"+ item.DiemTB);
            }
            Console.ReadKey(true);
        }
    }
}
