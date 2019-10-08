using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2018
{
    public class Leche : Producto
    {
        #region Campos
        ETipo tipo = ETipo.Entera;
        #endregion

        #region Enum
        public enum ETipo
        {   Entera,
            Descremada
        }
        
        #endregion

        #region Propiedades
        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// reutiliza codigo de la clase base
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codigo, ConsoleColor color)
            : base(codigo, marca, color)
        {
            
        }

        /// <summary>
        /// Constructor de la clase , reutiliza codigo y agrega tipo.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Leche(EMarca marca, string codigo, ConsoleColor color, ETipo tipo) : this(marca, codigo, color)
        {
            this.tipo = tipo;
        }
        /// <summary>
        /// muestra caracteristicas de la clase leche , reutiliza codigo de la clase base
        /// </summary>
        /// <returns>string</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias.ToString());
            sb.AppendLine("TIPO : " + this.tipo.ToString());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion

    }
}
