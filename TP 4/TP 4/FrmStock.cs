using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Datos;

namespace TP_4
{
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Asigna los valores del Stock a los RichTextBox del formulario
        /// </summary>
        private void ActualizarStock()
        {
            this.rtbStockAcero.Text = Stock.CantAcero.ToString();
            this.rtbStockAluminio.Text = Stock.CantAluminio.ToString();
            this.rtbStockTitanio.Text = Stock.CantTitanio.ToString();
            this.rtbStockCarbono.Text = Stock.CantCarbono.ToString();
        }
        /// <summary>
        /// Al cargar el formulario, debe cargar los valores del Stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStock_Load(object sender, EventArgs e)
        {
            this.ActualizarStock();
        }
        /// <summary>
        /// Modifica el Stock en la clase estática y llama al método Update para modificarlos en la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Stock.CantAcero += (double)this.numAcero.Value;
            Stock.CantAluminio += (double)this.numAluminio.Value;
            Stock.CantTitanio += (double)this.numTitanio.Value;
            Stock.CantCarbono += (double)this.numCarbono.Value;
            Stock.UpdateStock();

            this.ActualizarStock();
        }
    }
}
