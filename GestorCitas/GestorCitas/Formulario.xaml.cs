using GestorCitas;
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
using GestorCitas.dto;

namespace GestorCitas
{

    public partial class Formulario : Window
    {
        private Cita cita;
        private int index;

        public Formulario()
        {
            InitializeComponent();
            this.index = -1;
            this.cita = new Cita();
            this.DataContext = this.cita;
        }

        public Formulario(int index)
        {
            InitializeComponent();
            this.index = index;
            this.cita = new Cita();
            this.DataContext = Citas.logica.ListaCita[index];
        }

        private void Agregar(object sender, RoutedEventArgs e)
        {
            if (index > -1)
            {
                Citas.logica.EditarCita(index, new Cita(mi_nombre.Text, mi_apellidos.Text, mi_grupo.Text, (DateTime)mi_fecha.SelectedDate));
            }
            else
            {
                Citas.logica.AgregarCita(new Cita(mi_nombre.Text, mi_apellidos.Text, mi_grupo.Text, (DateTime)mi_fecha.SelectedDate));
            }

            this.Close();
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}