using System;

namespace PolymorphismProblems
{
    internal class Program
    {
        public void Add()
        {
            int a = 29;
            int b = 34;
            int c = a + b;
            Console.WriteLine(c);
        }

        public void Add(int a,int b)
        {
            int c=a + b;
            Console.WriteLine(c);
        }
        
        public void Add(string a,string b)
        {
            string c=a + b;
            Console.WriteLine(c);
        }

        public void Add(float a, float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Program ob = new Program();
            ob.Add();
            ob.Add(25, 65);
            ob.Add("hello", "world");
            ob.Add(25.36f, 6.5f);
        }
    }
}
