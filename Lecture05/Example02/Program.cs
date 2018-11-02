using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int max = 1; max <= 10; max++)
            {
                PrintSeries(max);
            }
        }

        private static void PrintSeries(int max)
        {
            int total = 0;

            for (int number = 1; number <= max; number++)
            {
                total += number;

                if (number >= 1 && number <= 5)
                {
                    if (max >= 1 && max <= 5)
                    {
                        if (number <= 1)
                        {
                            Console.Write("{0}", number);
                        }
                        else
                        {
                            Console.Write(" + {0}", number);
                        }
                        if (number == max)
                        {
                            Console.Write(" = {0}", total);
                        }
                    }
                    else
                    {
                        if (number == 5 && max == 6)
                        {
                            Console.Write("... + ");
                        }
                        else
                        {
                            Console.Write("{0} + ", number);
                        }
                    }
                }
                else if (number >= 6 && number <= max - 2)
                {
                }
                else if (number == max - 1)
                {
                    Console.Write("... + ");
                }
                else
                {
                    Console.Write("{0} = {1}", number, total);
                }
            }
            Console.WriteLine();
        }
    }
}