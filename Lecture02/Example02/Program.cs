using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exanple02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float a = 0.1f;
            float b = 0.2f;
            float c = 0.3f;
            Console.WriteLine("{0} + {1} == {2}? {3}", a, b, c, a + b < c);
            Console.WriteLine("{0} + {1} == {2}", a, b, a + b);

            string email = "jerry.yao031366@gmail.com";
            Console.WriteLine(email.IndexOf("@"));
            Console.WriteLine(email[11]);
        }
    }
}