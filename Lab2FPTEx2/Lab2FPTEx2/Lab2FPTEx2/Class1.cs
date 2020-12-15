using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2FPTEx2
{
    public class Book
    {
        private string id, name, publisher;
        private float price;

        public Book()
        {
        }

        public Book(string id, string name, string publisher, float price)
        {
            this.Id = id;
            this.Name = name;
            this.Publisher = publisher;
            this.Price = price;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public float Price { get => price; set => price = value; }

        private List<Book> list = new List<Book>();

        int findID(string bookID)
        {
            foreach (Book book in list)
            {
                if (book.id.Equals(bookID)) return list.IndexOf(book);
            }
            return -1;
        }

        bool checkExistedID(string bookID)
        {
            int pos = findID(bookID);
            if (pos == -1) return true;
            return false;
        }

        public void addBook()
        {
            Console.Write("\nEnter Book's ID: "); string bookID = Console.ReadLine();
            bool check = checkExistedID(bookID);
            while (check == false)
            {
                Console.WriteLine("Book ID is already available!");
                Console.Write("Please enter another book ID: "); bookID = Console.ReadLine();
                check = checkExistedID(bookID);
            }
            Console.Write("Enter Book's Name: "); string bookName = Console.ReadLine();
            Console.Write("Enter Book's Publisher: "); string bookPublisher = Console.ReadLine();
            Console.Write("Enter Book's Price (USD): "); float bookPrice = float.Parse(Console.ReadLine());
            Book b = new Book(bookID, bookName, bookPublisher, bookPrice);
            list.Add(b);
            Console.WriteLine("New Book Added Successfully!");
        }

        public void updateBook()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("The list is empty, add a new book first!");
            }
            else
            {
                Console.Write("\nEnter Book's ID to update: "); string bookID = Console.ReadLine();
                int pos = findID(bookID);
                if (pos == -1) Console.WriteLine("The ID is not existed!");
                else
                {
                    Console.Write("Enter Updated Name: "); string bookName = Console.ReadLine();
                    Console.Write("Enter Updated Publisher: "); string bookPublisher = Console.ReadLine();
                    Console.Write("Enter Updated Price: "); float bookPrice = float.Parse(Console.ReadLine());
                    list.RemoveAt(pos);
                    list.Insert(pos, new Book(bookID, bookName, bookPublisher, bookPrice));
                    Console.WriteLine("Book Updated Successfully!");
                }
            }
        }

        public void deleteBook()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("The list is empty, add a new book first!");
            }
            else
            {
                Console.Write("\nEnter Book's ID to delete: "); string bookID = Console.ReadLine();
                int pos = findID(bookID);
                if (pos == -1) Console.WriteLine("The ID is not existed!");
                else
                {
                    list.RemoveAt(pos);
                    Console.WriteLine("Book Deleted!");
                }
            }
        }

        public void listAllBooks()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("The list is empty, add a new book first!");
            }
            else
            {
                foreach (Book book in list)
                {
                    Console.WriteLine("\nID: " + book.id);
                    Console.WriteLine("Name: " + book.name);
                    Console.WriteLine("Publisher: " + book.publisher);
                    Console.WriteLine("Price: " + book.price);
                }
            }
        }
    }
}
