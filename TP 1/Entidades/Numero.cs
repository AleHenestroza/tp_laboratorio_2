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
            this.numero = ValidarNumero(strNumero);
        }
        #endregion

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
    }
}
