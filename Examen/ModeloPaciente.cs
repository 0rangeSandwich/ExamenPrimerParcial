using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class ModeloPaciente
    {
        private int pacienteId;
        private string pacienteNombre;
        private string pacienteApellido;
        private int pacienteEdad;
        private string pacienteMotivoDeConsulta;


        public int PacienteId
        {
            get { return pacienteId; }
            set { pacienteId = value; }
        }
        public string PacienteNombre
        {
            get { return pacienteNombre; }
            set { pacienteNombre = value; }
        }

        public string PacienteApellido
        {
            get { return pacienteApellido; }
            set { pacienteApellido = value; }
        }

        public int PacienteEdad
        {
            get { return pacienteEdad; }
            set { pacienteEdad = value; }
        }

        public string PacienteMotivoDeConsulta
        {
            get { return pacienteMotivoDeConsulta; }
            set { pacienteMotivoDeConsulta = value; }
        }

        override
        public String ToString()
        {
            return string.Format("El id del paciente es:{0}\n" + "El nombre del paciente es:{1}\n" + "El apellido del paciente es:{2}\n" + "La edad del paciente es:{3}\n" + "El motivo de la consulta es :{4}\n", PacienteId, PacienteNombre, PacienteApellido, PacienteEdad, PacienteMotivoDeConsulta);

        }

    }
}
