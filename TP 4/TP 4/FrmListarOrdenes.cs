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
using Entidades.Orden;

namespace TP_4
{
    public partial class FrmListarOrdenes : Form
    {
        public FrmListarOrdenes()
        {
            InitializeComponent();
            MostrarOrdenes();
        }

        private void MostrarOrdenes()
        {
            this.listOrdenes.Items.Clear();
            for (int i = 0; i < Fabrica.ListadoOrdenes.ListadoOrdenes.Count; i++)
            {
                this.listOrdenes.Items.Add("Orden N° " + (i + 1));
            }
        }

        private void listOrdenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.listOrdenes.SelectedIndex;
            this.rtbOrden.Text = Fabrica.ListadoOrdenes.ListadoOrdenes[index].MostrarOrden();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Fabrica.LimpiarOrdenes();
            MostrarOrdenes();
        }
    }
}
