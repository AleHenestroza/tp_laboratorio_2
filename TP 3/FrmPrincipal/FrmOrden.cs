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
using Entidades.Productos.Componentes;
using Entidades.Productos.Accesorios;
using Entidades.Productos.Materiales;

namespace FrmPrincipal
{
    public partial class FrmOrden : Form
    {
        Orden orden;
        public FrmOrden(Orden orden)
        {
            InitializeComponent();
            this.orden = orden;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.orden = null;
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Este código es demasiado repetitivo, ver si se puede
            // simplificar
            if (this.cmbRodadoMB.Text != ""
                && this.cmbCuadroMB.Text != ""
                && this.cmbMaterialMB.Text != ""
                && this.numUDMountainBike.Value > 0)
            {
                string material = this.cmbMaterialMB.Text;
                int cantidad = (int)this.numUDMountainBike.Value;
                double rodado;
                double cuadro;
                if(!double.TryParse(this.cmbRodadoMB.Text, out rodado) 
                    || !double.TryParse(this.cmbCuadroMB.Text, out cuadro))
                {
                    MessageBox.Show("Hubo un error");
                    this.Close();
                } else
                {
                    Rueda rueda = new Rueda(rodado);
                    switch (material)
                    {
                        case "Acero":
                            this.orden.OrdenarBicicletasMountainBike<Acero>(
                                cantidad,
                                rueda,
                                rueda,
                                cuadro,
                                this.chkCambios.Checked);
                            break;
                        case "Aluminio":
                            this.orden.OrdenarBicicletasMountainBike<Aluminio>(
                                cantidad,
                                rueda,
                                rueda,
                                cuadro,
                                this.chkCambios.Checked);
                            break;
                        case "Titanio":
                            this.orden.OrdenarBicicletasMountainBike<Titanio>(
                                cantidad,
                                rueda,
                                rueda,
                                cuadro,
                                this.chkCambios.Checked);
                            break;
                        case "Fibra de Carbono":
                            this.orden.OrdenarBicicletasMountainBike<FibraCarbono>(
                                cantidad,
                                rueda,
                                rueda,
                                cuadro,
                                this.chkCambios.Checked);
                            break;
                    }
                }
            }
            if (this.cmbRodadoP.Text != ""
                && this.cmbCuadroP.Text != ""
                && this.cmbMaterialP.Text != ""
                && this.numUDPlayera.Value > 0)
            {
                string material = this.cmbMaterialP.Text;
                int cantidad = (int)this.numUDPlayera.Value;
                double rodado;
                double cuadro;
                if (!double.TryParse(this.cmbRodadoP.Text, out rodado)
                    || !double.TryParse(this.cmbCuadroP.Text, out cuadro))
                {
                    MessageBox.Show("Hubo un error");
                    this.Close();
                }
                else
                {
                    Rueda rueda = new Rueda(rodado);
                    switch (material)
                    {
                        case "Acero":
                            this.orden.OrdenarBicicletasPlayeras<Acero>(
                                cantidad,
                                rueda,
                                rueda,
                                cuadro,
                                this.chkFrenos.Checked);
                            break;
                        case "Aluminio":
                            this.orden.OrdenarBicicletasPlayeras<Aluminio>(
                                cantidad,
                                rueda,
                                rueda,
                                cuadro,
                                this.chkFrenos.Checked);
                            break;
                        case "Titanio":
                            this.orden.OrdenarBicicletasPlayeras<Titanio>(
                                cantidad,
                                rueda,
                                rueda,
                                cuadro,
                                this.chkFrenos.Checked);
                            break;
                        case "Fibra de Carbono":
                            this.orden.OrdenarBicicletasPlayeras<FibraCarbono>(
                                cantidad,
                                rueda,
                                rueda,
                                cuadro,
                                this.chkFrenos.Checked);
                            break;
                    }
                }
            }
            int cantCascos = (int)this.numUDCasco.Value;
            int cantLuz = (int)this.numUDLuz.Value;
            if (cantCascos > 0 || cantLuz > 0)
            {
                double talle;
                if(!double.TryParse(this.cmbTalleCasco.Text, out talle))
                {
                    cantCascos = 0;
                    talle = 0;
                }
                if (this.cmbColorLuz.Text == "") cantLuz = 0;
                this.orden.OrdenarAccesorios(cantCascos, cantLuz, talle, this.cmbColorLuz.Text);
            }
            this.Close();
        }
    }
}
