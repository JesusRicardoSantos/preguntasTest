using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace CuestionarioDemo
{
    public class FragmentPreguntas : Android.Support.V4.App.Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View Vista = inflater.Inflate(Resource.Layout.layoutPreguntas, container, false);

            return Vista;
        }

    }

    public class AdaptadorPreguntas : BaseAdapter<Preguntas>
    {
        List<Preguntas> lista;
        Activity context;
        int bandera;

        public AdaptadorPreguntas(List<Preguntas> lista, Activity context, int bandera)
        {
            this.lista = lista;
            this.context = context;
            this.bandera = bandera;
        }
        
        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override Preguntas this[int position]
        {
            get { return lista[position]; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override int Count
        {
            get { return lista.Count; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = lista[position];
            View view = convertView;
            view = context.LayoutInflater.Inflate(Resource.Layout.itemsLista, null);
            view.FindViewById<TextView>(Resource.Id.txtPregunta).Text = item.pregunta;
            var si = view.FindViewById<TextView>(Resource.Id.si);
            si.Text = item.resp_1;
            var no = view.FindViewById<TextView>(Resource.Id.no);
            no.Text = item.resp_2;
            si.Click += delegate 
            {
                si.SetBackgroundColor(Color.Rgb(132, 196, 84));
                no.SetBackgroundColor(Color.White);
            };
            no.Click += delegate
            {
                no.SetBackgroundColor(Color.Rgb(193,25,25));
                si.SetBackgroundColor(Color.White);
            };

            return view;
        }
    }

    public class Preguntas
    {
        public int id_pregunta { get; set; }
        public string pregunta { get; set; }
        public string resp_1 { get; set; }
        public string resp_2 { get; set; }
    }
}