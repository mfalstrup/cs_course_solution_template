using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod12Delegate2
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Beregner(1, 1, Plus);
            Console.WriteLine(res);
            res = Beregner(2, 3, Gange);
            Console.WriteLine(res);
            res = Beregner(5, 6, Minus);
            Console.WriteLine(res);
            res = Beregner(2, 3, Divider);
            Console.WriteLine(res);
            res = Beregner(2, 3, (int a,int b) => a * b);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Gange(int a, int b)
        {
            return a * b;
        }
        public static int Divider(int a, int b)
        {
            return a / b;
        }
        public static int Beregner(int x, int y, Func<int, int, int> Funktion)
        {
            return Funktion(x, y);
        }

    }
}
