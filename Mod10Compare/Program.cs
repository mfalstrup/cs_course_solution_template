using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() { Alder = 4, Navn = "Fido" };
            hunde[1] = new Hund() { Alder = 6, Navn = "Trold" };
            Array.Sort(hunde);
            foreach (var h in hunde)
            {
                Console.WriteLine(h.Navn + " er " + h.Alder + " år");
                Console.ReadKey();
            }
        }
    }
}
