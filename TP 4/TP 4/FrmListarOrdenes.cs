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
using Entidades.DAO.Orden;

namespace TP_4
{
    public partial class FrmListarOrdenes : Form
    {
        private List<Orden> listadoOrdenes;
        private Orden ordenSeleccionada;
        public FrmListarOrdenes()
        {
            InitializeComponent();
            this.listadoOrdenes = Fabrica.ListadoOrdenes.ListadoOrdenes;
            MostrarOrdenes();
        }

        private void MostrarOrdenes()
        {
            this.listOrdenes.Items.Clear();
            for (int i = 0; i < this.listadoOrdenes.Count; i++)
            {
                this.listOrdenes.Items.Add("Orden N° " + (i + 1));
            }
        }

        private void listOrdenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.listOrdenes.SelectedIndex;
            this.ordenSeleccionada = this.listadoOrdenes[index];
            this.rtbOrden.Text = this.ordenSeleccionada.MostrarOrden();
            this.btnDeleteOrden.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Fabrica.LimpiarOrdenes();
            MostrarOrdenes();
        }

        private void btnDeleteOrden_Click(object sender, EventArgs e)
        {
            if (ordenSeleccionada != null)
            {
                OrdenDAO ordenDAO = new OrdenDAO();
                this.listadoOrdenes.Remove(this.ordenSeleccionada);
                try
                {
                    ordenDAO.DeleteOrden(this.ordenSeleccionada.Id);
                }
                catch
                {
                    MessageBox.Show("Se eliminó la orden del listado actualmente cargado, pero la orden no estaba guardada en la BD.");
                }
                MostrarOrdenes();
            }
        }
    }
}
