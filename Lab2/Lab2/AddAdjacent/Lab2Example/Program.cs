using System;
using System.Collections.Generic;

namespace Lab2Example
{
    class Program
    {

        static void Main(string[] args)
        {
            int input;
            List<int> myList = new List<int>();
            Console.WriteLine("input number (0 to stop)");
            do
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input != 0)
                {
                    myList.Add(input);
                }
            } while (input != 0);
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("item:" + myList[i]);
                int index = myList.LastIndexOf(myList[i]);
                if (index != -1 && index != i)
                {
                    myList[i] = myList[i] + myList[index];
                    myList.RemoveAt(index);
                    i = -1;
                }
            }
            foreach (int item in myList)
            {
                Console.Write(" " + item);
            }
        }
    }
}