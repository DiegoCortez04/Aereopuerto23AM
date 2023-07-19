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
using Aereopuerto.Entities;
using Aereopuerto.Services;
using Org.BouncyCastle.Asn1.Ocsp;
using static System.Net.Mime.MediaTypeNames;

namespace Aereopuerto
{
    /// <summary>
    /// Lógica de interacción para WindowReserve.xaml
    /// </summary>
    public partial class WindowReserveClient : Window
    {
        int NoReserva = 2;
        public string reservaActual;
        public WindowReserveClient()
        {
            InitializeComponent();
            reservaActual = NoReserva.ToString("00000");
            txtNoReserva.Text = reservaActual;
        }
        EmployeeServices services = new EmployeeServices();
        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            NoReserva++; //Incrementar NoReserva antes de generar la reserva
            try
            {
                reservaActual = NoReserva.ToString("00000"); //Actualizar reservaActual con el nuevo número de reserva
                Client cliente = new Client()
                {
                    Name = txtNombre.Text,
                    LastName = txtApellido.Text,
                    Age = int.Parse(txtEdad.Text),
                    INE = txtINE.Text,
                    Phone = int.Parse(txtTelefono.Text),
                    Email = txtCorreo.Text,
                    TypeService = cbxServicio.Text,
                    Passengers = int.Parse(txtPasajeros.Text),
                    NoReserve = int.Parse(reservaActual)
                };
                if (!string.IsNullOrEmpty(txtNombre.Text) || !string.IsNullOrEmpty(txtApellido.Text) || !string.IsNullOrEmpty(txtApellido.Text))
                {
                    services.Add(cliente);
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtEdad.Clear();
                    txtINE.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                    cbxServicio.Items.Clear();
                    txtPasajeros.Clear();
                    txtNoReserva.Clear();
                    MessageBox.Show("Los datos han sido agregados correctamente");
                }
                else
                    MessageBox.Show("Los datos no sido agregados correctamente");
                MessageBox.Show("Reserva generada exitosamente");
                MainWindow interfaz = new MainWindow();
                interfaz.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error " + ex.Message);
            }
        }
    }
}
