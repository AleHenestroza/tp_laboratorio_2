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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGenerarOrden_Click(object sender, EventArgs e)
        {
            Orden nuevaOrden = new Orden();
            FrmOrden formOrden = new FrmOrden(nuevaOrden);
            formOrden.ShowDialog();
            Fabrica.AgregarOrden(nuevaOrden);
            
            // Console.WriteLine(nuevaOrden.ToString());
        }

        private void btnListarOrdenes_Click(object sender, EventArgs e)
        {
            FrmListadoOrdenes formListado = new FrmListadoOrdenes(Fabrica.ListadoOrdenes);
            formListado.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (Fabrica.ListadoOrdenes.Count > 0)
            {
                Fabrica.ImprimirArchivos();
                MessageBox.Show("Archivos guardados");
            }
            else
            {
                MessageBox.Show("No hay órdenes creadas");
            }
        }
    }
}
