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

namespace GestorCitas
{
    /// <summary>
    /// Lógica de interacción para Citas.xaml
    /// </summary>
    public partial class Citas : Window
    {
        public static dto.Logica logica = new dto.Logica();

        public Citas()
        {
            InitializeComponent();
            //mi_menu.Items.Add(new MenuHead());
            mi_datagrid.DataContext = logica;
        }

        private void EditarCita(object sender, RoutedEventArgs e)
        {
            if (mi_datagrid.SelectedIndex != -1)
            {
                new Formulario(mi_datagrid.SelectedIndex).Show();
            }
        }

        private void CitaNueva(object sender, RoutedEventArgs e)
        {
            new Formulario().Show();
        }

        private void EliminarCita(object sender, RoutedEventArgs e)
        {
            if (mi_datagrid.SelectedIndex != -1)
            {
                logica.EliminarCita(mi_datagrid.SelectedIndex);
            }
        }
    }

}