using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var n3 = int.Parse(Console.ReadLine());
            var x = 0;
            var y = 0;
            bool b = false;
            var sum = 0;
            var num = 0;
            for (int i = n1; i >= n2; i--)
            {
                for (int j = n2; j <= n1; j++)
                {
                    sum = i + j;
                    num += 1;
                    if (sum == n3)
                    {
                        x = i;
                        y = j;
                        b = true;
                        break;


                    }
                    else
                    {
                        if (i == n2 && j == n1)
                        {
                            Console.WriteLine("{0} combinations - neither equals {1}", num, n3);
                        }
                    }
                }
            }
            if (b == true)
                Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", num, y, x, sum);
        }
    }
}
