using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10Interface
{
    partial class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] dbFunktioner = new IDbFunktioner[4];
            dbFunktioner[0] = new Ubåd();
            dbFunktioner[1] = new Hund();
            dbFunktioner[2] = new Ubåd();
            dbFunktioner[3] = new Hund();

            foreach (var dbf in dbFunktioner)
            {
                dbf.Gem();
                System.Console.ReadKey();
            }
        }
    }
}
