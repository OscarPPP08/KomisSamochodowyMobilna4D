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
    public abstract class Pojazd
    {
        protected string marka;
        protected UInt16 rokProdukcji;

        public Pojazd(string marka, ushort rokProdukcji)
        {
            this.marka = marka;
            this.rokProdukcji = rokProdukcji;
        }

        public abstract double ObliczKosztWynajmu(int dni);

        public virtual string Opis()
        {
            return $"marka: {this.marka}, rok produkcji: {this.rokProdukcji}";
        }

        public virtual string OpisShort()
        {
            return $"{this.marka}, {this.rokProdukcji}";
        }
    }
}