using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod12Watch
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;
            w.Created += W_Created;

            do
            {

            } while (true);
        }

        private static void W_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Oprettet " + e.Name); ;
        }
    }
}
