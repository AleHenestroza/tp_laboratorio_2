
namespace TP_4
{
    partial class FrmListarOrdenes
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
            this.splitListado = new System.Windows.Forms.SplitContainer();
            this.listOrdenes = new System.Windows.Forms.ListBox();
            this.rtbOrden = new System.Windows.Forms.RichTextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnDeleteOrden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitListado)).BeginInit();
            this.splitListado.Panel1.SuspendLayout();
            this.splitListado.Panel2.SuspendLayout();
            this.splitListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1060, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Órdenes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitListado
            // 
            this.splitListado.IsSplitterFixed = true;
            this.splitListado.Location = new System.Drawing.Point(16, 35);
            this.splitListado.Name = "splitListado";
            // 
            // splitListado.Panel1
            // 
            this.splitListado.Panel1.Controls.Add(this.listOrdenes);
            // 
            // splitListado.Panel2
            // 
            this.splitListado.Panel2.Controls.Add(this.rtbOrden);
            this.splitListado.Size = new System.Drawing.Size(1056, 475);
            this.splitListado.SplitterDistance = 493;
            this.splitListado.TabIndex = 1;
            // 
            // listOrdenes
            // 
            this.listOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOrdenes.FormattingEnabled = true;
            this.listOrdenes.ItemHeight = 18;
            this.listOrdenes.Location = new System.Drawing.Point(3, 3);
            this.listOrdenes.Name = "listOrdenes";
            this.listOrdenes.Size = new System.Drawing.Size(487, 472);
            this.listOrdenes.TabIndex = 0;
            this.listOrdenes.SelectedIndexChanged += new System.EventHandler(this.listOrdenes_SelectedIndexChanged);
            // 
            // rtbOrden
            // 
            this.rtbOrden.Location = new System.Drawing.Point(3, 3);
            this.rtbOrden.Name = "rtbOrden";
            this.rtbOrden.ReadOnly = true;
            this.rtbOrden.RightMargin = 200;
            this.rtbOrden.Size = new System.Drawing.Size(553, 472);
            this.rtbOrden.TabIndex = 0;
            this.rtbOrden.Text = "";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(906, 525);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(166, 45);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar Órdenes";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnDeleteOrden
            // 
            this.btnDeleteOrden.Enabled = false;
            this.btnDeleteOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrden.Location = new System.Drawing.Point(659, 525);
            this.btnDeleteOrden.Name = "btnDeleteOrden";
            this.btnDeleteOrden.Size = new System.Drawing.Size(223, 45);
            this.btnDeleteOrden.TabIndex = 3;
            this.btnDeleteOrden.Text = "Eliminar Seleccionada";
            this.btnDeleteOrden.UseVisualStyleBackColor = true;
            this.btnDeleteOrden.Click += new System.EventHandler(this.btnDeleteOrden_Click);
            // 
            // FrmListarOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 573);
            this.Controls.Add(this.btnDeleteOrden);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.splitListado);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListarOrdenes";
            this.Text = "FrmListarOrdenes";
            this.splitListado.Panel1.ResumeLayout(false);
            this.splitListado.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitListado)).EndInit();
            this.splitListado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.SplitContainer splitListado;
        private System.Windows.Forms.RichTextBox rtbOrden;
        private System.Windows.Forms.ListBox listOrdenes;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDeleteOrden;
    }
}