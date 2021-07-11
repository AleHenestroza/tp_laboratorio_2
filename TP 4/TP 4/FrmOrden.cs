using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using Entidades.Datos;
using Entidades.Productos.Accesorios;
using Entidades.Productos.Bicicletas;
using Entidades.Productos.Materiales;
using Entidades.Productos.Componentes;
using Entidades.Excepciones;
using Entidades.Orden;
using Entidades;
using Entidades.DAO.Accesorios;
using Entidades.DAO.Bicicletas;

namespace TP_4
{
    public partial class FrmOrden : Form
    {
        private IBicicleta mountainBike;
        private IBicicleta playera;
        private IFabricable casco;
        private IFabricable luz;
        private Orden nuevaOrden;

        public FrmOrden()
        {
            InitializeComponent();
            this.mountainBike = null;
            this.playera = null;
            this.casco = null;
            this.luz = null;
            this.nuevaOrden = new Orden();
        }

        private void chkMountainBike_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.splitBicicletas.Visible)
            {
                this.splitBicicletas.Visible = true;

            }
            this.splitBicicletas.Panel1.Enabled = !this.splitBicicletas.Panel1.Enabled;
        }
        private void chkPlayera_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.splitBicicletas.Visible)
            {
                this.splitBicicletas.Visible = true;

            }
            this.splitBicicletas.Panel2.Enabled = !this.splitBicicletas.Panel2.Enabled;
        }
        private void chkCasco_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.splitAccesorios.Visible)
            {
                this.splitAccesorios.Visible = true;

            }
            this.splitAccesorios.Panel1.Enabled = !this.splitAccesorios.Panel1.Enabled;
        }
        private void chkLuz_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.splitAccesorios.Visible)
            {
                this.splitAccesorios.Visible = true;

            }
            this.splitAccesorios.Panel2.Enabled = !this.splitAccesorios.Panel2.Enabled;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.chkMountainBike.Checked) AgregarMountainBike();
                if (this.chkPlayera.Checked) AgregarPlayera();
                if (this.chkCasco.Checked) AgregarCasco();
                if (this.chkLuz.Checked) AgregarLuz();

                int cantidadMB = (int)this.numCantidad.Value;
                int cantidadP = (int)this.numCantidadPlayera.Value;
                int cantidadCasco = (int)this.numCantidadCasco.Value;
                int cantidadLuz = (int)this.numCantidadLuz.Value;

                if (cantidadMB == 0 && cantidadP == 0 && cantidadCasco == 0 && cantidadLuz == 0)
                {
                    throw new CamposInvalidosException("No se ha creado la orden ya que no se ha indicado\ncantidad de ningún producto.");
                }
                else
                {
                    this.nuevaOrden.BicicletaMB = this.mountainBike;
                    this.nuevaOrden.CantidadMB = cantidadMB;
                    this.nuevaOrden.BicicletaP = this.playera;
                    this.nuevaOrden.CantidadP = cantidadP;
                    this.nuevaOrden.Casco = this.casco;
                    this.nuevaOrden.CantidadCascos = cantidadCasco;
                    this.nuevaOrden.Luz = this.luz;
                    this.nuevaOrden.CantidadLuces = cantidadLuz;

                    this.nuevaOrden.RecalcularCosto(); // Tras agregar los productos en la orden, se debe actualizar el costo de la misma antes de guardarla

                    Fabrica.AgregarOrden(this.nuevaOrden); // Agregar Orden puede lanzar una excepción si no hay suficiente stock
                    this.nuevaOrden.InsertOrden();

                    MessageBox.Show("Orden creada:\n\n" + this.nuevaOrden.MostrarOrden());
                    this.Close();
                }
            }
            catch (CamposInvalidosException ex)
            {
                MessageBox.Show("Error\n" + ex.Message);
            }
            catch (StockInsuficienteException ex)
            {
                MessageBox.Show("Error\n" + ex.Message);
            }
        }
        private void AgregarMountainBike()
        {
            try
            {
                if (this.numCantidad.Value != 0)
                {
                    // Si no se completaron todos los campos, se lanzará una excepción.
                    if (this.cmbRodado.Text == "" || this.cmbCuadro.Text == "" || this.cmbMaterial.Text == "") throw new Exception();

                    Rueda rueda1 = new Rueda(double.Parse(this.cmbRodado.Text));
                    Rueda rueda2 = new Rueda(double.Parse(this.cmbRodado.Text));
                    double tamanioCuadro = double.Parse(this.cmbCuadro.Text);
                    bool cambios = this.chkCambios.Checked;

                    switch (this.cmbMaterial.Text)
                    {
                        case "Acero":
                            this.mountainBike = new MountainBike<Acero>(rueda1, rueda2, tamanioCuadro, cambios);
                            break;
                        case "Aluminio":
                            this.mountainBike = new MountainBike<Aluminio>(rueda1, rueda2, tamanioCuadro, cambios);
                            break;
                        case "Titanio":
                            this.mountainBike = new MountainBike<Titanio>(rueda1, rueda2, tamanioCuadro, cambios);
                            break;
                        case "Fibra de Carbono":
                            this.mountainBike = new MountainBike<FibraCarbono>(rueda1, rueda2, tamanioCuadro, cambios);
                            break;
                    }
                    this.nuevaOrden.OrdenCreada += InsertMountainBike;
                }
            }
            catch
            {
                // Si se lanzó una excepción, es porque quedaron campos incompletos.
                throw new CamposInvalidosException("Quedaron campos incompletos en Mountain Bike.");
            }
        }
        private void InsertMountainBike(Orden orden)
        {
            MountainBikeDAO mbDAO = new MountainBikeDAO();
            mbDAO.InsertMountainBike(this.mountainBike.GetRodado(),
                                     this.mountainBike.GetTamanioCuadro(),
                                     this.mountainBike.MaterialNecesario(),
                                     this.mountainBike.CalcularCosto(),
                                     this.mountainBike.GetCaraceristica(),
                                     this.nuevaOrden.Id,
                                     this.nuevaOrden.CantidadMB);
        }
        private void AgregarPlayera()
        {
            try
            {
                if (this.numCantidadPlayera.Value != 0)
                {
                    // Si no se completaron todos los campos, se lanzará una excepción.
                    if (this.cmbRodadoPlayera.Text == "" || this.cmbCuadroPlayera.Text == "" || this.cmbMaterialPlayera.Text == "") throw new Exception();

                    Rueda rueda1 = new Rueda(double.Parse(this.cmbRodadoPlayera.Text));
                    Rueda rueda2 = new Rueda(double.Parse(this.cmbRodadoPlayera.Text));
                    double tamanioCuadro = double.Parse(this.cmbCuadroPlayera.Text);
                    bool frenos = this.chkFreno.Checked;

                    switch (this.cmbMaterialPlayera.Text)
                    {
                        case "Acero":
                            this.playera = new Playera<Acero>(rueda1, rueda2, tamanioCuadro, frenos);
                            break;
                        case "Aluminio":
                            this.playera = new Playera<Aluminio>(rueda1, rueda2, tamanioCuadro, frenos);
                            break;
                        case "Titanio":
                            this.playera = new Playera<Titanio>(rueda1, rueda2, tamanioCuadro, frenos);
                            break;
                        case "Fibra de Carbono":
                            this.playera = new Playera<FibraCarbono>(rueda1, rueda2, tamanioCuadro, frenos);
                            break;
                    }

                    this.nuevaOrden.OrdenCreada += InsertPlayera;
                }
            }
            catch
            {
                // Si se lanzó una excepción, es porque quedaron campos incompletos.
                throw new CamposInvalidosException("Quedaron campos incompletos en Playera.");
            }
        }
        private void InsertPlayera(Orden orden)
        {
            PlayeraDAO pDAO = new PlayeraDAO();
            pDAO.InsertPlayera(this.playera.GetRodado(),
                               this.playera.GetTamanioCuadro(),
                               this.playera.MaterialNecesario(),
                               this.playera.CalcularCosto(),
                               this.playera.GetCaraceristica(),
                               this.nuevaOrden.Id,
                               this.nuevaOrden.CantidadP);
        }
        private void AgregarCasco()
        {
            try
            {
                if (this.numCantidadCasco.Value != 0)
                {
                    // Si no se completaron todos los campos, se lanzará una excepción.
                    if (this.cmbTalleCasco.Text == "") throw new Exception();
                    double talle = double.Parse(this.cmbTalleCasco.Text);
                    this.casco = new Casco(talle);
                    this.nuevaOrden.OrdenCreada += InsertCasco; // Suscribo el método manejador al evento.
                }
            }
            catch
            {
                // Si se lanzó una excepción, es porque quedaron campos incompletos.
                throw new CamposInvalidosException("Quedaron campos incompletos en Casco.");
            }
        }
        private void InsertCasco(Orden orden)
        {
            CascoDAO cascoDAO = new CascoDAO();
            cascoDAO.InsertCascos(orden.Id,
                                  orden.CantidadCascos,
                                  orden.Casco.CalcularCosto(),
                                  ((Casco)orden.Casco).Talla);
        }
        private void AgregarLuz()
        {
            try
            {
                if (this.numCantidadLuz.Value != 0)
                {
                    // Si no se completaron todos los campos, se lanzará una excepción.
                    if (this.cmbColorLuz.Text == "") throw new Exception();
                    string color = this.cmbColorLuz.Text;
                    this.luz = new Luz(color);
                    this.nuevaOrden.OrdenCreada += InsertLuz; // Subscribo el método manejador al evento.
                }
            }
            catch
            {
                // Si se lanzó una excepción, es porque quedaron campos incompletos.
                throw new CamposInvalidosException("Quedaron campos incompletos en Luz.");
            }
        }
        private void InsertLuz(Orden orden)
        {
            LuzDAO luzDAO = new LuzDAO();
            luzDAO.InsertLuz(orden.Id,
                             orden.CantidadLuces,
                             orden.Luz.CalcularCosto(),
                             ((Luz)orden.Luz).Color);
        }
        private void MostrarMaterialDisponible(string material, RichTextBox rtbStock)
        {
            switch (material)
            {
                case "Acero":
                    rtbStock.Text = Stock.CantAcero.ToString();
                    break;
                case "Aluminio":
                    rtbStock.Text = Stock.CantAluminio.ToString();
                    break;
                case "Titanio":
                    rtbStock.Text = Stock.CantTitanio.ToString();
                    break;
                case "Fibra de Carbono":
                    rtbStock.Text = Stock.CantCarbono.ToString();
                    break;
                default:
                    rtbStock.Text = "";
                    break;
            }
        }
        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarMaterialDisponible(this.cmbMaterial.Text, this.rtbStockMaterial);
        }
        private void cmbMaterialPlayera_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarMaterialDisponible(this.cmbMaterialPlayera.Text, this.rtbStockMaterialPlayera);
        }
        private void MostrarMaterialNecesario(RichTextBox rtbMaterialNecesario, NumericUpDown numCantidad, ComboBox cmbCuadro)
        {
            double cantidad = (double)numCantidad.Value;
            double tamCuadro = 0;
            if (double.TryParse(cmbCuadro.Text, out tamCuadro))
            {
                rtbMaterialNecesario.Text = (cantidad * tamCuadro).ToString();
            }
            else
            {
                rtbMaterialNecesario.Text = "";
            }
        }
        private void cmbCuadro_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarMaterialNecesario(this.rtbMaterialNecesario, this.numCantidad, this.cmbCuadro);
        }
        private void cmbCuadroPlayera_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarMaterialNecesario(this.rtbMaterialNecesarioPlayera, this.numCantidadPlayera, this.cmbCuadroPlayera);
        }
        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            MostrarMaterialNecesario(this.rtbMaterialNecesario, this.numCantidad, this.cmbCuadro);
        }
        private void numCantidadPlayera_ValueChanged(object sender, EventArgs e)
        {
            MostrarMaterialNecesario(this.rtbMaterialNecesarioPlayera, this.numCantidadPlayera, this.cmbCuadroPlayera);
        }
    }
}
