using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Feira.ViewModels
{
    class MenuViewModel : Conductor<object>
    {
        public void ShowDispensaScreen()
        {
            ActivateItem(new DispensaViewModel());
        }

        public void ShowCarrinhoScreen()
        {
            ActivateItem(new CarrinhoViewModel());
        }

        public void ShowHistoricoScreen()
        {
            ActivateItem(new HistoricoViewModel());
        }

        public void ShowProdutosScreen()
        {
            App.Bootstrapper.Init(new CadastroViewModel());
        }
    }
}
