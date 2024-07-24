using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FISIPOLAB_
{
    internal class Prof_Limpieza : Profesional
    {
        public string horario { get; set;}

        public Prof_Limpieza(string nombre, string apellidos, string fnac, string direcc, string email, string tlf, string sexo, string dni, TipoProfesional tipo, string horario) : base(nombre, apellidos, fnac, direcc, email, tlf, sexo, dni, tipo)

		{   
			this.horario = horario;
        }
    }
}
