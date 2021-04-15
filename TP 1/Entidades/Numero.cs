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
            foreach(char letra in binario) {
                if (letra != '0' && letra != '1')
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
            if (EsBinario(binario))
            {
                int numDecimal = 0;
                for(int i = 0; i < binario.Length; i++)
                {
                    int digito = Int32.Parse( binario[binario.Length - (i + 1)].ToString() ) * (int) Math.Pow( 2, i);
                    numDecimal += digito;
                }
                return numDecimal.ToString();
            }
            return "Valor inválido";
        }

        /// <summary>
        /// Recibe un número y crea una string con su conversión a base 2. Retorna la string.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            string numBinario = "";
            double num = numero;
            while (num >= 1)
            {
                double resto = num % 2;
                num = Math.Floor(num / 2);
                numBinario = resto.ToString() + numBinario;
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
