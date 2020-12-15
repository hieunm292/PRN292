using System;

namespace Lab2FPTEx2
{
    class Program
    {
        public static int checkInputLimit(int min, int max)
        {
            while (true)
            {
                int result = int.Parse(Console.ReadLine().Trim());
                if (result >= min && result <= max) return result;
                else
                {
                    Console.WriteLine("Please input number from " + min + " to " + max + "!");
                    Console.Write("Enter again: ");
                }
            }
        }
        static void Main(string[] args)
        {
            Book b = new Book();
            int op = 0;
            while (op != 5)
            {
                Console.WriteLine("\n===== BOOK MANAGEMENT =====");
                Console.WriteLine("1. Add a new book");
                Console.WriteLine("2. Update a book");
                Console.WriteLine("3. Delete a book");
                Console.WriteLine("4. List all books");
                Console.WriteLine("5. Quit");
                Console.Write("Choose your option: "); op = checkInputLimit(1, 5);
                switch (op)
                {
                    case 1:
                        Console.WriteLine();
                        b.addBook();
                        break;
                    case 2:
                        Console.WriteLine();
                        b.updateBook();
                        break;
                    case 3:
                        Console.WriteLine();
                        b.deleteBook();
                        break;
                    case 4:
                        Console.WriteLine();
                        b.listAllBooks();
                        break;
                    case 5:
                        break;
                }
            }
        }
    }
}

}
