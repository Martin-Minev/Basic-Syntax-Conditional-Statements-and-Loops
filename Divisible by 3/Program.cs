using System;

namespace Divisible_by_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            for (int i = 0; i <= 99; i++)
            {

                if (number % 3 == 0)
                {
                    Console.WriteLine(number);
                }

                number += 1;
                if (number > 100)
                {
                    break;
                }
            }
        }
    }
}
