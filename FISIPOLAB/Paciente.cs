using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace FISIPOLAB_
{
    public partial class Paciente
    {
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public string FechaNacimiento { set; get; }
        public string Direccion { set; get; }
        public string Email{ set; get; }
        public string Telefono { set; get; }
        public string DNI { set; get; }
        public string Sexo{ set; get; }
        public bool Cirugia { set; get; }
        public bool Fumador { set; get; }

        public Paciente(string nombre, string apellidos, string fnac, string direcc, string email, string tlf, string dni, string sexo, bool cirugia, bool fumador)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fnac;
            this.Direccion = direcc;
            this.Email= email;
            this.Telefono = tlf;
            this.DNI = dni;
            this.Sexo = sexo;
            this.Cirugia = cirugia;
            this.Fumador = fumador;
        }
    }
}