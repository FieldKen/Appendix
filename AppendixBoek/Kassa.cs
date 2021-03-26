using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendixBoek
{
    class Kassa
    {
        private string merk;
        public string Merk
        {
            get => merk; //get { return merk; }
            set => merk = value; //set { merk = value; }
        }


        public int Totaal { get; set; }
        public int Bouwjaar { get; set; }

        public static Kassa operator +(Kassa a, Kassa b)
        {
            Kassa result = new Kassa();

            result.Totaal = a.Totaal + b.Totaal;
            result.Bouwjaar = Math.Min(a.Bouwjaar, b.Bouwjaar);

            return result;
        }

        public static Kassa operator -(Kassa a, Kassa b)
        {
            Kassa result = new Kassa();

            result.Totaal = a.Totaal - b.Totaal;
            result.Bouwjaar = Math.Min(a.Bouwjaar, b.Bouwjaar);

            return result;
        }

        public static Kassa operator *(Kassa a, Kassa b)
        {
            Kassa result = new Kassa();

            result.Totaal = a.Totaal * b.Totaal;
            result.Bouwjaar = Math.Min(a.Bouwjaar, b.Bouwjaar);

            return result;
        }
    }
}
