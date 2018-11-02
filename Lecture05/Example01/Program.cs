using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example01.http;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StatusCode status = (StatusCode)104;

            switch (status)
            {
                case StatusCode.A:
                    Console.WriteLine("你輸入的是A");
                    break;

                case StatusCode.B:
                    Console.WriteLine("你輸入的是B");
                    break;

                case StatusCode.C:
                    Console.WriteLine("你輸入的是C");
                    break;

                default:
                    Console.WriteLine("沒有這種東西");
                    break;
            }
        }
    }
}