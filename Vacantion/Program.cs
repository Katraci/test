using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            if (season == "winter")
            {
                if (money<=1000)
                {
                    decimal pay = money * 45 / 100;
                    Console.WriteLine("Morocco - Camp - {0:0.00}", Math.Round(pay,2));
                }
                else
                {
                    if (money > 1000 && money <= 3000)
                    {
                        decimal pay = money * 60 / 100;
                        Console.WriteLine("Morocco - Hut - {0:0.00}", Math.Round(pay, 2));
                    }
                    else
                    {
                        if (money > 3000)
                        {
                            decimal pay = money * 90 / 100;
                            Console.WriteLine("Morocco - Hotel - {0:0.00}", Math.Round(pay, 2));
                        }
                    }
                }
            }
            else
            {
                if (money <= 1000)
                {
                    decimal pay = money * 65 / 100;
                    Console.WriteLine("Alaska - Camp - {0:0.00}", Math.Round(pay, 2));
                }
                else
                {
                    if (money > 1000 && money <= 3000)
                    {
                        decimal pay = money * 80 / 100;
                        Console.WriteLine("Alaska - Hut - {0:0.00}", Math.Round(pay, 2));
                    }
                    else
                    {
                        if (money > 3000)
                        {
                            decimal pay = money * 90 / 100;
                            Console.WriteLine("Alaska - Hotel - {0:0.00}", Math.Round(pay, 2));
                        }
                    }
                }
            }
        }
    }
}
