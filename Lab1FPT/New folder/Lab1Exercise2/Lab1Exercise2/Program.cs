using System;

namespace Lab1Exercise2
{
    abstract class Animal
    {
        private String type;
        public Animal() { }
        public Animal(String type)
        {
            this.type = type;
            Console.WriteLine("This is: {0}", type);
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public abstract void Sound();
        public abstract void Information();
    }
    class Dogs : Animal
    {
        private String breed;
        public Dogs() { }
        public Dogs(String bre)
        {
            this.breed = bre;
        }
        public Dogs(String type, String br)
            : base(type)
        {
            this.breed = br;
        }
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public override void Information()
        {
            Console.WriteLine("This dog is: {0}", Breed);
        }
        public override void Sound()
        {
            Console.WriteLine("It sound: Gau Gau!");
        }
    }
    class Cats : Animal
    {
        String climb;
        public Cats(String type, String clim)
            : base(type)
        {
            this.climb = clim;
        }
        public Cats(String cl)
        {
            this.climb = cl;
        }
        public string Climbe
        {
            get { return climb; }
            set { climb = value; }
        }
        public override void Information()
        {
            Console.WriteLine("This cat is : {0}", climb);
        }
        public override void Sound()
        {
            Console.WriteLine("It sound: Meo Meo!");
        }
    }
    class Ducks : Animal
    {
        String swim;
        public Ducks(String swim)
        {
            this.swim = swim;
        }
        public Ducks(String type, String swim)
            : base(type)
        {
            this.swim = swim;
        }
        public string swimm
        {
            get { return swim; }
            set { swim = value; }
        }
        public override void Information()
        {
            Console.WriteLine("This duck swim on: {0}", swim);
        }
        public override void Sound()
        {
            Console.WriteLine("It sound: Quat Quat!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dogs A = new Dogs("mammal", "poodle");
            A.Information();
            A.Sound();
            Console.WriteLine("===================");
            Cats B = new Cats("mammal", "tree");
            B.Information();
            B.Sound();
            Console.WriteLine("===================");
            Ducks C = new Ducks("bird", "pond");
            C.Information();
            C.Sound();
            Console.WriteLine("===================");
            Console.WriteLine("Enter breed of dog");
            String br = Console.ReadLine();
            Dogs D = new Dogs("mammal", br);
            D.Information();
            D.Sound();
        }
    }
}
