using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod12Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k = new Kunde() { KreditMax = -5000 };
            k.KreditOverskredet += (s, e) => { Console.WriteLine("Kredit overskredet"); Console.ReadKey(); };

            k.Køb(500);
            k.Køb(2500);
            k.Køb(1000);
            k.Køb(1500);
        }

        public class Kunde
        {
            public event EventHandler KreditOverskredet;
            public string Navn { get; set; }
            public int Saldo { get; set; }
            public int KreditMax { get; set; }
            public void Køb(int værdi)
            {
                Console.WriteLine("Kunde {0} køber for {i}");
                this.Saldo -= værdi;
                if(Saldo < KreditMax)
                {
                    if (KreditOverskredet != null)
                        KreditOverskredet.Invoke(this, new EventArgs());
                }
            }

        }
    }
}
