using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClasesInstanciables.Universidad;

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
        public bool Guardar(Jornada jornada)
        {
            bool retorno = false;
            return retorno;
        }

        private Jornada()
        {
            //List<Alumno> alumnos = new List<>;
        }
        public Jornada(EClases clase, Profesor instructor)
        {

        }
        #endregion
    }
}
