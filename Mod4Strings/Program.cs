using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";

            string samletNavn = fornavn + " " + efternavn;
            string navnStort = samletNavn.ToUpper();
            string navnLille = samletNavn.ToLower();
            string del = samletNavn.Substring(7,4);
            var ar = samletNavn.Split(' ');

            Console.WriteLine(fornavn);
            Console.WriteLine(efternavn);
            Console.WriteLine(samletNavn);
            Console.WriteLine(navnStort);
            Console.WriteLine(navnLille);
            Console.WriteLine(del);

            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine("ar[" + i + "] = " + ar[i]);
            }

            string minText = "i wfiueuw owe weurewu weiur wur\twuierow uwiur woeiru uowuerou\r\nwruweuruw woreuwur uwreuweruw euowrue";
            Console.WriteLine(minText);

            System.IO.File.WriteAllText(@"c:\temp\test.txt",minText,System.Text.Encoding.Default);

            Console.ReadKey();
        }
    }
}
