using System.Collections.Generic;

namespace Mod11Collection2
{
    partial class Program
    {
        class Bunke
        {
            private Stack<Kort> bunke = new Stack<Kort>();

            public void TilføjKort(Kort k)
            {
                bunke.Push(k);
            }

            public Kort FjernKort()
            {
                if (bunke.Count > 0)
                {
                    return bunke.Pop();
                }

                return null;
            }

            public void Vis()
            {
                foreach (var item in bunke)
                {
                    System.Console.WriteLine(item);
                }
            }
        }
    }
}
