using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        #region Campos
        private string nombre;
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        #endregion

        #region Propiedades
        public string Apellido
        {
            get
            {

                return this.apellido;
            }
            set { apellido = ValidarNombreApellido(value); }
        }

        public int DNI
        {
            get
            {
                return this.dni;
            }
            set { dni = ValidarDni(nacionalidad,value); }
        }

        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set { nacionalidad = value; }
        }

        public string Nombre
        {
            get
            {

                return this.nombre;

            }
            set { nombre = ValidarNombreApellido(value); }
        }

        public string StringToDni
        {

            set { dni = ValidarDni(this.nacionalidad, value); }
        }




        #endregion

        #region Metodos
        public Persona()
        {


        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni,
            ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni,
            ENacionalidad nacionalidad) : this(nombre, apellido,nacionalidad)
        {
            this.StringToDni = dni;

        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int retorno = 0;
            if ((dato >= 1 && dato <= 89999999) && (nacionalidad == ENacionalidad.Argentino))
            {
                retorno = dato;

            }
            else if ((dato >= 90000000 && dato <= 99999999) && (nacionalidad == ENacionalidad.Extranjero))
            {
                retorno = dato;
            }
            else
            {
                throw new NacionalidadInvalidaException();
            }

            return retorno;
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno = 0;
            int datoInt;
            if (int.TryParse(dato, out datoInt) && dato.Length <= 8)
            {
                retorno = ValidarDni(nacionalidad, datoInt);
            }
            else { throw new DniInvalidoException(); }

            return retorno;
        }

        private string ValidarNombreApellido(string dato)
        {
            string auxiliar = "";
            foreach (char letra in dato)
            {
                if (char.IsLetter(letra) && !char.IsWhiteSpace(letra))
                {
                    auxiliar = dato;
                }
            }
            return auxiliar;
        }

        public new string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre : {0}", nombre);
            sb.AppendFormat("Apellido : {0}", apellido);
            sb.AppendFormat("DNI : {0}", dni);
            sb.AppendFormat("Nacionalidad : {0}", nacionalidad);

            return sb.ToString();

        }
        #endregion





        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
    }
}
