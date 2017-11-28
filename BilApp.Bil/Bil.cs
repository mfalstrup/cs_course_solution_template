using System;

namespace BilApp.Bil
{
    public class Bil
    {
        public int BilId { get; set; }
        public string Model { get; set; }

        private int antalCylindre;

        public int AntalCylindre
        {
            get { return antalCylindre; }
            set
            {

                if (value < 4 || value > 8)
                    throw new ApplicationException("Forkert antal cylindre");


                antalCylindre = value;
            }
        }

        public virtual void Print()
        {
            Console.WriteLine("Bil: " + this.Model);
        }

        public Bil()
        {

        }

        public Bil(int BilId)
        {

        }

    }

}
