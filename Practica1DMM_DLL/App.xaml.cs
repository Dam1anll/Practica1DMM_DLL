using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Practica1DMM_DLL.View;

namespace Practica1DMM_DLL
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaPrincipal();
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
