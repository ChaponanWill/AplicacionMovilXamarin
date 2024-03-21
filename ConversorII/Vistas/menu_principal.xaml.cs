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
    public partial class menu_principal : ContentPage
    {
        public menu_principal()
        {
            InitializeComponent();
        }

        private void boton_iniciar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Convertir());
        }
    }
}