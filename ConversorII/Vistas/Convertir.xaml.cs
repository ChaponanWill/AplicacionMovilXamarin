using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConversorII.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        double cm;
        double m;
        public Convertir()
        {
            InitializeComponent();
        }
        private void Calcular()
        {
            cm=Convert.ToDouble(txtcm.Text);
            m = cm / 100;
            resultado.Text = m.ToString() + "m";
        }
        private void Validar()
        {
            if(!String.IsNullOrEmpty(txtcm.Text))
            {
                Calcular();
            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad", "Ok");
            }
        }
        private void boton_volver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
      }

        private void btn_calcular_Clicked(object sender, EventArgs e)
        {
            Validar();
        }
    }
}