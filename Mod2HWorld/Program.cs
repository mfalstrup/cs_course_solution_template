namespace Mod2HWorld
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast navn!");
            String navn = Console.ReadLine();
            Console.WriteLine("Velkommen " + navn.ToUpper());
            Console.ReadKey();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }

    }
}
