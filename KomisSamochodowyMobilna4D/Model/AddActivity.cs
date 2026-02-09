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
    [Activity(Label = "@string/app_dodaj_pojazd")]
    public class AddActivity : Activity
    {
        private int state = 0;

        RadioButton samochodRadio;
        RadioButton motocyklRadio;
        Button przyciskZapisz;

        LinearLayout layoutSamochod;
        LinearLayout layoutMotocykl;

        //samochód
        EditText markaEditText;
        EditText rocznikEditText;
        EditText liczbaDrzwiText;

        //motocykl
        EditText markaMotorEditText;
        EditText rocznikMotorEditText;
        CheckBox czyZabytkowyCheck;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_add);

            samochodRadio = FindViewById<RadioButton>(Resource.Id.radioButton1);
            motocyklRadio = FindViewById<RadioButton>(Resource.Id.radioButton2);
            przyciskZapisz = FindViewById<Button>(Resource.Id.button1);

            layoutSamochod = FindViewById<LinearLayout>(Resource.Id.linearLayout2);
            layoutMotocykl = FindViewById<LinearLayout>(Resource.Id.linearLayout3);

            markaEditText = FindViewById<EditText>(Resource.Id.editText1);
            rocznikEditText = FindViewById<EditText>(Resource.Id.editText2);
            liczbaDrzwiText = FindViewById<EditText>(Resource.Id.editText3);

            markaMotorEditText = FindViewById<EditText>(Resource.Id.editText4);
            rocznikMotorEditText = FindViewById<EditText>(Resource.Id.editText5);
            czyZabytkowyCheck = FindViewById<CheckBox>(Resource.Id.checkBox1);

            samochodRadio.Click += RadioWybieranie_Click;
            motocyklRadio.Click += RadioWybieranie_Click;

            przyciskZapisz.Click += PrzyciskZapisz_Click;
        }

        private void PrzyciskZapisz_Click(object sender, EventArgs e)
        {
            if (state == 0)
            {
                BazaPojazdow.listaPojazdow.Add(new Samochod(int.Parse(liczbaDrzwiText.Text), markaEditText.Text, ushort.Parse(rocznikEditText.Text)));
            } else
            {
                BazaPojazdow.listaPojazdow.Add(new Motocykl(czyZabytkowyCheck.Checked, markaMotorEditText.Text, ushort.Parse(rocznikMotorEditText.Text)));
            }
            Finish();
        }

        private void RadioWybieranie_Click(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;

            if (radio.Id == 2131230886)
            {
                layoutMotocykl.Visibility = ViewStates.Gone;
                layoutSamochod.Visibility = ViewStates.Visible;
                state = 0;
            }
            else
            {
                layoutMotocykl.Visibility = ViewStates.Visible;
                layoutSamochod.Visibility = ViewStates.Gone;
                state = 1;
            }
        }

    }
}