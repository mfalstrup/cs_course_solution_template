/// <summary>
/// ædlgdælfgk
/// </summary>
namespace Mod3Variabler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// sdfsdf
    /// </summary>
    class Program
    {
        /// <summary>
        /// dsffsf
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            int htal = 10;
            Console.WriteLine(htal);
            htal++;
            Console.WriteLine(htal);
            htal--;
            Console.WriteLine(htal);
            htal += 20;
            Console.WriteLine(htal);

            double kommatal = 12.5;
            Console.WriteLine(kommatal);
            kommatal++;
            Console.WriteLine(kommatal);
            kommatal--;
            Console.WriteLine(kommatal);
            kommatal *= 2;
            Console.WriteLine(kommatal);

            DateTime dato = DateTime.Now;
            Console.WriteLine(dato.ToString("ddMMyy"));
            Console.WriteLine(dato.ToString("ddMMyyyy"));
            Console.WriteLine(dato.ToString("dMy"));
            Console.WriteLine(dato.ToLongDateString());

            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft);

            Person p = new Person();
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn + " " + p.Id);

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
