using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            float a = 0.1f;
            float b = 0.2f;
            float c = 0.3f;
            Console.WriteLine("{0} + {1} == {2}? {3}", a, b, c, a + b == c);
            Console.WriteLine("{0} + {1} == {2}", a, b, a + b);
        }
    }
}