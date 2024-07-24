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

namespace FISIPOLAB_
{
    /// <summary>
    /// Lógica de interacción para VentanaInforme.xaml
    /// </summary>
    public partial class VentanaInforme : Window
    {   
        private string fecha;
        private string paciente;
        private string dolencia;
        private string pruebas;
        private string conclusiones;
        MainConfiguration config {  get; set; }

        public VentanaInforme(string fecha, string paciente, string dolencia, string pruebas, string conclusiones, MainConfiguration config)
        {
            InitializeComponent();
            this.fecha = fecha;
            this.paciente = paciente;
            this.dolencia = dolencia;
            this.pruebas = pruebas;
            this.conclusiones = conclusiones;
            this.config = config;

            gridMain.DataContext = this.config;
            lblNombrePaciente.Content = paciente;
            tbPrueba.Text +=pruebas;
            tbDolencia.Text += dolencia;
            tbFecha.Text += fecha;
            tbConclusionesInforme.Text = conclusiones;
        }
    }
}
