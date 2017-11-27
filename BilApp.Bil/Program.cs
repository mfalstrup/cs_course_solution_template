using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilApp.Bil
{
    partial class Program
    {
        static void Main(string[] args)
        {

            Bil b = new Bil();
            b.AntalCylindre = 4;
            b.BilId = 1;
            b.Model = "x";

            LastBil l = new LastBil { AntalCylindre = 4, Model = "Y", BilId = 2, LasteEvne = 255 };

            b.Print();
            l.Print();

            PersonBil p = new PersonBil() { Model = 2 };

            p.Print();

            Bil[] biler = new Bil[3];

            biler[0] = b;
            biler[1] = l;
            biler[2] = p;
            foreach (var bil in biler)
            {
                bil.Print();
            }

        }
    }
}
