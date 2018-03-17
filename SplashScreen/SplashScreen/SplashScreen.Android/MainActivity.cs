using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter; using Microsoft.AppCenter.Analytics; using Microsoft.AppCenter.Crashes;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SplashScreen.Droid
{
    [Activity(Label = "SplashScreen", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher =false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
            AppCenter.Start("9f5932e2-bed7-44e8-9773-9fc4599cd585",
                   typeof(Analytics), typeof(Crashes));
AppCenter.Start("9f5932e2-bed7-44e8-9773-9fc4599cd585", typeof(Analytics), typeof(Crashes));
        }
    }
}

