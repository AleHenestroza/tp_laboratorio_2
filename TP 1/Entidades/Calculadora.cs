using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Recibe dos objetos Numero como parámetros y una string con el operador.
        /// Tras validar el operador, retorna la operación correspondiente.
        /// En caso de que el operador sea un caracter inválido, por defecto realiza una suma.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            char chOperador;
            string op;
            // En caso de que el usuario intente operar y el operador sea null
            if (!char.TryParse(operador, out chOperador))
            {
                chOperador = '+';
            }
            op = ValidarOperador(chOperador);
            switch (op)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                default:
                    return num1 + num2;
            }
        }

        /// <summary>
        /// Valida que el caracter operador corresponda a una suma, resta, multiplicación o división y retorna
        /// el mismo caracter como string.
        /// En caso de que el operador sea inválido, retorna una string con el operador +
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador.ToString();
            }
            return "+";
        }
    }
}
