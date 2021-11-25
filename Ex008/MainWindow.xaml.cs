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

namespace Ex008
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            int inicio, fim;
            lblMsg3.Visibility = Visibility.Visible;

            int.TryParse(txtInicio.Text, out inicio);
            int.TryParse(txtFim.Text, out fim);

            Random ger = new Random();
            int numero = ger.Next(inicio, fim + 1);


            lblMsg3.Content = $"SORTEANDO DE {inicio} a {fim}...";
            await Task.Delay(2000);
            lblMsg3.Content = ($"O número sorteado foi: {numero}");
        }
    }
}
