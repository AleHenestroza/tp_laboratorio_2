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
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Muestra los datos de los costos en los RichTextBox del form
        /// </summary>
        private void ActualizarDatos()
        {
            this.numAcero.Value = (decimal)Costos.CostoAcero;
            this.numAluminio.Value = (decimal)Costos.CostoAluminio;
            this.numTitanio.Value = (decimal)Costos.CostoTitanio;
            this.numCarbono.Value = (decimal)Costos.CostoCarbono;
            this.numRueda.Value = (decimal)Costos.CostoRueda;
            this.numCasco.Value = (decimal)Costos.CostoCasco;
            this.numLuz.Value = (decimal)Costos.CostoLuz;
        }
        /// <summary>
        /// Llama al método ActualizarDatos al cargar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDatos_Load(object sender, EventArgs e)
        {
            this.ActualizarDatos();
        }
        /// <summary>
        /// Se modifican los costos en la clase estática y se realiza el Update en la Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Costos.CostoAcero = (double)this.numAcero.Value;
            Costos.CostoAluminio = (double)this.numAluminio.Value;
            Costos.CostoTitanio = (double)this.numTitanio.Value;
            Costos.CostoCarbono = (double)this.numCarbono.Value;
            Costos.CostoRueda = (double)this.numRueda.Value;
            Costos.CostoCasco = (double)this.numCasco.Value;
            Costos.CostoLuz = (double)this.numLuz.Value;
            Costos.UpdateCostos();
            this.ActualizarDatos();
        }
    }
}
