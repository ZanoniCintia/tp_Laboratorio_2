using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// valida los operadores recibidos + - * /, caso contrario retorna +
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOperador(string operador)
        {
            string signo = "+";

            if (operador == "-")
            {
                signo = "-";
            }
            else if (operador == "/")
            {
                signo = "/";
            }
            else if (operador == "*")
            {
                signo = "*";
            }

            return signo;
        }

        /// <summary>
        /// valida y realiza la operacion ingresada entre ambos numeros
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;

            if (num1 != null && num2 != null)
            {
                switch (ValidarOperador(operador))
                {
                    case "-":
                        retorno = num1 - num2;
                        break;
                    case "+":
                        retorno = num1 + num2;
                        break;
                    case "/":
                        retorno = num1 / num2;
                        break;
                    case "*":
                        retorno = num1 * num2;
                        break;
                }
            }
            return retorno;
        }

    }
}
