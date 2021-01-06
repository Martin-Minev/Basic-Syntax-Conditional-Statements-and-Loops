using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int minafter = minutes + 30;
            int hoursafter = 0;

            if (minafter >= 60)
            {
                minafter = minafter - 60;
                hoursafter = hours + 1;
                if (hoursafter > 23)
                {
                    hoursafter = hoursafter - 24;
                }

                Console.WriteLine("{0}:{1:D2}", hoursafter, minafter);
            }
            else
            {
                Console.WriteLine("{0}:{1:D2}", hours, minafter);
            }
        }
    }
}
