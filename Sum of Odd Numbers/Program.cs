using System;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            int count = 1;
            int sum = count;
            for (int i = 1; i < times; i++)
            {
                Console.WriteLine(count);
                count += 2;
                sum += count;
            }

            Console.WriteLine(count);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
