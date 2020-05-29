using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Threading.Tasks;
using Android.Bluetooth;
using Android.Bluetooth.LE;
using Java.IO;
using Java.Util;
using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Plugin.BLE;
using Plugin.BLE.Abstractions.Contracts;
using Plugin.BLE.Abstractions.Exceptions;

using System.IO;
using Java.Lang;

namespace PI4
{
    [Activity(Label = "casa")]
    public class casa : Activity
    {
        private coneBlue bluet = new coneBlue();
        public static int hh;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.casa);
            if (bluet.btSocket != null)
            {
                bluet.btSocket.Close();
            }
            var lab = FindViewById<TextView>(Resource.Id.textView1);
            var btn_hab1 = FindViewById<Button>(Resource.Id.bt_hab1);
            var btn_hab2 = FindViewById<Button>(Resource.Id.bt_hab2);
            var sala = FindViewById<Button>(Resource.Id.sala);
            var comedor = FindViewById<Button>(Resource.Id.comedor);
            var secu = FindViewById<ToggleButton>(Resource.Id.toggleButton1);
            
            btn_hab1.Click += delegate
             {
                 if (bluet.btSocket != null)
                 {
                     bluet.btSocket.Close();
                 }
                 hh = 1;
                 Intent clas = new Intent(this, typeof(habitacion));
                 StartActivity(clas);
             };
            btn_hab2.Click += delegate
            {
                if (bluet.btSocket != null)
                {
                    bluet.btSocket.Close();
                }
                hh = 2;
                Intent clas = new Intent(this, typeof(habitacion));
                StartActivity(clas);
            };
            sala.Click += delegate
            {
                if (bluet.btSocket != null)
                {
                    bluet.btSocket.Close();
                }
                hh = 3;
                Intent clas = new Intent(this, typeof(habitacion));
                StartActivity(clas);
            };
            comedor.Click += delegate
            {
                hh = 4;
                Intent clas = new Intent(this, typeof(habitacion));
                StartActivity(clas);
            };

        }
    }
}
