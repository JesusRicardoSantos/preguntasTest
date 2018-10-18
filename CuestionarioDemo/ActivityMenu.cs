using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CuestionarioDemo
{
    [Activity(Theme = "@style/AppTheme.NoActionBar")]
    public class ActivityMenu : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout_activityMenu);

            //var btnHigienePersonal = (Button)FindViewById(Resource.Id.btnHigieneUsuario);
            //var btnHigieneArea = (Button)FindViewById(Resource.Id.btnHigieneArea);
        }
    }
}