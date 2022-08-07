using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, rem, result = 0;
            Console.WriteLine("Enter the Number ");
            number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                rem = number % 10;
                result = result * 10 + rem;
                number = number / 10;
            }
            Console.WriteLine("The reverse number is " + result);
        }
    }
}