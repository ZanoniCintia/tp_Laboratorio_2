using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable
namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    { 
        public enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }
        protected EMarca marca;
        private string codigoDeBarras;
        private ConsoleColor colorPrimarioEmpaque;

        /// <summary>
        /// ReadOnly: Retornará la cantidad de ruedas del vehículo ???????
        /// </summary>
        protected virtual short CantidadCalorias
        {
            get;
           
        }

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CODIGO DE BARRAS: {0}\n", this.codigoDeBarras.ToString());
            sb.AppendFormat("MARCA          : {0}\n", this.marca.ToString());
            sb.AppendFormat("COLOR EMPAQUE  : {0}\n", this.colorPrimarioEmpaque.ToString());
            sb.AppendFormat("---------------------");

            return sb.ToString();

        }

        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(p.Mostrar());
           
            return sb.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1"></param>
        /// 
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            bool retorno = false;
            if (!(v1 is null) && !(v2 is null))
            {
                if (v1.codigoDeBarras == v2.codigoDeBarras)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return !(v1.codigoDeBarras == v2.codigoDeBarras);
        }

        public Producto(string codigo, EMarca marca,ConsoleColor color)
        {
            this.codigoDeBarras = codigo;
            this.marca = marca;
            this.colorPrimarioEmpaque = color;
        }
    }
}
