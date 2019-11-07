using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClasesInstanciables.Universidad;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<EClases> ClasesDelDia;
        static Random random;

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CLASE DEL DIA : {0}");
            foreach (EClases clase in this.ClasesDelDia)
            {
                sb.AppendFormat("{0} ", clase);
            }

            return sb.ToString();
        }

        static Profesor()
        {
            random = new Random();
        }
        private void _RandomClases()
        {
            int aux = random.Next(0, 3);

            ClasesDelDia.Enqueue((EClases)aux);


        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ToString());
            sb.AppendFormat(this.ParticiparEnClase());
            return sb.ToString();
        }

        public static bool operator ==(Profesor i, EClases clase)
        {
            bool retorno = false;
            foreach (EClases clases in i.ClasesDelDia)
            {
                if (clase == clases)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Profesor i, EClases clase)
        {
            return !(i == clase);
        }

    }
}
