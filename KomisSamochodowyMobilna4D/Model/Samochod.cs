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
    internal class Samochod : Pojazd
    {
        private int liczbaDrzwi;

        public Samochod(int liczbaDrzwi, string marka, UInt16 rokProdukcji) : base(marka, rokProdukcji)
        {
            this.liczbaDrzwi = liczbaDrzwi;
        }
        public Samochod(Samochod auto) : base(auto.marka, auto.rokProdukcji)
        {
            this.liczbaDrzwi = auto.liczbaDrzwi;
        }

        public override double ObliczKosztWynajmu(int dni)
        {
            return (dni * 100.0);
        }

        public override string Opis()
        {
            return base.Opis() + $", liczbeDrzwi: {this.liczbaDrzwi}";
        }
    }
}