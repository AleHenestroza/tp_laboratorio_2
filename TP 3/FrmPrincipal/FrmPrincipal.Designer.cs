
namespace FrmPrincipal
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGenerarOrden = new System.Windows.Forms.Button();
            this.btnListarOrdenes = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnLimpiarOrdenes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(523, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BikeFactory";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerarOrden
            // 
            this.btnGenerarOrden.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarOrden.Location = new System.Drawing.Point(18, 83);
            this.btnGenerarOrden.Name = "btnGenerarOrden";
            this.btnGenerarOrden.Size = new System.Drawing.Size(163, 33);
            this.btnGenerarOrden.TabIndex = 1;
            this.btnGenerarOrden.Text = "Generar Orden";
            this.btnGenerarOrden.UseVisualStyleBackColor = false;
            this.btnGenerarOrden.Click += new System.EventHandler(this.btnGenerarOrden_Click);
            // 
            // btnListarOrdenes
            // 
            this.btnListarOrdenes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListarOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarOrdenes.Location = new System.Drawing.Point(18, 147);
            this.btnListarOrdenes.Name = "btnListarOrdenes";
            this.btnListarOrdenes.Size = new System.Drawing.Size(163, 33);
            this.btnListarOrdenes.TabIndex = 2;
            this.btnListarOrdenes.Text = "Listar Órdenes";
            this.btnListarOrdenes.UseVisualStyleBackColor = false;
            this.btnListarOrdenes.Click += new System.EventHandler(this.btnListarOrdenes_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(244, 83);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(291, 33);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Importar Listado de Órdenes";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(244, 147);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(291, 33);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Exportar Listado de Órdenes";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(244, 215);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(291, 33);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Guardar Listado a Archivos";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnLimpiarOrdenes
            // 
            this.btnLimpiarOrdenes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarOrdenes.Location = new System.Drawing.Point(18, 215);
            this.btnLimpiarOrdenes.Name = "btnLimpiarOrdenes";
            this.btnLimpiarOrdenes.Size = new System.Drawing.Size(163, 33);
            this.btnLimpiarOrdenes.TabIndex = 6;
            this.btnLimpiarOrdenes.Text = "Borrar Órdenes";
            this.btnLimpiarOrdenes.UseVisualStyleBackColor = false;
            this.btnLimpiarOrdenes.Click += new System.EventHandler(this.btnLimpiarOrdenes_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(547, 281);
            this.Controls.Add(this.btnLimpiarOrdenes);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnListarOrdenes);
            this.Controls.Add(this.btnGenerarOrden);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP 3 Henestroza Alejandro 2C";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGenerarOrden;
        private System.Windows.Forms.Button btnListarOrdenes;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnLimpiarOrdenes;
    }
}

