using System;

namespace HelloWorldCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public int Subtract(int a, int b) 
            {
            int num1 = a;
            int num2 = b;
            int result = num1 - num2;

            return result;

            }
    }
}
