using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod11Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lst = new List<Person>();
            lst.Add(new Person { Id = 1, Navn = "Jens Hansen" });
            lst.Add(new Person { Id = 1, Navn = "Knud Eriksen" });
            lst.Add(new Person { Id = 1, Navn = "Jonna Jense" });
            lst.Add(new Person { Id = 1, Navn = "Marcia Peixoto" });
            lst.Add(new Person { Id = 1, Navn = "Anne Seidelin" });

            foreach (var item in lst)
                {
                Console.WriteLine( item.Navn);
                Console.ReadKey();
            }



            Dictionary<int, Person> dict = new Dictionary<int, Person>();
            dict.Add(23, new Person { Id = 1, Navn = "Jens Hansen" });
            dict.Add(54, new Person { Id = 1, Navn = "Knud Eriksen" });
            dict.Add(67, new Person { Id = 1, Navn = "Jonna Jense" });
            dict.Add(43, new Person { Id = 1, Navn = "Marcia Peixoto" });
            dict.Add(45, new Person { Id = 1, Navn = "Anne Seidelin" });

            var p = dict[43];
            Console.WriteLine(p.Navn);
            Console.ReadKey();
        }
    }
}
