namespace Mod10Interface
{
    partial class Program
    {
        class Ubåd : IDbFunktioner
        {
            public int Nummer { get; set; }
            public double Turbine { get; set; }

            public void Gem()
            {
                System.Console.WriteLine("Du har gemt en Ubåd");
            }
        }
    }
}
