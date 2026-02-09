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

namespace KomisSamochodowyMobilna4D.Model
{
    internal static class BazaPojazdow
    {
        public static List<Pojazd> listaPojazdow = new List<Pojazd> {
            new Samochod(5, "volvo", 2013),
            new Samochod(5, "bmw", 2017),
            new Samochod(5, "volkswagen", 2012),
            new Motocykl(true, "WSK", 1987),
            new Motocykl(false, "Honda", 2013),
            new Motocykl(false, "Mrf", 2020)
        };
    }
}