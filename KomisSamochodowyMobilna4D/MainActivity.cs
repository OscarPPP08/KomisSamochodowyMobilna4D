using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using KomisSamochodowyMobilna4D.Model;
using System.Collections.Generic;

namespace KomisSamochodowyMobilna4D
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        
        public List<string> listaNazw = new List<string>();
        ListView pojazdyListView;
        ArrayAdapter adapter;
        ImageButton przyciskDodaj;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            pojazdyListView = FindViewById<ListView>(Resource.Id.listView1);
            przyciskDodaj = FindViewById<ImageButton>(Resource.Id.imageButton1);

            foreach(Pojazd pojazd in BazaPojazdow.listaPojazdow)
            {
                listaNazw.Add(pojazd.OpisShort());
            }

            pojazdyListView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, listaNazw);
            przyciskDodaj.Click += PrzyciskDodaj_Click;
        }

        private void PrzyciskDodaj_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(AddActivity));
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}