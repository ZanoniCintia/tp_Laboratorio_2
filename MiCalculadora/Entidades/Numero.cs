using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public string SetNumero
        {

            set { numero = ValidarNumero(value); }
        }

        #region constructores


        /// <summary>
        /// Constructor asigna 0 al atributo numero
        /// </summary>
        public Numero()
        {
            numero = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// recibe un string y lo convierte en double
        /// </summary>
        /// <param name="strNum"></param>
        public Numero(string strNum)
        {
            double.TryParse(strNum, out numero);
        }



        /// <summary>
        /// valida que el numero ingresado sea numerico,retorna un double, caso contrario un 0
        /// </summary>
        /// <param name="StrNumero"></param>
        /// <returns></returns>
        private static double ValidarNumero(string StrNumero)
        {
            double retorno;
            if (!double.TryParse(StrNumero, out retorno))
            {
                retorno = 0;
            }
            return retorno;
        }
        #endregion

        #region Operadores

        /// <summary>
        /// retorna la diferencia entre n1 y n2
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }

        /// <summary>
        /// retorna la suma de n1 y n2
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return (n1.numero + n2.numero);
        }

        /// <summary>
        /// retorna la multiplicacion entre n1 y n2
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return (n1.numero * n2.numero);
        }

        /// <summary>
        /// si n2 es distinto de cero retorna la division entre n1 y n2, de lo contrario retorna double.MinValue
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = double.MinValue;
            if (n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
            }

            return retorno;
        }


        #endregion

        #region Conversores

        /// <summary>
        /// convierte un numero binario a decimal. caso contrario retorna invalido
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
           for(int i=0;i<binario.Length;i++)
            {
                if(binario[i]!='0'&& binario[i]!='1')
                {
                    return "valor invalido";
                }
            }
           return Convert.ToInt32(binario, 2).ToString();
        }

        /// <summary>
        /// /recibe un string , convierte un decimal en binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
             string retorno = "valor invalido";
            if(int.Parse(numero)>0 && int.Parse(numero)<256)
            {
                retorno= DecimalBinario(double.Parse(numero));
            }
            return retorno;
            
        }

        /// <summary>
        /// recibe un double, convierte un decimal en binario, reutiliza codigo anterior
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
          
            string resultado = "";

            do
            {
                resultado = (numero % 2) + resultado;
                numero = (int)numero / 2;
            } while (numero > 0);
           
            return resultado;
            
           // return DecimalBinario(numero.ToString());
        }


        #endregion
    }
}

