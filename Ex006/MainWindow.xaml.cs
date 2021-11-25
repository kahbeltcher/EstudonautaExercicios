﻿using System;
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

namespace Ex006
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            int ano = DateTime.Now.Year;
            int nascimento;
            int.TryParse(txtBox.Text, out nascimento);
            int idade = ano - nascimento;

            lblMsg1.Content = $"Estamos atualmente em {ano}"; 
            lblMsg2.Content = $"Você nasceu em {nascimento}, você tem {idade} anos "; 

            paineldeResultado.Visibility = Visibility.Visible;

        }
    }
}
