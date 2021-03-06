using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            var num = (Dijito.Text);

            num = num.Remove(num.Length - 1, 1);

            var nume = Int32.Parse(num);

            nume = nume - 4;

            Resultado.Text = num.ToString();
        }
    }
}
