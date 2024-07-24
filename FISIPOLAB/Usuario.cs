using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FISIPOLAB_
{
    internal class Usuario
    {
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
		public string DNI { set; get; }
		public string FechaNacimiento { set; get; }
        public string Direccion { set; get; }
        public string Telefono { set; get; }
		public string Email { set; get; }
		public string NombreUsuario { set; get; }
		public string Contraseña { set; get; }

		public string UltimoAcceso { set; get; }

		public Usuario(string nombre, string apellidos, string dni, string fnac, string direcc, string tlf, string email, string username, string passw,string lastAcc)
		{
			this.Nombre = nombre;
			this.Apellidos = apellidos;
			this.DNI = dni;
			this.FechaNacimiento = fnac;
			this.Direccion = direcc;
            this.Telefono = tlf;
            this.Email = email;
			this.NombreUsuario = username;
            this.Contraseña = passw;
			this.UltimoAcceso = lastAcc;
			
		}
	}
}
