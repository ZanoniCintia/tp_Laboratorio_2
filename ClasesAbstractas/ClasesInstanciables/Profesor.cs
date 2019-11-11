using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClasesInstanciables.Universidad;
using ClasesAbstractas;
using System.Threading;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<EClases> ClasesDelDia;
        static Random random;

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASE DEL DIA :");
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
            Thread.Sleep(300);
            ClasesDelDia.Enqueue((EClases)aux);


        }
        public Profesor():base()
        {

        }
        public Profesor(int id,string nombre,string apellido,string dni,ENacionalidad nacionalidad)
            :base(id,nombre,apellido,dni,nacionalidad)
        {
            ClasesDelDia = new Queue<Universidad.EClases>();
            _RandomClases();
        }
       

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ToString());
            sb.AppendFormat(this.ParticiparEnClase());
            return sb.ToString();
        }
        public new string ToString()
        {
            return MostrarDatos();
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
