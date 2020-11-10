using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Factorial
    {
        public static void Show(int number)
        {
            Console.WriteLine(factorial(number));
        }
        private static int factorial(int number)
        {
            if (number == 0)
                return 1;
            return number * factorial(number - 1);
        }
    }
}
