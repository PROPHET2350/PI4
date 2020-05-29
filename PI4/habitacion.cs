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
    [Activity(Label = "habitacion")]
    public class habitacion : Activity
    {

        private coneBlue bluet = new coneBlue();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.habitacion);
            var hablabel = FindViewById<TextView>(Resource.Id.textView1);
            var togg = FindViewById<ToggleButton>(Resource.Id.toggleButton1);
            var secu = FindViewById<ToggleButton>(Resource.Id.sec);
            var togg2 = FindViewById<ToggleButton>(Resource.Id.togg2);
            var lay = FindViewById<LinearLayout>(Resource.Id.linearLayout2);
            var apagar = FindViewById<Button>(Resource.Id.button1);
            var back = FindViewById<Button>(Resource.Id.button2);
            lay.Visibility = ViewStates.Invisible;
            bluet.CheckBt();
            {
                bluet.Connect();
                secu.Click += delegate
                {
                    if (secu.Checked)
                    {
                        secu.SetBackgroundColor(Android.Graphics.Color.Chartreuse);
                        bluet.writeData(new Java.Lang.String("o"));
                    }
                    else
                    {
                        secu.SetBackgroundColor(Android.Graphics.Color.Red);
                        bluet.writeData(new Java.Lang.String("p"));
                    }

                };
                back.Click += delegate
                {
                    if (bluet.btSocket != null)
                    {
                        bluet.btSocket.Close();
                    }
                    Intent clas = new Intent(this, typeof(casa));
                    StartActivity(clas);
                };
                switch (casa.hh)
                {
                    case 1:
                        hablabel.Text = "Habitacion 1";
                        togg.Click += delegate
                        {
                            if (togg.Checked)
                            {
                                togg.SetBackgroundColor(Android.Graphics.Color.Chartreuse);
                                bluet.writeData(new Java.Lang.String("q"));
                            }
                            else
                            {
                                togg.SetBackgroundColor(Android.Graphics.Color.Red);
                                bluet.writeData(new Java.Lang.String("w"));
                            }
                        };
                        break;
                    case 2:
                        hablabel.Text = "Habitacion 2";
                        togg.Click += delegate
                        {
                            if (togg.Checked)
                            {
                                togg.SetBackgroundColor(Android.Graphics.Color.Chartreuse);
                                bluet.writeData(new Java.Lang.String("e"));
                            }
                            else
                            {
                                togg.SetBackgroundColor(Android.Graphics.Color.Red);
                                bluet.writeData(new Java.Lang.String("r"));
                            }
                        };
                        break;
                    case 3:
                        hablabel.Text = "Sala";
                        togg.Click += delegate
                        {
                            if (togg.Checked)
                            {
                                bluet.writeData(new Java.Lang.String("t"));
                                togg.SetBackgroundColor(Android.Graphics.Color.Chartreuse);
                            }
                            else
                            {
                                bluet.writeData(new Java.Lang.String("y"));
                                togg.SetBackgroundColor(Android.Graphics.Color.Red);
                            }
                        };
                        break;
                    case 4:
                        hablabel.Text = "Comedor";
                        lay.Visibility = ViewStates.Visible;
                        togg.Click += delegate
                        {
                            if (togg.Checked)
                            {
                                togg.SetBackgroundColor(Android.Graphics.Color.Chartreuse);
                                bluet.writeData(new Java.Lang.String("u"));
                            }
                            else
                            {
                                togg.SetBackgroundColor(Android.Graphics.Color.Red);
                                bluet.writeData(new Java.Lang.String("i"));
                            }
                        };
                        togg2.Click += delegate
                        {
                            if (togg2.Checked)
                            {
                                togg2.SetBackgroundColor(Android.Graphics.Color.Chartreuse);
                                bluet.writeData(new Java.Lang.String("d"));
                            }
                            else
                            {
                                togg2.SetBackgroundColor(Android.Graphics.Color.Red);
                                bluet.writeData(new Java.Lang.String("f"));
                            }
                        };
                        apagar.Click += delegate
                        {
                            bluet.writeData(new Java.Lang.String("g"));
                        };
                        break;
                }
            }
        }
    }
}