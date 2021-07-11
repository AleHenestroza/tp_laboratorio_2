
namespace TP_4
{
    partial class FrmStock
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
            this.grpStock = new System.Windows.Forms.GroupBox();
            this.rtbStockCarbono = new System.Windows.Forms.RichTextBox();
            this.rtbStockTitanio = new System.Windows.Forms.RichTextBox();
            this.rtbStockAluminio = new System.Windows.Forms.RichTextBox();
            this.rtbStockAcero = new System.Windows.Forms.RichTextBox();
            this.lblStockCarbono = new System.Windows.Forms.Label();
            this.lblStockTitanio = new System.Windows.Forms.Label();
            this.lblStockAluminio = new System.Windows.Forms.Label();
            this.lblStockAcero = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numCarbono = new System.Windows.Forms.NumericUpDown();
            this.numTitanio = new System.Windows.Forms.NumericUpDown();
            this.numAluminio = new System.Windows.Forms.NumericUpDown();
            this.numAcero = new System.Windows.Forms.NumericUpDown();
            this.lblCarbono = new System.Windows.Forms.Label();
            this.lblTitanio = new System.Windows.Forms.Label();
            this.lblAluminio = new System.Windows.Forms.Label();
            this.lblAcero = new System.Windows.Forms.Label();
            this.lblAgregarStock = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpStock.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCarbono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTitanio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAluminio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAcero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1060, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Stock Disponible";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpStock
            // 
            this.grpStock.Controls.Add(this.rtbStockCarbono);
            this.grpStock.Controls.Add(this.rtbStockTitanio);
            this.grpStock.Controls.Add(this.rtbStockAluminio);
            this.grpStock.Controls.Add(this.rtbStockAcero);
            this.grpStock.Controls.Add(this.lblStockCarbono);
            this.grpStock.Controls.Add(this.lblStockTitanio);
            this.grpStock.Controls.Add(this.lblStockAluminio);
            this.grpStock.Controls.Add(this.lblStockAcero);
            this.grpStock.Location = new System.Drawing.Point(16, 35);
            this.grpStock.Name = "grpStock";
            this.grpStock.Size = new System.Drawing.Size(1056, 85);
            this.grpStock.TabIndex = 1;
            this.grpStock.TabStop = false;
            // 
            // rtbStockCarbono
            // 
            this.rtbStockCarbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStockCarbono.Location = new System.Drawing.Point(911, 42);
            this.rtbStockCarbono.Name = "rtbStockCarbono";
            this.rtbStockCarbono.ReadOnly = true;
            this.rtbStockCarbono.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbStockCarbono.Size = new System.Drawing.Size(101, 25);
            this.rtbStockCarbono.TabIndex = 7;
            this.rtbStockCarbono.Text = "";
            // 
            // rtbStockTitanio
            // 
            this.rtbStockTitanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStockTitanio.Location = new System.Drawing.Point(608, 42);
            this.rtbStockTitanio.Name = "rtbStockTitanio";
            this.rtbStockTitanio.ReadOnly = true;
            this.rtbStockTitanio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbStockTitanio.Size = new System.Drawing.Size(101, 25);
            this.rtbStockTitanio.TabIndex = 6;
            this.rtbStockTitanio.Text = "";
            // 
            // rtbStockAluminio
            // 
            this.rtbStockAluminio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStockAluminio.Location = new System.Drawing.Point(327, 42);
            this.rtbStockAluminio.Name = "rtbStockAluminio";
            this.rtbStockAluminio.ReadOnly = true;
            this.rtbStockAluminio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbStockAluminio.Size = new System.Drawing.Size(101, 25);
            this.rtbStockAluminio.TabIndex = 5;
            this.rtbStockAluminio.Text = "";
            // 
            // rtbStockAcero
            // 
            this.rtbStockAcero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStockAcero.Location = new System.Drawing.Point(10, 42);
            this.rtbStockAcero.Name = "rtbStockAcero";
            this.rtbStockAcero.ReadOnly = true;
            this.rtbStockAcero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbStockAcero.Size = new System.Drawing.Size(101, 25);
            this.rtbStockAcero.TabIndex = 4;
            this.rtbStockAcero.Text = "";
            // 
            // lblStockCarbono
            // 
            this.lblStockCarbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCarbono.Location = new System.Drawing.Point(871, 16);
            this.lblStockCarbono.Name = "lblStockCarbono";
            this.lblStockCarbono.Size = new System.Drawing.Size(179, 23);
            this.lblStockCarbono.TabIndex = 3;
            this.lblStockCarbono.Text = "Fibra de Carbono";
            this.lblStockCarbono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStockTitanio
            // 
            this.lblStockTitanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockTitanio.Location = new System.Drawing.Point(609, 16);
            this.lblStockTitanio.Name = "lblStockTitanio";
            this.lblStockTitanio.Size = new System.Drawing.Size(100, 23);
            this.lblStockTitanio.TabIndex = 2;
            this.lblStockTitanio.Text = "Titanio";
            this.lblStockTitanio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStockAluminio
            // 
            this.lblStockAluminio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAluminio.Location = new System.Drawing.Point(328, 16);
            this.lblStockAluminio.Name = "lblStockAluminio";
            this.lblStockAluminio.Size = new System.Drawing.Size(100, 23);
            this.lblStockAluminio.TabIndex = 1;
            this.lblStockAluminio.Text = "Aluminio";
            this.lblStockAluminio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStockAcero
            // 
            this.lblStockAcero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAcero.Location = new System.Drawing.Point(6, 16);
            this.lblStockAcero.Name = "lblStockAcero";
            this.lblStockAcero.Size = new System.Drawing.Size(100, 23);
            this.lblStockAcero.TabIndex = 0;
            this.lblStockAcero.Text = "Acero";
            this.lblStockAcero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numCarbono);
            this.groupBox1.Controls.Add(this.numTitanio);
            this.groupBox1.Controls.Add(this.numAluminio);
            this.groupBox1.Controls.Add(this.numAcero);
            this.groupBox1.Controls.Add(this.lblCarbono);
            this.groupBox1.Controls.Add(this.lblTitanio);
            this.groupBox1.Controls.Add(this.lblAluminio);
            this.groupBox1.Controls.Add(this.lblAcero);
            this.groupBox1.Location = new System.Drawing.Point(16, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // numCarbono
            // 
            this.numCarbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCarbono.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numCarbono.Location = new System.Drawing.Point(905, 42);
            this.numCarbono.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCarbono.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numCarbono.Name = "numCarbono";
            this.numCarbono.Size = new System.Drawing.Size(120, 24);
            this.numCarbono.TabIndex = 7;
            this.numCarbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numTitanio
            // 
            this.numTitanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTitanio.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTitanio.Location = new System.Drawing.Point(605, 42);
            this.numTitanio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTitanio.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numTitanio.Name = "numTitanio";
            this.numTitanio.Size = new System.Drawing.Size(120, 24);
            this.numTitanio.TabIndex = 6;
            this.numTitanio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numAluminio
            // 
            this.numAluminio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAluminio.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numAluminio.Location = new System.Drawing.Point(316, 42);
            this.numAluminio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAluminio.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numAluminio.Name = "numAluminio";
            this.numAluminio.Size = new System.Drawing.Size(120, 24);
            this.numAluminio.TabIndex = 5;
            this.numAluminio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numAcero
            // 
            this.numAcero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAcero.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numAcero.Location = new System.Drawing.Point(10, 42);
            this.numAcero.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAcero.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numAcero.Name = "numAcero";
            this.numAcero.Size = new System.Drawing.Size(120, 24);
            this.numAcero.TabIndex = 4;
            this.numAcero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCarbono
            // 
            this.lblCarbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbono.Location = new System.Drawing.Point(871, 16);
            this.lblCarbono.Name = "lblCarbono";
            this.lblCarbono.Size = new System.Drawing.Size(179, 23);
            this.lblCarbono.TabIndex = 3;
            this.lblCarbono.Text = "Fibra de Carbono";
            this.lblCarbono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitanio
            // 
            this.lblTitanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitanio.Location = new System.Drawing.Point(609, 16);
            this.lblTitanio.Name = "lblTitanio";
            this.lblTitanio.Size = new System.Drawing.Size(100, 23);
            this.lblTitanio.TabIndex = 2;
            this.lblTitanio.Text = "Titanio";
            this.lblTitanio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAluminio
            // 
            this.lblAluminio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluminio.Location = new System.Drawing.Point(328, 16);
            this.lblAluminio.Name = "lblAluminio";
            this.lblAluminio.Size = new System.Drawing.Size(100, 23);
            this.lblAluminio.TabIndex = 1;
            this.lblAluminio.Text = "Aluminio";
            this.lblAluminio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAcero
            // 
            this.lblAcero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcero.Location = new System.Drawing.Point(6, 16);
            this.lblAcero.Name = "lblAcero";
            this.lblAcero.Size = new System.Drawing.Size(100, 23);
            this.lblAcero.TabIndex = 0;
            this.lblAcero.Text = "Acero";
            this.lblAcero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgregarStock
            // 
            this.lblAgregarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarStock.Location = new System.Drawing.Point(12, 148);
            this.lblAgregarStock.Name = "lblAgregarStock";
            this.lblAgregarStock.Size = new System.Drawing.Size(1060, 23);
            this.lblAgregarStock.TabIndex = 2;
            this.lblAgregarStock.Text = "Modificar Stock";
            this.lblAgregarStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(935, 265);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(137, 35);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Modificar Stock";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 573);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAgregarStock);
            this.Controls.Add(this.grpStock);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStock";
            this.Text = "FrmStock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            this.grpStock.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCarbono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTitanio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAluminio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAcero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpStock;
        private System.Windows.Forms.Label lblStockAcero;
        private System.Windows.Forms.Label lblStockTitanio;
        private System.Windows.Forms.Label lblStockAluminio;
        private System.Windows.Forms.Label lblStockCarbono;
        private System.Windows.Forms.RichTextBox rtbStockCarbono;
        private System.Windows.Forms.RichTextBox rtbStockTitanio;
        private System.Windows.Forms.RichTextBox rtbStockAluminio;
        private System.Windows.Forms.RichTextBox rtbStockAcero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCarbono;
        private System.Windows.Forms.Label lblTitanio;
        private System.Windows.Forms.Label lblAluminio;
        private System.Windows.Forms.Label lblAcero;
        private System.Windows.Forms.Label lblAgregarStock;
        private System.Windows.Forms.NumericUpDown numAluminio;
        private System.Windows.Forms.NumericUpDown numAcero;
        private System.Windows.Forms.NumericUpDown numTitanio;
        private System.Windows.Forms.NumericUpDown numCarbono;
        private System.Windows.Forms.Button btnSubmit;
    }
}