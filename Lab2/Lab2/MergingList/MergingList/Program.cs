using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> result = new List<double>();
            Console.WriteLine("Nhap day 1: ");
            List<double> list1 = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            Console.WriteLine("Nhap day 2: ");
            List<double> list2 = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            if (list2.Count > list1.Count)
            {
                for (int i = 0; i <= list1.Count - 1; i++)
                {
                    result.Add(list2[i]);
                    result.Add(list1[i]);

                }
                for (int i = list1.Count; i < list2.Count; i++)
                {

                    result.Add(list2[i]);
                }
            }
            else
            {
                for (int i = 0; i <= list2.Count - 1; i++)
                {
                    result.Add(list1[i]);
                    result.Add(list2[i]);

                }
                for (int i = list2.Count; i < list1.Count; i++)
                {

                    result.Add(list1[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
