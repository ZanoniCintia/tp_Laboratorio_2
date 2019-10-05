using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Changuito
    {
        List<Producto> productos;
        private int espacioDisponible;
        public enum ETipo
        {
            Dulce, Leche, Snacks, Todos
        }

        #region "Constructores"
        private Changuito()
        {
            this.productos = new List<Producto>();
        }
        public Changuito(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el Changuito y TODOS los Productos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
             return this.Mostrar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="c">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public string Mostrar(Changuito carro, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", carro.productos.Count, carro.espacioDisponible);
            sb.AppendLine("");
            foreach (Producto producto1 in carro.productos)
            {
                switch (tipo)
                {
                    case ETipo.Snacks:
                        if (tipo == ETipo.Snacks && producto1 is Snacks)
                        { sb.AppendLine(producto1.Mostrar()); }
                        break;
                    case ETipo.Dulce:
                        if (tipo == ETipo.Dulce && producto1 is Dulce)
                        { sb.AppendLine(producto1.Mostrar()); }
                        break;
                    case ETipo.Leche:
                        if (tipo == ETipo.Leche && producto1 is Leche)
                        { sb.AppendLine(producto1.Mostrar()); }
                        break;
                
                    default:
                        sb.AppendLine(producto1.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns></returns>
        public static Changuito operator +(Changuito carro, Producto producto)
        {
            
                if (carro.productos.Count < carro.espacioDisponible)
                {
                    foreach (Producto producto1 in carro.productos)
                    {
                        if (producto1 == producto)
                            return carro;
                    }

                carro.productos.Add(producto);
            }
               return carro;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns></returns>
        public static Changuito operator -(Changuito carro, Producto producto)
        {
                foreach (Producto producto1 in carro.productos)
                {
                    if (producto1 == producto)
                    {
                        carro.productos.Remove(producto);
                        break;
                    }
                }
           
            return carro;
        }
        #endregion
    }
}
