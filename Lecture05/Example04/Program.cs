using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[4];
            for (int cycleTime = 0; cycleTime <= 15; cycleTime++)
            {
                for (int index1 = 0; index1 < numbers.Length; index1++)
                {
                    numbers[index1] = random.Next(10);
                    for (int index2 = 0; index2 < index1; index2++)
                    {
                        if (index2 == 0)
                        {
                            while (numbers[index1] == numbers[index2])
                            {
                                numbers[index1] = random.Next(10);
                            }
                        }
                        else if (index2 == 1)
                        {
                            while (numbers[index1] == numbers[index2] || numbers[index1] == numbers[index2 - 1])
                            {
                                numbers[index1] = random.Next(10);
                            }
                        }
                        else if (index2 == 2)
                        {
                            while (numbers[index1] == numbers[index2] || numbers[index1] == numbers[index2 - 1] || numbers[index1] == numbers[index2 - 2])
                            {
                                numbers[index1] = random.Next(10);
                            }
                        }
                        else
                        {
                            while (numbers[index1] == numbers[index2] || numbers[index1] == numbers[index2 - 1] || numbers[index1] == numbers[index2 - 2] || numbers[index1] == numbers[index2 - 3])
                            {
                                numbers[index1] = random.Next(10);
                            }
                        }
                    }
                    Console.Write(" {0} ", numbers[index1]);
                }
                Console.WriteLine();
            }

            /*
            int total = 0;
            int max = 1000;
            int number = 0;
            while (total <= max)
            {
                total += ++number;
            }
            Console.WriteLine("number = {0}, total = {1} 超過 {2}"
                , number, total, max);
            */
        }
    }
}