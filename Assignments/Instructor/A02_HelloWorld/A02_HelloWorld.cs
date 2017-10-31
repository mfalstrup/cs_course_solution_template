using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Instructor
{
    public class A02_HelloWorld
    {
        public static void Run() {

            Console.WriteLine("Indtast navn");
            string navn = Console.ReadLine();
            string stortNavn = navn.ToUpper();
            Console.WriteLine("Velkommen " + stortNavn);
            Console.WriteLine("Tryk en tast for at fortsætte");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
