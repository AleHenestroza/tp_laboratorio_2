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
            this.cmbOperador.Text = "\0";
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado = Calculadora.Operar(new Numero(numero1), new Numero(numero2), operador);
            return resultado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            this.lblResultado.Text = resultado.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
