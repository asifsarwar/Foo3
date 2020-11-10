using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TimeTable
    {
        public static void Show(int number)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}
