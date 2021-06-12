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
    public partial class FrmListadoOrdenes : Form
    {
        List<Orden> listadoOrdenes;
        public FrmListadoOrdenes(List<Orden> listadoOrdenes)
        {
            InitializeComponent();
            this.listadoOrdenes = listadoOrdenes;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListadoOrdenes_Load(object sender, EventArgs e)
        {
            string ordenes = "";
            foreach (Orden o in listadoOrdenes)
            {
                ordenes += o.ToString();
            }
            this.rtbOrdenes.Text = ordenes;
        }
    }
}
