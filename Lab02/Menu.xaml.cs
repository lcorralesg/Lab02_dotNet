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
using System.Windows.Shapes;

namespace Lab02
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalidas_Click(object sender, RoutedEventArgs e)
        {
            RegistroSalidas registroSalidas = new RegistroSalidas();
            registroSalidas.ShowDialog();
        }

        private void btnCamiones_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnListado_Click(object sender, RoutedEventArgs e)
        {
            ListadoSalidas listadoSalidas = new ListadoSalidas();
            listadoSalidas.ShowDialog();
        }
    }
}
