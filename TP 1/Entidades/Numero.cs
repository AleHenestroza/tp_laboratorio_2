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

        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }
        
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

        public string DecimalBinario(string numero)
        {
            double num;
            if (double.TryParse(numero, out num))
            {
                return DecimalBinario(num);
            }
            return "Ingreso invalido";
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
