using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int result = 0;

            if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    result = number * i;
                    Console.WriteLine($"{number} X {i} = {result}");
                }
            }
            else
            {
                result = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {result}");
            }

        }
    }
}
