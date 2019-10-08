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
        #region enum
        public enum EMarca
        {
            Serenisima,
            Campagnola,
            Arcor,
            Ilolay,
            Sancor,
            Pepsico
        }
        #endregion

        #region Campos
        protected EMarca marca;
        private string codigoDeBarras;
        private ConsoleColor colorPrimarioEmpaque;

        #endregion

        #region Propiedades
        /// <summary>la clase No contiene calorias para retornar
        /// ReadOnly: Retornará la cantidad de ruedas del vehículo ???????
        /// </summary>
        protected abstract short CantidadCalorias
        {
            get;

        }

        #endregion

        #region Metodos
        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns>string</returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CODIGO DE BARRAS: {0}\n", this.codigoDeBarras.ToString());
            sb.AppendFormat("MARCA          : {0}\n", this.marca.ToString());
            sb.AppendFormat("COLOR EMPAQUE  : {0}\n", this.colorPrimarioEmpaque.ToString());
            sb.AppendFormat("---------------------");

            return sb.ToString();

        }

        /// <summary>
        /// devuelve un string con el metodo mostrar
        /// </summary>
        /// <param name="p"></param>
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
        public static bool operator ==(Producto producto1, Producto producto2)
        {
            bool retorno = false;
            if (!(producto1 is null) && !(producto2 is null))
            {
                if (producto1.codigoDeBarras == producto2.codigoDeBarras)
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
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }

        /// <summary>
        /// Constructor de la clase 
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        public Producto(string codigo, EMarca marca, ConsoleColor color)
        {
            this.codigoDeBarras = codigo;
            this.marca = marca;
            this.colorPrimarioEmpaque = color;
        }
        #endregion

    }
}
