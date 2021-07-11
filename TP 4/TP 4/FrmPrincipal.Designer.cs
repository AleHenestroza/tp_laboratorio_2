
namespace TP_4
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
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnImportDB = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnOrden = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpMenu.Controls.Add(this.btnImportDB);
            this.grpMenu.Controls.Add(this.btnExit);
            this.grpMenu.Controls.Add(this.btnSettings);
            this.grpMenu.Controls.Add(this.btnGuardar);
            this.grpMenu.Controls.Add(this.btnExport);
            this.grpMenu.Controls.Add(this.btnImport);
            this.grpMenu.Controls.Add(this.btnStock);
            this.grpMenu.Controls.Add(this.btnListar);
            this.grpMenu.Controls.Add(this.btnOrden);
            this.grpMenu.Controls.Add(this.btnHome);
            this.grpMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenu.Location = new System.Drawing.Point(12, 12);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(236, 612);
            this.grpMenu.TabIndex = 0;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Fábrica de Bicicletas";
            // 
            // btnImportDB
            // 
            this.btnImportDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportDB.Location = new System.Drawing.Point(6, 340);
            this.btnImportDB.Name = "btnImportDB";
            this.btnImportDB.Size = new System.Drawing.Size(224, 32);
            this.btnImportDB.TabIndex = 9;
            this.btnImportDB.Text = "Importar desde DB";
            this.btnImportDB.UseVisualStyleBackColor = true;
            this.btnImportDB.Click += new System.EventHandler(this.btnImportDB_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Info;
            this.btnExit.Location = new System.Drawing.Point(6, 574);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(224, 32);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Salir del Programa";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(6, 188);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(224, 32);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Editar Datos";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(6, 302);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(224, 32);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Archivar Órdenes";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(6, 226);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(224, 32);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Exportar Órdenes";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(6, 264);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(224, 32);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Importar Órdenes";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnStock
            // 
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(6, 150);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(224, 32);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Ver Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(6, 112);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(224, 32);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Ver Órdenes";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnOrden
            // 
            this.btnOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrden.Location = new System.Drawing.Point(6, 74);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(224, 32);
            this.btnOrden.TabIndex = 1;
            this.btnOrden.Text = "Generar Orden";
            this.btnOrden.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(6, 36);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(224, 32);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Página Principal";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenido.Location = new System.Drawing.Point(254, 12);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1100, 612);
            this.pnlContenido.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1366, 636);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.grpMenu);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP 4 - Henestroza Alejandro 2C";
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnOrden;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnImportDB;
    }
}

