using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPalidrome = IsPalindrome(number);
            if (isPalidrome)
                Console.WriteLine("this number is ayineyi");
            else
                Console.WriteLine("this nimber is not ayineyi");
            Console.ReadLine();


        }
        static bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number = number / 10;
            }
            return originalNumber == reversedNumber;

        }
    }
}
