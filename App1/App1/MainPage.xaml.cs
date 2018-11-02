using System;
using System.Collections.Generic;
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

        private void btnJaja_Clicked(object sender, EventArgs e)
        {
            float cantidad = float.Parse(txtCantidad.Text);
            float diezPorciento = cantidad * .1f;
            lblResultado.Text = diezPorciento.ToString();
        }
    }
}
