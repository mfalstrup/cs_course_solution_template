using System;

namespace Mod10Compare
{
    class Hund : IComparable

    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            Hund dog = obj as Hund;

            if (this.Alder < dog.Alder) { return -1; }
            else if( this.Alder > dog.Alder ) { return 1; }
            return 0;
        }
    }


}
