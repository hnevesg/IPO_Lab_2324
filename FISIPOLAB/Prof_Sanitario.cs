using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FISIPOLAB_
{
    internal class Prof_Sanitario : Profesional
    {
      public string historial { get; set; }

      public Prof_Sanitario(string nombre, string apellidos, string fnac, string direcc, string email, string tlf, string sexo, string dni, TipoProfesional tipo, string historial) : base(nombre, apellidos, fnac, direcc, email, tlf, sexo, dni, tipo)

		{
			this.historial = historial;
      }
	}
}
