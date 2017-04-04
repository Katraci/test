using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_Hous
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var houseWall = Math.Round(((2 * x * x - 1.2 * 2) + (2 * x * y - 2 * 1.5 * 1.5)),2);
            var houseTop = Math.Round((2 * x * y + 2* x * h/2), 2);
            var redPaint = Math.Round(houseTop / 4.3, 2);
            var greenPaint = Math.Round(houseWall / 3.4, 2);
            Console.WriteLine("{0:0.00}", greenPaint);
            Console.WriteLine("{0:0.00}", redPaint);
        }
    }
}
