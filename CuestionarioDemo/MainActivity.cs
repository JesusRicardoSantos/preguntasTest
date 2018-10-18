using System;
using Android.App;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace CuestionarioDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, MediaPlayer.IOnPreparedListener
    {
        //prueba common
        EditText txtUsuario, txtPassword;
        Button btnLogin;

        VideoView video;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            txtUsuario = (EditText)FindViewById(Resource.Id.txtUsuario);
            txtPassword = (EditText)FindViewById(Resource.Id.txtContrasena);
            btnLogin = (Button)FindViewById(Resource.Id.btnLogin);

            btnLogin.Click += delegate {
                
            };

            video = (VideoView)FindViewById(Resource.Id.videoPlay);

            video.SetOnPreparedListener(this);
            string videoPaht = "android.resource://CuestionarioDemo.CuestionarioDemo/" + Resource.Raw.agri;
            Android.Net.Uri uri = Android.Net.Uri.Parse(videoPaht);
            video.SetVideoURI(uri);
            video.Start();
        }

        public void OnPrepared(MediaPlayer mp)
        {
            mp.Looping = true;
            mp.SetVolume(0, 0);
            mp.SetVideoScalingMode(VideoScalingMode.ScaleToFitWithCropping);
        }

        /*
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }*/
    }
}

