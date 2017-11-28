using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10Using
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader stream = System.IO.File.OpenText("x:\\dyrenavne.txt"))
            {
                while (stream.Peek() != -1)
                {
                    string navn = stream.ReadLine();
                    Console.WriteLine(navn.ToUpper());
                    Console.ReadKey();
                }
            }
        }
    }
}
