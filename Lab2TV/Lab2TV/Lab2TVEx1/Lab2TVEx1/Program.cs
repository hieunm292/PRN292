using System;
using System.Collections;

namespace Lab2TVEx1
{

    interface IBook
    {
        string this[int index] {get;set;}

        string Title { get; set; }

        string Author { get; set; }

        int Year { get; set; }

        string ISBN { get; set; }

        string Publisher { get; set; }

        void Show();

    }

    class Book : IBook
    {
        private string title;
        private string author;
        private string year;
        private string isbn;
        private string publisher;

        private ArrayList chapter = new ArrayList();


        public string this[int index] 
        { get { if (index >= 0 && index < chapter.Count)
                    return (string)chapter[index];
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter.Add(value);
                else throw new IndexOutOfRangeException();
            }
        }

        public string Title 
        { get => throw new NotImplementedException(); 
          set => throw new NotImplementedException(); }

        public string Author 
        { get => throw new NotImplementedException();
          set => throw new NotImplementedException(); }

        public int Year 
        { get => throw new NotImplementedException(); 
          set => throw new NotImplementedException(); }

        public string ISBN { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }
        public string Publisher { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }

        public void Show()
        {
            Console.WriteLine(" ============================ " );
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Author : " + author);
            Console.WriteLine("Year : " + year);
            Console.WriteLine("Publisher : " + publisher);
            Console.WriteLine("ISBN : " + isbn);
            for(int i = 0; i < chapter.Count; i++)
            {
                Console.WriteLine("\t{0} : {1}", i + 1, chapter[1]);
            }
        }

        public void Input()
        {
            Console.WriteLine("Title : ");
            title = Console.ReadLine();
            Console.WriteLine("Author : ");
            author = Console.ReadLine();
            Console.WriteLine("Year : ");
            year = Console.ReadLine();
            Console.WriteLine("Publisher : ");
            publisher = Console.ReadLine();
            Console.WriteLine("ISBN : ");
            isbn = Console.ReadLine();
            Console.WriteLine("Input chaper (finished with empty string)");
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
        private ArrayList list = new ArrayList();

        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
        }

        public void ShowList()
        {
            foreach(Book b in list)
            {
                b.Show();
            }
        }

        public void InputList()
        {
            int n;
            Console.Write("Amount of books : ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                AddBook();
                n--;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            BookList bl = new BookList();
            bl.InputList();
            bl.ShowList();
            Console.ReadLine();
        }
    }
}
