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

        #region CONSTRUCTORES
        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Valida que la string pasada contenga únicamente caracteres numéricos y retorna
        /// un double con el valor. En caso contrario, retorna 0
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarNumero(string strNumero)
        {
            double numero;
            if (Double.TryParse(strNumero, out numero))
            {
                return numero;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Propiedad para asignar un valor numérico dentro de una string al campo numero
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        
        /// <summary>
        ///  Verifica que una string contenga únicamente los caracteres '0' y '1'. Retorna true
        ///  en caso de verificar, false en caso contrario.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            foreach(char digito in binario) {
                if (digito != '0' && digito != '1')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Toma una string. Tras validar si la string contiene un número binario, convierte el mismo
        /// a base 10 y retorna una string con el valor decimal.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string numDecimal = "Valor inválido";
            if(binario.Equals(""))
            {
                return numDecimal;
            }
            if(binario[0] == '-')
            {
                binario = binario.Substring(1);
            }
            if(EsBinario(binario))
            {
                int digitoBinarioADecimal = 0;
                int contadorDigitos = 0;
                for (int i = binario.Length - 1; i >= 0; i--)
                {
                    int digitoBinario = int.Parse(binario[i].ToString());
                    digitoBinarioADecimal += digitoBinario * (int)Math.Pow(2, contadorDigitos);
                    contadorDigitos++;
                }
                numDecimal = digitoBinarioADecimal.ToString();
            }
            return numDecimal;
        }

        /// <summary>
        /// Recibe un número y crea una string con su conversión a base 2. Retorna la string.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            string numBinario = "";
            if (numero > int.MaxValue || numero < int.MinValue)
            {
                numBinario = "Valor inválido";
            }
            else
            {
                int numeroEntero = (int) Math.Abs(numero);
                if (numeroEntero == 0)
                {
                    // En caso de que el número sea menor a 1, el while siguiente no se ejecutaría
                    // Por eso, se debe asignar el valor de la string de retorno en 0
                    // Ya que el número es 0.x y su parte entera es 0
                    numBinario = "0";
                }
                while (numeroEntero >= 1)
                {
                    int resto = numeroEntero % 2;
                    numeroEntero = (int) Math.Floor(numeroEntero / 2d);
                    numBinario = resto.ToString() + numBinario;
                }
            }
            return numBinario;
        }

        /// <summary>
        /// Recibe una string. Si puede ser parseada a un número, el mismo es convertido
        /// a binario, llamando al método DecimalBinario(double numero). Retorna la string
        /// con el número binario que devuelva el método.
        /// En caso de que la string no pueda ser parseada, retorna "Valor inválido"
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            double num;
            if (double.TryParse(numero, out num))
            {
                return DecimalBinario(num);
            }
            return "Valor inválido";
        }
        #endregion

        #region OPERADORES
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }
        #endregion
    }
}
