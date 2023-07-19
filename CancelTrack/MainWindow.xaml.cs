using Aereopuerto.Context;
using Aereopuerto.Entities;
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

namespace Aereopuerto
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
        Employee services = new Employee();

        private void BtnConR_Click(object sender, RoutedEventArgs e)
        {
            WindowConsultClient interfaz = new();
            interfaz.Show();
            Close();
        }

        private void BtnGenR_Click(object sender, RoutedEventArgs e)
        {
            WindowReserveClient interfaz = new();
            interfaz.Show();
            Close();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            WindowLogin interfaz = new();
            interfaz.Show();
            Close();
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
