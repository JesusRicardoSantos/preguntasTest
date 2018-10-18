using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using com.refractored;
using Java.Lang;

namespace CuestionarioDemo
{
    [Activity(Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MenuActivity : AppCompatActivity
    {
        PagerSlidingTabStrip TabsPrincipales;
        ViewPager ViewPagerPrincipal;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Menu);
            Window.SetStatusBarColor(Color.Rgb(0, 12, 155));
            TabsPrincipales = FindViewById<PagerSlidingTabStrip>(Resource.Id.TabsPrincipales);
            ViewPagerPrincipal = FindViewById<ViewPager>(Resource.Id.ViewPagerPrincipal);
            ViewPagerPrincipal.Adapter = new AdaptadorTabsPrincipales(SupportFragmentManager, this);
            TabsPrincipales.SetViewPager(ViewPagerPrincipal);
            TabsPrincipales.GetChildAt(0).SetMinimumWidth(10);
        }
    }

    public class AdaptadorTabsPrincipales : FragmentPagerAdapter
    {
        Activity Actividad = null;

        public AdaptadorTabsPrincipales(Android.Support.V4.App.FragmentManager fm, Activity a) : base(fm) { Actividad = a; }

        public override int Count
        {
            get
            {
                return 2;
            }
        }

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            Android.Support.V4.App.Fragment Vista = null;
            switch (position)
            {
                case 0:
                    Vista = new FragmentPreguntas();
                    break;
                case 1:
                    Vista = new FragmentRespuestas();
                    break;
            }
            return Vista;
        }
        public override ICharSequence GetPageTitleFormatted(int position)
        {
            ICharSequence charSequence;
            if (position == 0)
            {
                charSequence = new Java.Lang.String("Preguntas");
            }
            else
            {
                charSequence = new Java.Lang.String("Respuestas");
            }

            return charSequence;
        }
    }
}