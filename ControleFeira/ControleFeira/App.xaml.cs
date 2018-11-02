using PCLExt.FileStorage;
using PCLExt.FileStorage.Folders;
using SQLite;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ControleFeira
{
    public partial class App : Application
    {
        /* propriedade usada para acessar o banco de dados dentro da aplicação */
        public SQLiteConnection Conexao { get; private set; }

        public App()
        {
            /* Abrir a pasta local de arquivos e criar o arquivo banco.db. */
            var pasta = new LocalRootFolder();
            var arquivo = pasta.CreateFile("banco.db", CreationCollisionOption.OpenIfExists);

            /* Criando conexao e depois tabela informacoes com os campos id e info */
            Conexao = new SQLiteConnection(arquivo.Path);
            Conexao.Execute("create table if not exists informacoes (id integer primary key autoincrement, info text)");

            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart() { }



        protected override void OnSleep() { }
        

        protected override void OnResume() { }
        
    }
}
