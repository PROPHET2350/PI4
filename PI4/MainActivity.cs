using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Data;
using System.Data.SqlClient;
using Android.Content;

namespace PI4
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity :Activity
    {
        public static string lbl;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            var user = FindViewById<EditText>(Resource.Id.editText1);
            var pass = FindViewById<EditText>(Resource.Id.pass);
            var log = FindViewById<Button>(Resource.Id.button1);

         // string conexion = @"Data source=192.168.137.2;initial catalog=electronica;user id=juan;password=123";
            //instanciar cadena conexion
          string conexion = "Server=192.168.137.2;Database=electronica;User Id=juan;Password=123";
            SqlConnection con = new SqlConnection(conexion);

           

                log.Click += delegate
            {
               
                if (pass.Text.Equals("") || user.Text.Equals(""))
                {
                    Toast.MakeText(this, "rellene todos los campos", ToastLength.Long).Show();
                }
                else
                {
                    //com.Connection = con;
                    //com.CommandText = "select * from usuarios where nomUsuario = '"+user.Text+"' and cedUsuario = '"+pass.Text+"'";
                    //leer = com.ExecuteReader();
                    //leer.Read();
                    //if (leer.HasRows)
                    //{
                    //    Intent clas = new Intent(this, typeof(casa));
                    //    StartActivity(clas);
                    //}
                    //else
                    //{
                    //    Toast.MakeText(this, "Usuario/Contraseña incorrecta", ToastLength.Long).Show();
                    //}
                    if (user.Text == "jorge" && pass.Text == "2350")
                    {
                        Intent clas = new Intent(this, typeof(casa));
                        StartActivity(clas);
                    }
                    else
                    {
                        Toast.MakeText(this, "Usuario/Contraseña incorrecta", ToastLength.Long).Show();
                    }
                }
            };
        }
    }
}