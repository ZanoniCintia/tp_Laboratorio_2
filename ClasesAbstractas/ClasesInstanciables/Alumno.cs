using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        #region Campos
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion

        public Alumno()
        {

        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad,
                     Universidad.EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad,
                      Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ToString());
            sb.AppendFormat("Clases que toma :{0}\n", claseQueToma);
            sb.AppendFormat("Estado de cuenta : {0}\n", claseQueToma);
            return sb.ToString();
        }

        public new string ToString()
        {
            return MostrarDatos();
        }

       /* public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            bool retorno = false;
            if ((a == clase) || (a.estadoCuenta == EEstadoCuenta.Deudor))
            {
                retorno= true;
            }
            return retorno;

        }*/

       /* public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a == clase);
        }*/

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("TOMA CLASE DE :", claseQueToma);
            return sb.ToString();
        }




        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

    }
}
