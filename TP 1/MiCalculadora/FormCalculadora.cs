using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            // Con esto hago que la lista de operadores comienze con el primer operador ya seleccionado
            this.cmbOperador.SelectedIndex = 0;
            // El label lo seteo en blanco en esta línea, de lo contrario, dejarle el Text en blanco dificultaba
            // encontrarlo en el Diseño del formulario.
            this.lblResultado.Text = "";
        }

        /// <summary>
        /// Deja los dos TextBox, el ComboBox de operadores y el Label de resultado en blanco.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "";
            this.cmbOperador.Text = "";
        }

        /// <summary>
        /// Recibe dos strings con valores numéricos y una string con el operador y retorna la el resultado
        /// de la operación correspondiente.
        /// En caso de que uno de los campos numéricos esté vacío, el mismo se tomará en cuenta con un valor
        /// de 0.
        /// En caso de que el operador sea una string vacía, se realizará por defecto una suma.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            double resultado = Calculadora.Operar(num1, num2, operador);
            return resultado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            // La consigna indicaba que en caso de una división por 0, se debía retornar double.MinValue,
            // por lo que en caso de que se divida por 0, o el segundo campo quede vacío, el resultado
            // va a ser -1.7976931348623157E+308
            this.lblResultado.Text = resultado.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            // No considero necesario validar si el lblResultado tiene o no texto, ya que
            // el método DecimalBinario (y BinarioDecimal) validan en primer lugar que la string
            // que se le pase como atributo sea válida.
            // En caso de ser vacía, ambos métodos retornan "Valor inválido"
            Numero binario = new Numero(lblResultado.Text);
            lblResultado.Text = binario.DecimalBinario(lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numeroDecimal = new Numero(lblResultado.Text);
            lblResultado.Text = numeroDecimal.BinarioDecimal(lblResultado.Text);
        }
    }
}
