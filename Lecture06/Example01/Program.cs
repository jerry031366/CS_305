using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int number = 0; number < 10; number++)
            {
                numbers.Add(number);
            }
            //產生四個亂數
            Random random = new Random();

            //執行 四次 刪除的動作 取出數字 並且從清單刪除的動作
            //需要一個亂數產生器
            for (int count = 1; count <= 4; count++)
            {
                int index = random.Next(numbers.Count);
                int number = numbers[index];
                Console.Write(number);
                numbers.Remove(number);
            }
            Console.WriteLine();
        }
    }
}