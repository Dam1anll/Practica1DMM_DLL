using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica1DMM_DLL.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica1DMM_DLL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaPrincipal : ContentPage
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
            BindingContext = new PaginaPrincipalVM(Navigation);
        }


    }
}