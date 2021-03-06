using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2_Oscar_Corado
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var numer = (Resultado.Text);
            var num = Int32.Parse(numer);
            num = num - 365;
            var cadena = num.ToString();

            x.Text = cadena.Substring(0, 1);
            y.Tetx = cadena.Substring(cadena.Length - 2, 2);


        }
    }
}
