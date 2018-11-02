using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ControleFeira.ViewModel;
namespace ControleFeira
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CarregarInformacoes();
        }

        /* Faz uma consulta na tabela informacoes do banco de dados, resgatando os dados que estão no campo info */
        private void CarregarInformacoes()
        {
            var list = ((App)Application.Current).Conexao.Query<Model>("select * from informacoes");
            ListView.ItemsSource = list;
        }

        // Cria uma query insert para inserir o horário atual no banco de dados
        private void ButtonAdicionar_OnClicked(object sender, EventArgs e)
        {
            var query = $"insert into informacoes (info) values ('{DateTime.Now:yyyy-MM-dd HH:mm:ss.ffff}')";

            ((App)Application.Current).Conexao.Execute(query);
            CarregarInformacoes();
        }

        // Apaga toda a tabela informacoes
        private void ButtonApagarTudo_OnClicked(object sender, EventArgs e)
        {
            ((App)Application.Current).Conexao.Execute("delete from informacoes");
            CarregarInformacoes();
        }

        private void MenuItemAtualizar_OnClicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var model = (Model)menuItem.CommandParameter;
            var result = ((App)Application.Current).Conexao.Execute("update informacoes set info = ? where id = ?", $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.ffff}", model.Id);
            CarregarInformacoes();
        }

        private void MenuItemApagar_OnClicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var model = (Model)menuItem.CommandParameter;
            ((App)Application.Current).Conexao.Execute("delete from informacoes where id = ?", model.Id);
            CarregarInformacoes();
        }


    }
}
