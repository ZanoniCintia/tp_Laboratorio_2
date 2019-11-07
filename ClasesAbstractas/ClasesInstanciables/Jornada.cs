using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClasesInstanciables.Universidad;
using Archivos;

namespace ClasesInstanciables
{
    public class Jornada
    {
        #region Campos
        private List<Alumno> alumnos;
        private EClases clase;
        private Profesor instructor;

        #endregion

        #region Propiedades


        public List<Alumno> Alumnos
        {
            get { return alumnos; }
            set { this.alumnos = value; }
        }

        public EClases Clase
        {
            get { return clase; }
            set { clase = value; }
        }

        public Profesor Instructor
        {
            get { return instructor; }
            set { this.instructor = value; }
        }




        #endregion

        #region Metodos
      
        private Jornada()
        {
           alumnos = new List<Alumno>();
        }
        public Jornada(EClases clase, Profesor instructor):this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        public static string Leer()
        {
            Texto texto = new Texto();
            texto.Leer("Jornada.txt", out string jornadaAux);
            return jornadaAux;
        }

        public static bool Guardar(Jornada jornada)
        {
            Texto texto = new Texto();
            return texto.Guardar("Jornada.txt", jornada.ToString());
        }
        public new string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CLASE DE {0} POR {1}",clase.ToString(),instructor.ToString());
            sb.AppendLine("ALUMNOS:");
            foreach (Alumno alumno in this.alumnos)
            {
                sb.AppendLine(alumno.ToString());
            }
            return sb.ToString();
        }
        #endregion
    }
}
