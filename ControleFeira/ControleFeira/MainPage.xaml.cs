using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ControleFeira
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new Model.Model();
            CarregarInformacoes();
        }

        /* Faz uma consulta na tabela informacoes do banco de dados, resgatando os dados que estão no campo info */
        private void CarregarInformacoes()
        {
            var list = ((App)Application.Current).Conexao.Query<Model.Model>("select info from informacoes");
            ListView.ItemsSource = list;
        }

        // Cria uma query insert para inserir o horário atual no banco de dados
        private void Button_OnClicked(object sender, EventArgs e)
        {
            var query = $"insert into informacoes (info) values (&#039;{DateTime.Now:yyyy-MM-dd HH:mm:ss.ffff}&#039;)";
            ((App)Application.Current).Conexao.Execute(query);
            CarregarInformacoes();
        }
    }
}
