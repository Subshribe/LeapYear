using System;

namespace Skottår
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Skriv in ett årtal som har passerat!");
                int CurrentYear = DateTime.Now.Year;
                int StartYear = int.Parse(Console.ReadLine());
                if (StartYear > CurrentYear)
                {
                    Console.WriteLine("Angivet årtal är ej passerat!");
                }
                for (int year = StartYear; year <= CurrentYear; year++)
                {
                    if (year % 4 == 0 & year % 100 != 0)
                    {
                        Console.WriteLine(year);
                    }
                    else if (year % 100 == 0 & (year / 100) % 4 == 0)
                    {
                        Console.WriteLine(year);
                    }
                }

            }
        }
    }
}
