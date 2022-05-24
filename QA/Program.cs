using System;

namespace QA
{
    public class Program
    {
        public int Plus(int x, int y)
        {
            return x + y;
        }

        public int Minus(int x, int y)
        {
            return x - y;
        }

        public int Multiple(int x, int y)
        {
            return x * y;
        }

        public float Division(float x, float y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Act:");
            Console.WriteLine("1. Plus");
            Console.WriteLine("2. Minus:");
            Console.WriteLine("3. Multiple:");
            Console.WriteLine("4. Division:");
            Console.Write("Your choise: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");

            switch (i)
            {
                case 1:
                    Console.WriteLine("plus: " + program.Plus(x, y));
                    break;
                case 2:
                    Console.WriteLine("minus: " + program.Minus(x, y));
                    break;
                case 3:
                    Console.WriteLine("multiple: " + program.Multiple(x, y));
                    break;
                case 4:
                    Console.WriteLine("division: " + program.Division(x, y));
                    break;
            }
        }
    }
}
