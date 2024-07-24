using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FISIPOLAB_
{
	internal enum EstadoCita
	{
		Cancelada,
		Finalizada,
		Pendiente
	}
	internal class Cita
    {
		public DateTime fecha_cita { get; set; }
        public Paciente paciente { get; set; }
        public TimeSpan hora_cita { get; set; }
        public Prof_Sanitario sanitario { get; set; }
        public int duracion { get; set; }
        public EstadoCita estado { get; set; }
		

		public Cita(DateTime fecha_cita, Paciente paciente, TimeSpan hora_cita, Prof_Sanitario sanitario, int duracion, EstadoCita estado)
        {
            this.fecha_cita = fecha_cita;
            this.paciente = paciente;
            this.hora_cita = hora_cita;
            this.sanitario = sanitario;
            this.duracion = duracion;
            this.estado = estado;
        }
    }
}