using System;
namespace HelloWorld

{
    class Program
    {
        static void Main(string[] args) 
        {
            
            Console.WriteLine(Add(35, 25));
            Console.WriteLine(Multiply(45, 54));
            Console.WriteLine(Substract(145, 49));
            Console.WriteLine(Divide(49, 13));
            Console.Read();
        }

        public static int Add(int x, int y) 
        {
        return x + y;
        
        }

        public static int Multiply(int x, int y)
        {
            return x * y;

        }

        public static int Substract(int x, int y)
        {
            return x - y;

        }

        public static double Divide(double x, double y)
        {
            return x / y;

        }

    }
}