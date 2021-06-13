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

namespace FrmPrincipal
{
    public partial class FrmAgregarStock : Form
    {
        public FrmAgregarStock()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double acero = (double)this.numericUpDownAcero.Value;
            double aluminio = (double)this.numericUpDownAluminio.Value;
            double titanio = (double)this.numericUpDownTitanio.Value;
            double fibraCarbono = (double)this.numericUpDownFibraCarbono.Value;
            Fabrica.ModificarStockMateriales(acero, aluminio, titanio, fibraCarbono);

            MessageBox.Show("Materiales agregados.");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAgregarStock_Load(object sender, EventArgs e)
        {
            this.richTextBoxAcero.Text = Fabrica.StockAcero.ToString();
            this.richTextBoxAluminio.Text = Fabrica.StockAluminio.ToString();
            this.richTextBoxTitanio.Text = Fabrica.StockTitanio.ToString();
            this.richTextBoxFibraCarbono.Text = Fabrica.StockFibraCarbono.ToString();
        }
    }
}
