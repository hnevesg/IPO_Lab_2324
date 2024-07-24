using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FISIPOLAB_
{
    public partial class MainConfiguration
    {
        public Paciente PacienteSeleccionado {  get; set; }
        public Profesional ProfesionalSeleccionado { get; set; }
        public BitmapImage urlFondo { get; set; }
        public SolidColorBrush ColorPanel { get; set; }
        public SolidColorBrush ColorBotonNoPresionado {  get; set; }
        public SolidColorBrush ColorBotonPresionado {  get; set; }
        public SolidColorBrush ColorLetra { get; set; }
        public string TamanioLetra {  get; set; }
        public MainConfiguration()
        {
            this.urlFondo = new BitmapImage(new Uri(@"/img/fondo_claro.png", UriKind.Relative));
            this.ColorPanel = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9FFFFFFF"));
            this.ColorBotonNoPresionado = new SolidColorBrush(Colors.White);
            this.ColorBotonPresionado = new SolidColorBrush(Colors.LightGray);
            this.ColorLetra = new SolidColorBrush(Colors.Black);
            this.TamanioLetra = "15";
        }
        public MainConfiguration(BitmapImage urlFondo, SolidColorBrush ColorPanel, SolidColorBrush ColorBotonNoPresionado, SolidColorBrush ColorBotonPresionado, SolidColorBrush ColorLetra, string TamanioLetra) 
        {
            this.urlFondo= urlFondo;
            this.ColorPanel = ColorPanel;
            this.ColorBotonPresionado = ColorBotonPresionado;
            this.ColorBotonNoPresionado= ColorBotonNoPresionado;
            this.ColorLetra = ColorLetra;
            this.TamanioLetra = TamanioLetra;
        }
    }
}
