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
    /// Lógica de interacción para ListadoSalidas.xaml
    /// </summary>
    public partial class ListadoSalidas : Window
    {
        public ListadoSalidas()
        {
            InitializeComponent();

            Grifo grifo = new Grifo();

            dgSalidas.ItemsSource = grifo.SalidasList;

        }

    }
}
