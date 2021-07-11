using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;


namespace TP_4
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            foreach(Button boton in this.grpMenu.Controls)
            {
                boton.Click += LimpiarPanel; // Todos los botones deben limpiar el panel antes de mostrar el nuevo form
            }
            this.btnStock.Click += btnStock_Click;
            this.btnSettings.Click += btnSettings_Click;
            this.btnOrden.Click += btnOrden_Click;
            this.btnListar.Click += btnListar_Click;
            this.btnHome.Click += btnHome_Click;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.MostrarForm(new FrmHome());
        }

        private void LimpiarPanel(object sender, EventArgs e)
        {
            this.pnlContenido.Controls.Clear();
        }

        private void MostrarForm(Form form)
        {
            form.MdiParent = this;
            this.pnlContenido.Controls.Add(form);
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "SI/NO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                 this.Close();
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.MostrarForm(new FrmStock());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.MostrarForm(new FrmDatos());
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            this.MostrarForm(new FrmOrden());
        }

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
                        if ((fileStream = guardarArchivoDialog.OpenFile()) != null)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Fabrica.CantidadOrdenes > 0)
            {
                GuardarArchivos();
                MessageBox.Show("Archivos guardados");
            }
            else
            {
                MessageBox.Show("No hay órdenes creadas");
            }
        }

        private static void GuardarArchivos()
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                Fabrica.ImprimirArchivos(folderName);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            this.MostrarForm(new FrmListarOrdenes());
        }

        private void btnImportDB_Click(object sender, EventArgs e)
        {
            Fabrica.ImportarOrdenesDB();
        }
    }
}
