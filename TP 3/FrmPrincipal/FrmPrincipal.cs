using System;
using System.IO;
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

        /// <summary>
        /// Abre el formulario para generar una nueva orden.
        /// Crea un objeto orden y se lo pasa al nuevo formulario para que
        /// llene sus campos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerarOrden_Click(object sender, EventArgs e)
        {
            FrmOrden formOrden = new FrmOrden();
            formOrden.ShowDialog();

            if (formOrden.Orden != null)
            {
                Fabrica.AgregarOrden(formOrden.Orden);
            }
            
            // Console.WriteLine(nuevaOrden.ToString());
        }

        /// <summary>
        /// Abre un formulario que lista todas las ordenes ingresadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListarOrdenes_Click(object sender, EventArgs e)
        {
            if (Fabrica.CantidadOrdenes > 0)
            {
                FrmListadoOrdenes formListado = new FrmListadoOrdenes(Fabrica.ListadoOrdenes.ListadoOrdenes);
                formListado.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay órdenes creadas");
            }
        }

        /// <summary>
        /// Imprime cada orden a un archivo propio en la carpeta Ordenes
        /// ubicada en la raíz de la solución
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (Fabrica.CantidadOrdenes > 0)
            {
                Fabrica.ImprimirArchivos();
                MessageBox.Show("Archivos guardados");
            }
            else
            {
                MessageBox.Show("No hay órdenes creadas");
            }
        }

        /// <summary>
        /// Permite exportar el listado de ordenes a un archivo binario
        /// en una ubicación a elección del usuario.
        /// Si no hay órdenes creadas, no permite exportar nada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (!(Fabrica.CantidadOrdenes > 0))
            {
                MessageBox.Show("No hay órdenes creadas");
            }
            else
            {
                try
                {
                    SaveFileDialog guardarArchivoDialog = new SaveFileDialog();
                    Stream fileStream;

                    guardarArchivoDialog.Filter = "Archivo binario (*.bin)|*.bin";
                    guardarArchivoDialog.FilterIndex = 2;
                    guardarArchivoDialog.RestoreDirectory = true;

                    if (guardarArchivoDialog.ShowDialog() == DialogResult.OK)
                    {
                        if((fileStream = guardarArchivoDialog.OpenFile()) != null)
                        {
                            Fabrica.ExportarBinario(fileStream);
                            fileStream.Close();
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Hubo un error inesperado\n" + exc.Message);
                }
            }
        }

        /// <summary>
        /// Limpia el listado de ordenes dejandolo vacío
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiarOrdenes_Click(object sender, EventArgs e)
        {
            if (Fabrica.CantidadOrdenes > 0)
            {
                Fabrica.LimpiarOrdenes();
                MessageBox.Show("Órdenes eliminadas");
            }
            else
            {
                MessageBox.Show("No hay órdenes creadas");
            }
        }

        /// <summary>
        /// Permite importar un archivo binario con un listado de ordenes
        /// </summary>
        private static void ImportarArchivo()
        {
            try
            {
                OpenFileDialog abrirArchivoDialog = new OpenFileDialog();
                //Stream fileStream;

                //abrirArchivoDialog.InitialDirectory = "c:\\";
                abrirArchivoDialog.Filter = "Archivo binario (*.bin)|*.bin";
                abrirArchivoDialog.FilterIndex = 2;
                abrirArchivoDialog.RestoreDirectory = true;

                if (abrirArchivoDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = abrirArchivoDialog.FileName;
                    Fabrica.ImportarBinario(path);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Hubo un error inesperado\n" + exc.Message);
            }
        }

        /// <summary>
        /// Si hay un listado de órdenes ya cargado en el programa, pide confirmación
        /// del usuario. En caso de confirmar, o que no haya ningún listado, llama a
        /// la función ImportarArchivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (Fabrica.CantidadOrdenes > 0)
            {
                DialogResult confirma = MessageBox.Show("Ya hay una lista de órdenes cargadas, si importa\n" +
                    "una nueva, perderá la original", "¿Desea continuar?", MessageBoxButtons.YesNo);
                if (confirma == DialogResult.Yes)
                {
                    ImportarArchivo();
                }
            }
            else
            {
                ImportarArchivo();
            }
        }

        /// <summary>
        /// Abre el formulario para editar el stock de materiales.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStock_Click(object sender, EventArgs e)
        {
            FrmAgregarStock frmAgregarStock = new FrmAgregarStock();
            frmAgregarStock.Show();
        }
    }
}
