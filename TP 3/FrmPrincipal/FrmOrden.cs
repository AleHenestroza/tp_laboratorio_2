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

        /// <summary>
        /// Verifica que haya stock para crear las bicicletas requeridas
        /// </summary>
        /// <param name="cantMaterial"></param>
        /// <param name="material"></param>
        /// <returns></returns>
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

        /// <summary>
        /// En base al material ingresado, llama al método apropiado con el parámetro
        /// de material correcto. En caso de 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="cantidad"></param>
        /// <param name="rodado"></param>
        /// <param name="cuadro"></param>
        /// <param name="esMountainBike"></param>
        /// <returns></returns>
        private bool OrdenarBicicletas(string material, int cantidad, double rodado, double cuadro, bool esMountainBike)
        {
            bool ordenCreada = false;
            bool materialAgotado = true;
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
                        if (Fabrica.StockAcero - cantidad * cuadro > 0) materialAgotado = false;
                        break;
                    case "Aluminio":
                        this.orden.OrdenarBicicletas<Aluminio>(
                            cantidad,
                            rueda,
                            rueda,
                            cuadro,
                            this.chkCambios.Checked,
                            esMountainBike);
                        if (Fabrica.StockAluminio - cantidad * cuadro > 0) materialAgotado = false;
                        break;
                    case "Titanio":
                        this.orden.OrdenarBicicletas<Titanio>(
                            cantidad,
                            rueda,
                            rueda,
                            cuadro,
                            this.chkCambios.Checked,
                            esMountainBike);
                        if (Fabrica.StockTitanio - cantidad * cuadro > 0) materialAgotado = false;
                        break;
                    case "Fibra de Carbono":
                        this.orden.OrdenarBicicletas<FibraCarbono>(
                            cantidad,
                            rueda,
                            rueda,
                            cuadro,
                            this.chkCambios.Checked,
                            esMountainBike);
                        if (Fabrica.StockFibraCarbono - cantidad * cuadro > 0) materialAgotado = false;
                        break;
                }
                ordenCreada = true;
            }
            if (materialAgotado)
            {
                this.orden = null;
                MessageBox.Show("Se ha utilizado todo el material disponible o más,\n" +
                    "para seguir produciendo órdenes se debe agregar más material.");
                ordenCreada = false;
            }
            return ordenCreada;
            
        }

        /// <summary>
        /// Captura los datos ingresados en el formulario y llama a las funciones
        /// de ordenar bicicletas y accesorios, en caso de que se hayan solicitado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            bool ordenCreadaMB = false;
            string materialMB = "";
            int cantidadMB = 0;
            double cuadroMB = 0;
            string materialP = "";
            int cantidadP = 0;
            double cuadroP = 0;
            bool ordenCreadaP = false;
            bool ordenCreadaAcc = false;
            if (this.cmbRodadoMB.Text != ""
                && this.cmbCuadroMB.Text != ""
                && this.cmbMaterialMB.Text != ""
                && this.numUDMountainBike.Value > 0
                && this.orden != null)
            {
                materialMB = this.cmbMaterialMB.Text;
                cantidadMB = (int)this.numUDMountainBike.Value;
                double rodado;
                if(!double.TryParse(this.cmbRodadoMB.Text, out rodado) 
                    || !double.TryParse(this.cmbCuadroMB.Text, out cuadroMB))
                {
                    MessageBox.Show("Hubo un error");
                    this.Close();
                } else
                {
                    bool esMountainBike = true;
                    ordenCreadaMB = this.OrdenarBicicletas(materialMB, cantidadMB, rodado, cuadroMB, esMountainBike);
                }
            }
            if (this.cmbRodadoP.Text != ""
                && this.cmbCuadroP.Text != ""
                && this.cmbMaterialP.Text != ""
                && this.numUDPlayera.Value > 0
                && this.orden != null)
            {
                materialP = this.cmbMaterialP.Text;
                cantidadP = (int)this.numUDPlayera.Value;
                double rodado;
                if (!double.TryParse(this.cmbRodadoP.Text, out rodado)
                    || !double.TryParse(this.cmbCuadroP.Text, out cuadroP))
                {
                    MessageBox.Show("Hubo un error");
                    this.Close();
                }
                else
                {
                    bool esMountainBike = false;
                    ordenCreadaP = this.OrdenarBicicletas(materialP, cantidadP, rodado, cuadroP, esMountainBike);
                }
            }
            int cantCascos = (int)this.numUDCasco.Value;
            int cantLuz = (int)this.numUDLuz.Value;
            if ((cantCascos > 0 || cantLuz > 0) && this.orden != null)
            {
                double talle;
                if(!double.TryParse(this.cmbTalleCasco.Text, out talle))
                {
                    cantCascos = 0;
                    talle = 0;
                }
                if (this.cmbColorLuz.Text == "") cantLuz = 0;
                this.orden.OrdenarAccesorios(cantCascos, cantLuz, talle, this.cmbColorLuz.Text);
                ordenCreadaAcc = true;
            }
            
            if (this.orden != null && (ordenCreadaMB || ordenCreadaP || ordenCreadaAcc))
            {
                if (ordenCreadaMB)
                {
                    Fabrica.ModificarStockMaterial(cantidadMB * cuadroMB * -1, materialMB);
                }
                if (ordenCreadaP)
                {
                    Fabrica.ModificarStockMaterial(cantidadP * cuadroP * -1, materialP);
                }
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
