using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod410Tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            int taller = 10;

            for (int i = 1; i <= taller; i++)
            {
                for (int j = 1; j <= taller; j++)
                {
                    int res = i * j;
                    if (res % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write(res.ToString().PadLeft(5));
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(res.ToString().PadLeft(5));
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
