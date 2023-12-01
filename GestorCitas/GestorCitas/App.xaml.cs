using System;
using System.Windows;
using GestorCitas;

namespace GestorCitas
{
    public partial class App : Application
    {
        [STAThread]
        public static void Main()
        {
            //App app = new App();
            //Formulario formulario = new Formulario(); // o el nombre de tu ventana principal
            //app.Run(formulario);
            App app = new App();
            Citas citas = new Citas(); // o el nombre de tu ventana principal
            app.Run(citas);
        }
    }
}
