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
        private Orden orden;
        public Orden Orden
        {
            get
            {
                return this.orden;
            }
        }
        public FrmOrden()
        {
            InitializeComponent();
            this.orden = new Orden();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.orden = null;
            this.Close();
        }

        private static bool VerificarStock(double cantMaterial, string material)
        {
            double stockMaterial;
            switch (material)
            {
                case "Acero":
                    stockMaterial = Fabrica.StockAcero;
                    break;
                case "Aluminio":
                    stockMaterial = Fabrica.StockAluminio;
                    break;
                case "Titanio":
                    stockMaterial = Fabrica.StockTitanio;
                    break;
                case "Fibra de Carbono":
                    stockMaterial = Fabrica.StockFibraCarbono;
                    break;
                default:
                    stockMaterial = 0;
                    break;
            }
            return stockMaterial > cantMaterial;
        }

        private bool OrdenarBicicletas(string material, int cantidad, double rodado, double cuadro, bool esMountainBike)
        {
            bool ordenCreada = false;
            bool materialAgotado = false;
            Rueda rueda = new Rueda(rodado);
            if (VerificarStock(cantidad * cuadro, material))
            {
                switch (material)
                {
                    case "Acero":
                        this.orden.OrdenarBicicletas<Acero>(
                            cantidad,
                            rueda,
                            rueda,
                            cuadro,
                            this.chkCambios.Checked,
                            esMountainBike);
                        if (Fabrica.StockAcero - cantidad * cuadro < 0) materialAgotado = true;
                        break;
                    case "Aluminio":
                        this.orden.OrdenarBicicletas<Aluminio>(
                            cantidad,
                            rueda,
                            rueda,
                            cuadro,
                            this.chkCambios.Checked,
                            esMountainBike);
                        if (Fabrica.StockAluminio - cantidad * cuadro < 0) materialAgotado = true;
                        break;
                    case "Titanio":
                        this.orden.OrdenarBicicletas<Titanio>(
                            cantidad,
                            rueda,
                            rueda,
                            cuadro,
                            this.chkCambios.Checked,
                            esMountainBike);
                        if (Fabrica.StockTitanio - cantidad * cuadro < 0) materialAgotado = true;
                        break;
                    case "Fibra de Carbono":
                        this.orden.OrdenarBicicletas<FibraCarbono>(
                            cantidad,
                            rueda,
                            rueda,
                            cuadro,
                            this.chkCambios.Checked,
                            esMountainBike);
                        if (Fabrica.StockFibraCarbono - cantidad * cuadro < 0) materialAgotado = true;
                        break;
                }
                ordenCreada = true;
            }
            if (materialAgotado)
            {
                this.orden = null;
                MessageBox.Show("Se ha utilizado todo el material disponible o más,\n" +
                    "para seguir produciendo órdenes se debe agregar más material.");
                this.Close();
            }
            else
            {
                Fabrica.ModificarStockMaterial(cantidad * cuadro * -1, material);
            }
            return ordenCreada;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            bool ordenCreada = false;
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
                    bool esMountainBike = true;
                    ordenCreada = this.OrdenarBicicletas(material, cantidad, rodado, cuadro, esMountainBike);
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
                    bool esMountainBike = false;
                    ordenCreada = this.OrdenarBicicletas(material, cantidad, rodado, cuadro, esMountainBike);
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
                ordenCreada = true;
            }
            
            if (ordenCreada)
            {
                MessageBox.Show("Orden creada");
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay suficiente stock de material para esta orden");
                this.orden = null;
                this.Close();
            }
        }
    }
}
