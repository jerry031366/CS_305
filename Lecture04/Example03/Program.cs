using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int cols = 3;

            for (int number = 0; number < 10; number++)
            {
                //row = 編號 / 一排幾個 得到的商
                int row = number / cols;
                int col = number % cols;
                Console.WriteLine("number ={0},(row,col)=({1},{2})", number + 1, row + 1, col + 1);
            }
        }
    }
}