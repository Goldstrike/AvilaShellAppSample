﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Acr.UserDialogs;
using AvilaShellApp.Droid.Helpers;

namespace AvilaShellApp.Droid
{
    [Activity(Label = "AvilaShellApp",
        Icon = "@mipmap/ic_launcher",
        RoundIcon = "@mipmap/ic_launcher_round",
        Theme = "@style/MainTheme",
        MainLauncher = false,
        ScreenOrientation = ScreenOrientation.Portrait,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Forms.Forms.SetFlags(new string[] { "CarouselView_Experimental", "Brush_Experimental", "Expander_Experimental" });
            //Xamarin.Forms.Forms.SetFlags(new string[] { "CarouselView_Experimental", "Brush_Experimental" });
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            // FFImageLoading plugin initizialization
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(enableFastRenderer:true);

            // XF SvgImage initizialization
            Xamarin.Forms.Svg.Droid.SvgImage.Init(this);

            // Acr.UserDialogs initizialization
            UserDialogs.Init(this);

            // StatusBar helper initialiaztion
            StatusBar.Activity = this;



            // StatusBar => translucent
            //this.Window.AddFlags(WindowManagerFlags.TranslucentStatus);
            // StatusBar => set color programatically
            //this.Window.SetStatusBarColor(Android.Graphics.Color.Argb(255, 0, 0, 0));

            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}