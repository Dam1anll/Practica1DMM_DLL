using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Practica1DMM_DLL.View;

namespace Practica1DMM_DLL.ViewModel
{
    public class PaginaPrincipalVM : BaseViewModel
    {
        public PaginaPrincipalVM(INavigation navigation)
        {
            Navigation = navigation;
        }
        public async Task IraPagina2()
        {
            await Navigation.PushAsync(new Pagina2());
        }
        public ICommand IraPagina2Command => new Command(async () => await IraPagina2());
    }
}
