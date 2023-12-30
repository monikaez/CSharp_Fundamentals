using System;

namespace T05AddandSubstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You will receive 3 integers. Create a method that returns the sum of the first two integers
            //and another method that subtracts the third integer from the result of the sum method.

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int result = Add(num1, num2);
            Substract(result, num3);
        }
        private static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        private static void Substract(int result, int num3)
        {
            Console.WriteLine(result-num3);
        }
        
    }
}

