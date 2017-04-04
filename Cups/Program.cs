using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            var cups = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());
            var days = double.Parse(Console.ReadLine());
            var cupsMade = Math.Floor(8 * days * workers / 5);
            if (cups<=cupsMade)
            {
                var extra = (cupsMade - cups) * 4.20;
                Console.WriteLine("{0:0.00} extra money", extra);
            }
            else
            {
                var loss = (cups - cupsMade) * 4.20;
                Console.WriteLine("Losses: {0:0.00}", loss);
            }
        }
    }
}
