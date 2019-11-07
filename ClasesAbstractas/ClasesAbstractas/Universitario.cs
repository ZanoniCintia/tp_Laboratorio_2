using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
#pragma warning disable CS0660, CS0661, CS0659
    public abstract class Universitario : Persona
    {
        #region Campos
        private int legajo;
        #endregion

        #region Metodos
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj is null))
            {
                if (obj is Universitario)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("Legajo : {0}\n", legajo);
            return sb.ToString();
        }

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool retorno = false;
            if (pg1.Equals(pg2) && (pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        protected abstract string ParticiparEnClase();

        public Universitario() : base()
        {

        }
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

    }
}
