using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4ClassStruct
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            Person P2 = new Person();
            P1.navn = "a";
            P2.navn = "b";
            Console.WriteLine(P1.navn);
            Console.WriteLine(P2.navn);
            P1 = P2;
            Console.WriteLine("P1 = P2 " + P1.navn);
            Console.WriteLine("P1 = P2 " + P2.navn);
            P1.navn = "c";
            Console.WriteLine("P1 = c " + P1.navn);
            Console.WriteLine("P1 = c " + P2.navn);





            Console.ReadKey();
        }
    }
}
