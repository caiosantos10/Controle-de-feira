﻿using ControleFeira.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ControleFeira
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var ctx = new ControleFeiraContext())
            {
                //var stud = new UsuarioModel();
                //stud.UsuarioID = 2;
                //stud.UsuarioName = "Bill";
                //stud.UsuarioSenha = "123";
                //stud.UsuarioEmail = "bill@hotmail.com";

                //ctx.Entry(stud).State = System.Data.Entity.EntityState.Deleted;
                //ctx.SaveChanges();

                ctx.Usuarios.ToList().ForEach(user => Console.WriteLine(user.UsuarioName));
            }
        }
    }
}
