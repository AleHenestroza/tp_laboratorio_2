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
// Mirá la cantidad de using que tiene esta clase...

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
        /// <summary>
        /// Si se tilda el checkbox, habilita los controles para crear MountainBikes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkMountainBike_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.splitBicicletas.Visible)
            {
                this.splitBicicletas.Visible = true;

            }
            this.splitBicicletas.Panel1.Enabled = !this.splitBicicletas.Panel1.Enabled;
        }
        /// <summary>
        /// Si se tilda el checkbox, habilita los controles para crear Playeras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkPlayera_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.splitBicicletas.Visible)
            {
                this.splitBicicletas.Visible = true;

            }
            this.splitBicicletas.Panel2.Enabled = !this.splitBicicletas.Panel2.Enabled;
        }
        /// <summary>
        /// Si se tilda el checkbox, habilita los controles para crear Cascos
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCasco_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.splitAccesorios.Visible)
            {
                this.splitAccesorios.Visible = true;

            }
            this.splitAccesorios.Panel1.Enabled = !this.splitAccesorios.Panel1.Enabled;
        }
        /// <summary>
        /// Si se tilda el checkbox, habilita los controles para crear Luces
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkLuz_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.splitAccesorios.Visible)
            {
                this.splitAccesorios.Visible = true;

            }
            this.splitAccesorios.Panel2.Enabled = !this.splitAccesorios.Panel2.Enabled;
        }
        /// <summary>
        /// Al enviar el formulario, se revisan los checkbox marcados, en base a eso
        /// se valida que todos los campos que correspondan se hayan completado, se 
        /// crea una nueva orden y se agrega al listado de ordenes. Se inserta la orden
        /// en la Base de Datos y en base a los métodos suscriptos al evento OrdenCreada,
        /// se insertan los productos en sus tablas de la BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Instancia una MountainBike con los campos del formulario y suscribe el método
        /// InsertMountainBike al evento OrdenCreada
        /// </summary>
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
        /// <summary>
        /// Método manejador para insertar la MountainBike en la Base de Datos
        /// </summary>
        /// <param name="orden"></param>
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
        /// <summary>
        /// Instancia una Playera con los campos del formulario y suscribe el método
        /// InsertPlayera al evento OrdenCreada
        /// </summary>
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
        /// <summary>
        /// Método manejador para insertar la Playera en la Base de Datos
        /// </summary>
        /// <param name="orden"></param>
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
        /// <summary>
        /// Instancia un Casco con los campos del formulario y suscribe el método
        /// InsertCasco al evento OrdenCreada
        /// </summary>
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
        /// <summary>
        /// Método manejador para insertar el Casco en la Base de Datos
        /// </summary>
        /// <param name="orden"></param>
        private void InsertCasco(Orden orden)
        {
            CascoDAO cascoDAO = new CascoDAO();
            cascoDAO.InsertCascos(orden.Id,
                                  orden.CantidadCascos,
                                  orden.Casco.CalcularCosto(),
                                  ((Casco)orden.Casco).Talla);
        }
        /// <summary>
        /// Instancia una Luz con los campos del formulario y suscribe el método
        /// InsertLuz al evento OrdenCreada
        /// </summary>
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
        /// <summary>
        /// Método manejador para insertar la Luz en la Base de Datos
        /// </summary>
        /// <param name="orden"></param>
        private void InsertLuz(Orden orden)
        {
            LuzDAO luzDAO = new LuzDAO();
            luzDAO.InsertLuz(orden.Id,
                             orden.CantidadLuces,
                             orden.Luz.CalcularCosto(),
                             ((Luz)orden.Luz).Color);
        }
        /// <summary>
        /// Muestra el material en Stock en un RichTextBox, dependiendo del material necesario
        /// </summary>
        /// <param name="material"></param>
        /// <param name="rtbStock"></param>
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
        /// <summary>
        /// Al seleccionar un material, muestra el stock del mismo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarMaterialDisponible(this.cmbMaterial.Text, this.rtbStockMaterial);
        }
        /// <summary>
        /// Al seleccionar un material, muestra el stock del mismo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMaterialPlayera_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarMaterialDisponible(this.cmbMaterialPlayera.Text, this.rtbStockMaterialPlayera);
        }
        /// <summary>
        /// Muestra la cantidad de material necesario para generar la orden en un RichTextBox
        /// </summary>
        /// <param name="rtbMaterialNecesario"></param>
        /// <param name="numCantidad"></param>
        /// <param name="cmbCuadro"></param>
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
        /// <summary>
        /// Al modificar el tamaño del cuadro, modifica la cantidad de material y muestra el necesario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCuadro_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarMaterialNecesario(this.rtbMaterialNecesario, this.numCantidad, this.cmbCuadro);
        }
        /// <summary>
        /// Al modificar el tamaño del cuadro, modifica la cantidad de material y muestra el necesario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCuadroPlayera_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarMaterialNecesario(this.rtbMaterialNecesarioPlayera, this.numCantidadPlayera, this.cmbCuadroPlayera);
        }
        /// <summary>
        /// Al modificar la cantidad de bicicletas, se modifica la cantidad de material necesario y se muestra en el RichTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            MostrarMaterialNecesario(this.rtbMaterialNecesario, this.numCantidad, this.cmbCuadro);
        }
        /// <summary>
        /// Al modificar la cantidad de bicicletas, se modifica la cantidad de material necesario y se muestra en el RichTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numCantidadPlayera_ValueChanged(object sender, EventArgs e)
        {
            MostrarMaterialNecesario(this.rtbMaterialNecesarioPlayera, this.numCantidadPlayera, this.cmbCuadroPlayera);
        }
    }
}
