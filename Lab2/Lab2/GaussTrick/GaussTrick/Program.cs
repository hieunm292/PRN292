using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
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
                int halfArray = (int)Math.Ceiling((float)myList.Count / 2);
                int count = myList.Count;
                if (halfArray % 2 == 1)
                {
                    for (int i = 0; i < halfArray - 1; i++)
                    {
                        myList[i] = myList[i] + myList[count - (i + 1)];
                        myList.RemoveAt(count - (i + 1));
                        Console.WriteLine("number :" + myList[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < halfArray; i++)
                    {
                        myList[i] = myList[i] + myList[count - (i + 1)];
                        myList.RemoveAt(count - (i + 1));
                        Console.WriteLine("number :" + myList[i]);
                    }
                }


                foreach (int item in myList)
                {
                    Console.Write(" " + item);
                }
            }
        }
    }