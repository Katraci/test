using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watch
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n%2!=0&&n>=3&&n<=51)
            {
                for (int i =1; i <= 2 * n + 1; i++)
                {
                    if (i==1||i== 2 * n + 1)
                    {
                        for (int j = 1; j <=2 * n + 1; j++)
                        {
                            Console.Write("*");
                            if (j== 2 * n + 1)
                            {
                                Console.WriteLine();
                            }
                        }
                    }
                    if (i==2)
                    {
                        for (int j =1; j <= 2 * n + 1; j++)
                        {
                            if (j==1||j== 2 * n + 1)
                            {
                                Console.Write(".");
                                if (j== 2 * n + 1)
                                {
                                    Console.WriteLine();
                                }
                            }
                            if (j==2||j==2*n)
                            {
                                Console.Write("*");
                            }
                            if (j>=3&&j<=2*n-1)
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                    if (i>=3&&i<=n)
                    {
                        for (int j = 1; j <=2*n+1; j++)
                        {
                            if (j<=i-1||j>=2*n-i+3)
                            {
                                Console.Write(".");
                            }
                            if (j==i||j==2*n+2-i)
                            {
                                Console.Write("*");
                            }
                            if (j>=i+1&&j<=2*n-i+1)
                            {
                                Console.Write("@");
                            }
                            if (j==2*n+1)
                            {
                                Console.WriteLine();
                            }
                        }
                    }
                    if (i==n+1)
                    {
                        for (int j = 1; j <=2*n+1; j++)
                        {
                            if (j!=n+1)
                            {
                                Console.Write(".");
                            }
                            if (j==n+1)
                            {
                                Console.Write("*");
                            }
                            if (j == 2 * n + 1)
                            {
                                Console.WriteLine();
                            }
                        }
                    }
                    if (i>=n+2&&i<=2*n-1)
                    {
                        for (int j =1; j <=2*n+1; j++)
                        {
                            if (j == n + 1)
                            {
                                Console.Write("@");
                            }
                            if ((j>=1&&j<=2*n-i+1)||(j>=i+1&&j<=2*n+1))
                            {
                                Console.Write(".");
                            }
                            if (j== 2 * n - i+2||j==i)
                            {
                                Console.Write("*");
                            }
                            if ((j >= 2 * n - i + 3&&j<=n) ||(j>=n+2&& j <= i-1))
                            {
                                Console.Write(" ");
                            }
                            if(j == 2 * n + 1)
                            {
                                Console.WriteLine();
                            }
                        }
                    }
                    if (i==2*n)
                    {
                        for (int j =1; j <=2*n+1; j++)
                        {
                            if (j == 1 || j == 2 * n + 1)
                            {
                                Console.Write(".");
                                if (j == 2 * n + 1)
                                {
                                    Console.WriteLine();
                                }
                            }
                            if (j == 2 || j == 2 * n)
                            {
                                Console.Write("*");
                            }
                            if (j >= 3 && j <= 2 * n - 1)
                            {
                                Console.Write("@");
                            }
                        }
                    }
                }
            }
        }
    }
}
