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

namespace Lab02
{
    /// <summary>
    /// Lógica de interacción para RegistroSalidas.xaml
    /// </summary>
    public partial class RegistroSalidas : Window
    {
        public RegistroSalidas()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Salidas salidas = new Salidas(cbTipoDocumento.Text, txtNumeroDocumento.Text, Convert.ToDouble(txtPeso.Text), cbTipoAuto.Text, txtNombreTransportista.Text, DateTime.Now, Convert.ToDouble(txtPesoIngreso.Text), Convert.ToDouble(txtPesoSalida.Text));
            Grifo grifo = new Grifo();
            grifo.SalidasList.Add(salidas);
            //Depurar imprimiendo en consola la lista de salidas
            foreach (Salidas salida in grifo.SalidasList)
            {
                Console.WriteLine(salida);
            }

            MessageBox.Show("Salida registrada correctamente");
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
