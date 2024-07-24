using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FISIPOLAB_
{   
    public enum TipoProfesional
    {
        Sanitario,
        Limpieza
    }

    public partial class Profesional
    {
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public string FechaNacimiento { set; get; }
        public string Direccion { set; get; }
        public string Email{ set; get; }
        public string Telefono { set; get; }
        public string Sexo { set; get; }
        public string DNI { set; get; }
        public TipoProfesional Tipo { set; get; }

        public Profesional(string nombre, string apellidos, string fnac, string direcc, string email, string tlf, string sexo, string dni, TipoProfesional tipo)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fnac;
            this.Direccion = direcc;
            this.Email= email;
            this.Telefono = tlf;
            this.Sexo = sexo;
            this.DNI = dni; 
            this.Tipo = tipo;
        }
    }
}
