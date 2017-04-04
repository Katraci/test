using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lector_pay
{
    class Program
    {
        static void Main(string[] args)
        {
            var lections = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            var jelev = 0.0;
            var royal = 0.0;
            var roli = 0.0;
            var trofon = 0.0;
            var sino = 0.0;
            var others = 0.0;
            if (money >= 100 && money <= 10000 && lections >= 1 && lections <= 100)
            {
                for (int i = 1; i <= lections; i++)
                {
                    var name = Console.ReadLine().ToLower();

                    if (name == "jelev")
                    {
                        jelev = jelev + 1;
                    }
                    else
                    {
                        if (name == "royal")
                        {
                            royal = royal + 1;
                        }
                        else
                        {
                            if (name == "roli")
                            {
                                roli = roli + 1;
                            }
                            else
                            {
                                if (name == "trofon")
                                {
                                    trofon = trofon + 1;
                                }
                                else
                                {
                                    if (name == "sino")
                                    {
                                        sino = sino + 1;
                                    }
                                    else
                                    {
                                        others = others + 1;
                                    }
                                }
                            }
                        }
                    }
                }
                var moneyPerLector = money / lections;
                var jelevMoney = jelev * moneyPerLector;
                var royalMoney = royal * moneyPerLector;
                var roliMoney = roli * moneyPerLector;
                var trofonmoney = trofon * moneyPerLector;
                var sinoMoney = sino * moneyPerLector;
                var othersMoney = others * moneyPerLector;
                Console.WriteLine("Jelev salary: {0:0.00} lv", Math.Round(jelevMoney, 2));
                Console.WriteLine("RoYaL salary: {0:0.00} lv", Math.Round(royalMoney, 2));
                Console.WriteLine("Roli salary: {0:0.00} lv", Math.Round(roliMoney, 2));
                Console.WriteLine("Trofon salary: {0:0.00} lv", Math.Round(trofonmoney, 2));
                Console.WriteLine("Sino salary: {0:0.00} lv", Math.Round(sinoMoney, 2));
                Console.WriteLine("Others salary: {0:0.00} lv", Math.Round(othersMoney, 2));
            }
        }
    }
}
