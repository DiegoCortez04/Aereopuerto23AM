using Aereopuerto.Entities;
using Aereopuerto.Services;
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
using System.Windows.Shapes;

namespace Aereopuerto
{
    /// <summary>
    /// Lógica de interacción para WindowConsultClient.xaml
    /// </summary>
    public partial class WindowConsultClient : Window
    {
        public WindowConsultClient()
        {
            InitializeComponent();
        }
        EmployeeServices services = new EmployeeServices();
        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow interfaz = new();
            interfaz.Show();
            Close();
        }

        private void BtnConsultar_Click(object sender, RoutedEventArgs e)
        {
            int NoReserva = int.Parse(txtNoReserva.Text);
            Client empleado = services.Read(NoReserva);
            if (empleado != null)
            {
                txtNombre.Text = empleado.Name;
                txtApellido.Text = empleado.LastName;
                txtEdad.Text = empleado.Age.ToString();
                txtINE.Text = empleado.INE;
                txtTelefono.Text = empleado.Phone.ToString();
                txtCorreo.Text = empleado.Email;
                cbxServicio.Text = empleado.TypeService;
                txtPasajeros.Text = empleado.Passengers.ToString();
                txtNoReserva.Text = empleado.NoReserve.ToString();
            }
            else
            {
                MessageBox.Show("Reserva no encontrada");
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtEdad.Text = string.Empty;
                txtINE.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                txtCorreo.Text = string.Empty;
                cbxServicio.Text = string.Empty;
                txtPasajeros.Text = string.Empty; ;
                txtNoReserva.Text = string.Empty;
            }
        }
    }
}
