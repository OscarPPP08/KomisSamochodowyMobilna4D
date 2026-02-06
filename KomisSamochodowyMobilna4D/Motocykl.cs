using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KomisSamochodowyMobilna4D
{
    public class Motocykl : Pojazd
    {
        private bool czyZabytkowy;

        public Motocykl(bool czyZabytkowy, string marka, UInt16 rokProdukcji) : base(marka, rokProdukcji)
        {
            this.czyZabytkowy = czyZabytkowy;
        }

        public override double ObliczKosztWynajmu(int dni)
        {
            if (czyZabytkowy)
            {
                return (dni * 70 * 1.2);
            }
            return (dni * 70);
        }

        public override string Opis()
        {
            string czyZabytkowyString = czyZabytkowy ? "jest" : "nie jest";
            return base.Opis() + $", czy jest zabytkowy: {czyZabytkowyString}";
        }
    }
}