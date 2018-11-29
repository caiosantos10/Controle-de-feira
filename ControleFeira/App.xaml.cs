using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ControleFeira
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Bootstrapper Bootstrapper;

        protected override void OnStartup(StartupEventArgs e)
        {
            Bootstrapper = new Bootstrapper();
            base.OnStartup(e);
        }
    }
}
