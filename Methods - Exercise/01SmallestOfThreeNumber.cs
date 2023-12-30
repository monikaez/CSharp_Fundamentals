using System;

namespace T01SmallestOfThreeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a method that prints out the smallest of three integer numbers.
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(num1,num2,num3));
        }
        static int SmallestNumber(int num1, int num2, int num3)
        {
            return Math.Min(num1, Math.Min(num2, num3));
        }
    }
}
