using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace FISIPOLAB_
{
    internal class Informe_Paciente
    {
        public Informe_Paciente(string fecha_informe, string paciente_informe, string dolencia, string tratamiento, string pruebas, string conclusiones)
        {
            this.fecha_informe = fecha_informe;
            this.paciente_informe = paciente_informe;
            this.dolencia = dolencia;
            this.tratamiento = tratamiento;
            this.pruebas = pruebas;
            this.conclusiones = conclusiones;
            this.detalles = new BitmapImage(new Uri(@"\img\more.png", UriKind.Relative));
        }

        public String fecha_informe {set; get;}
        public String paciente_informe { set; get;}
        public String dolencia { set; get;}
        public String tratamiento { set; get;}
        public String pruebas { set; get;}
        public String conclusiones { set; get;}
        public BitmapImage detalles { set; get;}

        // El dibujito se pone en la ventana donde vaya el informe. No aquí.
    }
}
