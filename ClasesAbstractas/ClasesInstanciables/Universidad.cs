using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace ClasesInstanciables
{
    public class Universidad
    {
        #region Campos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion

        #region Propiedades


        #endregion

        #region Metodos
        public bool Guardar(Universidad uni)
        {

            return Guardar(uni);
        }
        #endregion
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            Spd
        }
    }
}
