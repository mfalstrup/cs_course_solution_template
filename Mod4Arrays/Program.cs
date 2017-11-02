using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mdrlon = new int[6];
            mdrlon[0] = 13000;
            mdrlon[1] = 14000;
            mdrlon[2] = 18000;
            mdrlon[3] = 12000;
            mdrlon[4] = 15000;
            mdrlon[5] = 20000;
            decimal lonTotal = 0;

            Array.Sort(mdrlon);

            for (int i = 0; i < mdrlon.Length; i++)
            {
                lonTotal = lonTotal + mdrlon[i];
                Console.WriteLine("Månedsløn = " + mdrlon[i]);
                Console.WriteLine("Løn total = " + lonTotal);
            }

            decimal gns = lonTotal / mdrlon.Length;
            Console.WriteLine("Gennemsnit = " + gns);

            Console.ReadKey();
        }
    }
}
