using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Lab2TVEx2
{
    interface IBook
    {
        string this[int index] { get; set; }

        string Title { get; set; }

        string Author { get; set; }

        int Year { get; set; }

        string ISBN { get; set; }

        string Publisher { get; set; }

        void Show();

    }

    class Book : IBook
    {
        private string isbn, title, author, publisher;
        private int year;

        private ArrayList chapter = new ArrayList();

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (string)chapter[index];
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter[index] = value;
                else if (index == chapter.Count)
                    chapter.Add(value);
                else throw new IndexOutOfRangeException();
            }
        }

        public string ISBN { get => isbn; set => isbn = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public int Year { get => year; set => year = value; }

        public void Show()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Publisher: " + Publisher);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Chapter: ");
            for (int i = 0; i < chapter.Count; i++)
                Console.WriteLine($"\t{i + 1}: {chapter[i]}");
            Console.WriteLine("---------------------------");
        }
        public void Input()
        {
            Console.Write("Title: ");
            Title = Console.ReadLine();
            Console.Write("Author: ");
            Author = Console.ReadLine();
            Console.Write("Publisher: ");
            Publisher = Console.ReadLine();
            Console.Write("ISBN: ");
            ISBN = Console.ReadLine();
            Console.Write("Year: ");
            Year = int.Parse(Console.ReadLine());
            Console.WriteLine("Input chapter(finish with empty string):");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                    chapter.Add(str);
            } while (str.Length > 0);
        }
    }

    class BookList
    {
        private List<Book> list = new List<Book>();

        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
        }

        public void ShowList()
        {
            foreach (Book b in list)
                b.Show();
        }

        internal void Sort(IComparer<Book> titleComparer)
        {
            list.Sort(titleComparer);
        }

        public void InputList()
        {
            int n;
            Console.Write("Amount of books: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                AddBook();
                n--;
            }
        }

    }

    class TitleComparer : IComparer<Book>
    {
        int IComparer<Book>.Compare(Book x, Book y)
        {
            return x.Title.CompareTo(y.Title);
        }
    }

    class PublisherComparer : IComparer<Book>
    {
        int IComparer<Book>.Compare(Book x, Book y)
        {
            return x.Publisher.CompareTo(y.Publisher);
        }
    }

    class AuthorComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Author.CompareTo(y.Author);
        }
    }

    class YearComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }


    class Program
    {
            static void Main(string[] args)
            {
                BookList bl = new BookList();
                bl.InputList();
                IComparer<Book> titleComparer = new TitleComparer();
                bl.Sort(titleComparer);
                Console.WriteLine("After sorting:");
                bl.ShowList();
                Console.ReadLine();
            }
     }
    
}