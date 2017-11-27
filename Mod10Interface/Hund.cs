namespace Mod10Interface
{
    partial class Program
    {
        class Hund : IDbFunktioner
        {
            public string Navn { get; set; }

            public void Gem()
            {
                System.Console.WriteLine("Du har gemt en Hund");
            }
        }
    }
}
