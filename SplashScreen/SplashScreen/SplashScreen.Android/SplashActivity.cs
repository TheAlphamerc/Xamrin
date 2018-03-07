using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SplashScreen.Droid;

namespace LoginAuthentication.Droid
{
    //[Activity(Label = "SplashActivity")]
    //public class SplashActivity : Activity
    //{
    //    protected override void OnCreate(Bundle savedInstanceState)
    //    {
    //        base.OnCreate(savedInstanceState);

    //        // Create your application here
    //    }
    //}

    [Activity(Label = "myApp", Icon = "@drawable/icon", Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        protected override void OnResume()
        {
            base.OnResume();
            var startUp = new Task(() =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            });
            startUp.ContinueWith(t => Finish());

            startUp.Start();
        }
    }
}