using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorCitas.dto
{
    public class Cita : INotifyPropertyChanged
    {
        private string text1;
        private string text2;
        private string text3;
        private DateTime selectedDate;

        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String Grupo { get; set; }
        public DateTime Fecha { get; set; }

        public Cita()
        {
            Grupo = "Si";
            Fecha = DateTime.Now;
        }

        public Cita(string nombre, string apellidos, string grupo, DateTime fecha, string ciudad, string sala)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Grupo = grupo;
            Fecha = fecha;
        }

        public Cita(string text1, string text2, string text3, DateTime selectedDate)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.selectedDate = selectedDate;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}