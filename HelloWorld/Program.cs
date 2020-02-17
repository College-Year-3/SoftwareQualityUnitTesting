using System;

namespace HelloWorld
{
   public class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            int result = Subtract(10, 5);
            Console.WriteLine(result);
        }

        public static int Subtract(int a, int b)
        {
            int num1 = a;
            int num2 = b;
            int result = num1 - num2;

            return result;

        }
    }
}
