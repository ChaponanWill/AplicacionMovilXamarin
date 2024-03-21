using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ConversorII.Vistas;

namespace ConversorII
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new menu_principal());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
