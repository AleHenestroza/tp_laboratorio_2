
namespace FrmPrincipal
{
    partial class FrmOrden
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
            this.lblBicicleta = new System.Windows.Forms.Label();
            this.lblMountainBike = new System.Windows.Forms.Label();
            this.lblPlayera = new System.Windows.Forms.Label();
            this.lblRodadoMB = new System.Windows.Forms.Label();
            this.lblRodadoP = new System.Windows.Forms.Label();
            this.cmbRodadoMB = new System.Windows.Forms.ComboBox();
            this.cmbRodadoP = new System.Windows.Forms.ComboBox();
            this.lblCuadroMB = new System.Windows.Forms.Label();
            this.lblCuadroP = new System.Windows.Forms.Label();
            this.cmbCuadroMB = new System.Windows.Forms.ComboBox();
            this.cmbCuadroP = new System.Windows.Forms.ComboBox();
            this.lblCambios = new System.Windows.Forms.Label();
            this.chkCambios = new System.Windows.Forms.CheckBox();
            this.lblFrenos = new System.Windows.Forms.Label();
            this.chkFrenos = new System.Windows.Forms.CheckBox();
            this.lblCantidadMB = new System.Windows.Forms.Label();
            this.lblCantidadP = new System.Windows.Forms.Label();
            this.numUDMountainBike = new System.Windows.Forms.NumericUpDown();
            this.numUDPlayera = new System.Windows.Forms.NumericUpDown();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAccesorios = new System.Windows.Forms.Label();
            this.lblCasco = new System.Windows.Forms.Label();
            this.lblTallaCasco = new System.Windows.Forms.Label();
            this.cmbTalleCasco = new System.Windows.Forms.ComboBox();
            this.lblCantidadCasco = new System.Windows.Forms.Label();
            this.numUDCasco = new System.Windows.Forms.NumericUpDown();
            this.lblLuz = new System.Windows.Forms.Label();
            this.lblColorLuz = new System.Windows.Forms.Label();
            this.cmbColorLuz = new System.Windows.Forms.ComboBox();
            this.lblCantidadLuz = new System.Windows.Forms.Label();
            this.numUDLuz = new System.Windows.Forms.NumericUpDown();
            this.cmbMaterialMB = new System.Windows.Forms.ComboBox();
            this.lblMaterialMB = new System.Windows.Forms.Label();
            this.cmbMaterialP = new System.Windows.Forms.ComboBox();
            this.lblMaterialP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUDMountainBike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPlayera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCasco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDLuz)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBicicleta
            // 
            this.lblBicicleta.AutoSize = true;
            this.lblBicicleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBicicleta.Location = new System.Drawing.Point(12, 9);
            this.lblBicicleta.Name = "lblBicicleta";
            this.lblBicicleta.Size = new System.Drawing.Size(126, 24);
            this.lblBicicleta.TabIndex = 0;
            this.lblBicicleta.Text = "BICICLETAS";
            // 
            // lblMountainBike
            // 
            this.lblMountainBike.AutoSize = true;
            this.lblMountainBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMountainBike.Location = new System.Drawing.Point(12, 55);
            this.lblMountainBike.Name = "lblMountainBike";
            this.lblMountainBike.Size = new System.Drawing.Size(142, 24);
            this.lblMountainBike.TabIndex = 1;
            this.lblMountainBike.Text = "Mountain Bike";
            // 
            // lblPlayera
            // 
            this.lblPlayera.AutoSize = true;
            this.lblPlayera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayera.Location = new System.Drawing.Point(12, 241);
            this.lblPlayera.Name = "lblPlayera";
            this.lblPlayera.Size = new System.Drawing.Size(79, 24);
            this.lblPlayera.TabIndex = 2;
            this.lblPlayera.Text = "Playera";
            // 
            // lblRodadoMB
            // 
            this.lblRodadoMB.AutoSize = true;
            this.lblRodadoMB.Location = new System.Drawing.Point(13, 94);
            this.lblRodadoMB.Name = "lblRodadoMB";
            this.lblRodadoMB.Size = new System.Drawing.Size(45, 13);
            this.lblRodadoMB.TabIndex = 3;
            this.lblRodadoMB.Text = "Rodado";
            // 
            // lblRodadoP
            // 
            this.lblRodadoP.AutoSize = true;
            this.lblRodadoP.Location = new System.Drawing.Point(13, 289);
            this.lblRodadoP.Name = "lblRodadoP";
            this.lblRodadoP.Size = new System.Drawing.Size(45, 13);
            this.lblRodadoP.TabIndex = 4;
            this.lblRodadoP.Text = "Rodado";
            // 
            // cmbRodadoMB
            // 
            this.cmbRodadoMB.FormattingEnabled = true;
            this.cmbRodadoMB.Items.AddRange(new object[] {
            "26",
            "27",
            "28"});
            this.cmbRodadoMB.Location = new System.Drawing.Point(119, 91);
            this.cmbRodadoMB.Name = "cmbRodadoMB";
            this.cmbRodadoMB.Size = new System.Drawing.Size(121, 21);
            this.cmbRodadoMB.TabIndex = 5;
            // 
            // cmbRodadoP
            // 
            this.cmbRodadoP.FormattingEnabled = true;
            this.cmbRodadoP.Items.AddRange(new object[] {
            "20",
            "22",
            "24",
            "26",
            "28"});
            this.cmbRodadoP.Location = new System.Drawing.Point(119, 286);
            this.cmbRodadoP.Name = "cmbRodadoP";
            this.cmbRodadoP.Size = new System.Drawing.Size(121, 21);
            this.cmbRodadoP.TabIndex = 6;
            // 
            // lblCuadroMB
            // 
            this.lblCuadroMB.AutoSize = true;
            this.lblCuadroMB.Location = new System.Drawing.Point(13, 115);
            this.lblCuadroMB.Name = "lblCuadroMB";
            this.lblCuadroMB.Size = new System.Drawing.Size(100, 13);
            this.lblCuadroMB.TabIndex = 7;
            this.lblCuadroMB.Text = "Tamaño del Cuadro";
            // 
            // lblCuadroP
            // 
            this.lblCuadroP.AutoSize = true;
            this.lblCuadroP.Location = new System.Drawing.Point(13, 310);
            this.lblCuadroP.Name = "lblCuadroP";
            this.lblCuadroP.Size = new System.Drawing.Size(100, 13);
            this.lblCuadroP.TabIndex = 8;
            this.lblCuadroP.Text = "Tamaño del Cuadro";
            // 
            // cmbCuadroMB
            // 
            this.cmbCuadroMB.FormattingEnabled = true;
            this.cmbCuadroMB.Items.AddRange(new object[] {
            "47.5",
            "49.5",
            "51.5",
            "53.5",
            "55.5",
            "57.5",
            "59.5",
            "61"});
            this.cmbCuadroMB.Location = new System.Drawing.Point(119, 112);
            this.cmbCuadroMB.Name = "cmbCuadroMB";
            this.cmbCuadroMB.Size = new System.Drawing.Size(121, 21);
            this.cmbCuadroMB.TabIndex = 9;
            // 
            // cmbCuadroP
            // 
            this.cmbCuadroP.FormattingEnabled = true;
            this.cmbCuadroP.Items.AddRange(new object[] {
            "41.5",
            "43.5",
            "45.5",
            "47.5",
            "49.5",
            "51.5",
            "53.5",
            "55.5",
            "57.5"});
            this.cmbCuadroP.Location = new System.Drawing.Point(119, 307);
            this.cmbCuadroP.Name = "cmbCuadroP";
            this.cmbCuadroP.Size = new System.Drawing.Size(121, 21);
            this.cmbCuadroP.TabIndex = 10;
            // 
            // lblCambios
            // 
            this.lblCambios.AutoSize = true;
            this.lblCambios.Location = new System.Drawing.Point(13, 156);
            this.lblCambios.Name = "lblCambios";
            this.lblCambios.Size = new System.Drawing.Size(47, 13);
            this.lblCambios.TabIndex = 11;
            this.lblCambios.Text = "Cambios";
            // 
            // chkCambios
            // 
            this.chkCambios.AutoSize = true;
            this.chkCambios.Location = new System.Drawing.Point(167, 156);
            this.chkCambios.Name = "chkCambios";
            this.chkCambios.Size = new System.Drawing.Size(15, 14);
            this.chkCambios.TabIndex = 12;
            this.chkCambios.UseVisualStyleBackColor = true;
            // 
            // lblFrenos
            // 
            this.lblFrenos.AutoSize = true;
            this.lblFrenos.Location = new System.Drawing.Point(14, 350);
            this.lblFrenos.Name = "lblFrenos";
            this.lblFrenos.Size = new System.Drawing.Size(96, 13);
            this.lblFrenos.TabIndex = 13;
            this.lblFrenos.Text = "Freno contra pedal";
            // 
            // chkFrenos
            // 
            this.chkFrenos.AutoSize = true;
            this.chkFrenos.Location = new System.Drawing.Point(167, 350);
            this.chkFrenos.Name = "chkFrenos";
            this.chkFrenos.Size = new System.Drawing.Size(15, 14);
            this.chkFrenos.TabIndex = 14;
            this.chkFrenos.UseVisualStyleBackColor = true;
            // 
            // lblCantidadMB
            // 
            this.lblCantidadMB.AutoSize = true;
            this.lblCantidadMB.Location = new System.Drawing.Point(13, 178);
            this.lblCantidadMB.Name = "lblCantidadMB";
            this.lblCantidadMB.Size = new System.Drawing.Size(49, 13);
            this.lblCantidadMB.TabIndex = 15;
            this.lblCantidadMB.Text = "Cantidad";
            // 
            // lblCantidadP
            // 
            this.lblCantidadP.AutoSize = true;
            this.lblCantidadP.Location = new System.Drawing.Point(15, 372);
            this.lblCantidadP.Name = "lblCantidadP";
            this.lblCantidadP.Size = new System.Drawing.Size(49, 13);
            this.lblCantidadP.TabIndex = 16;
            this.lblCantidadP.Text = "Cantidad";
            // 
            // numUDMountainBike
            // 
            this.numUDMountainBike.Location = new System.Drawing.Point(119, 176);
            this.numUDMountainBike.Name = "numUDMountainBike";
            this.numUDMountainBike.Size = new System.Drawing.Size(120, 20);
            this.numUDMountainBike.TabIndex = 17;
            // 
            // numUDPlayera
            // 
            this.numUDPlayera.Location = new System.Drawing.Point(119, 370);
            this.numUDPlayera.Name = "numUDPlayera";
            this.numUDPlayera.Size = new System.Drawing.Size(120, 20);
            this.numUDPlayera.TabIndex = 18;
            // 
            // btnGenerar
            // 
            this.btnGenerar.AutoSize = true;
            this.btnGenerar.Location = new System.Drawing.Point(300, 459);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(87, 23);
            this.btnGenerar.TabIndex = 19;
            this.btnGenerar.Text = "Generar Orden";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Location = new System.Drawing.Point(411, 459);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar Orden";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAccesorios
            // 
            this.lblAccesorios.AutoSize = true;
            this.lblAccesorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccesorios.Location = new System.Drawing.Point(319, 9);
            this.lblAccesorios.Name = "lblAccesorios";
            this.lblAccesorios.Size = new System.Drawing.Size(143, 24);
            this.lblAccesorios.TabIndex = 21;
            this.lblAccesorios.Text = "ACCESORIOS";
            // 
            // lblCasco
            // 
            this.lblCasco.AutoSize = true;
            this.lblCasco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasco.Location = new System.Drawing.Point(319, 55);
            this.lblCasco.Name = "lblCasco";
            this.lblCasco.Size = new System.Drawing.Size(68, 24);
            this.lblCasco.TabIndex = 22;
            this.lblCasco.Text = "Casco";
            // 
            // lblTallaCasco
            // 
            this.lblTallaCasco.AutoSize = true;
            this.lblTallaCasco.Location = new System.Drawing.Point(320, 94);
            this.lblTallaCasco.Name = "lblTallaCasco";
            this.lblTallaCasco.Size = new System.Drawing.Size(30, 13);
            this.lblTallaCasco.TabIndex = 23;
            this.lblTallaCasco.Text = "Talle";
            // 
            // cmbTalleCasco
            // 
            this.cmbTalleCasco.FormattingEnabled = true;
            this.cmbTalleCasco.Items.AddRange(new object[] {
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63"});
            this.cmbTalleCasco.Location = new System.Drawing.Point(374, 91);
            this.cmbTalleCasco.Name = "cmbTalleCasco";
            this.cmbTalleCasco.Size = new System.Drawing.Size(121, 21);
            this.cmbTalleCasco.TabIndex = 24;
            // 
            // lblCantidadCasco
            // 
            this.lblCantidadCasco.AutoSize = true;
            this.lblCantidadCasco.Location = new System.Drawing.Point(320, 115);
            this.lblCantidadCasco.Name = "lblCantidadCasco";
            this.lblCantidadCasco.Size = new System.Drawing.Size(49, 13);
            this.lblCantidadCasco.TabIndex = 25;
            this.lblCantidadCasco.Text = "Cantidad";
            // 
            // numUDCasco
            // 
            this.numUDCasco.Location = new System.Drawing.Point(375, 113);
            this.numUDCasco.Name = "numUDCasco";
            this.numUDCasco.Size = new System.Drawing.Size(120, 20);
            this.numUDCasco.TabIndex = 26;
            // 
            // lblLuz
            // 
            this.lblLuz.AutoSize = true;
            this.lblLuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuz.Location = new System.Drawing.Point(319, 241);
            this.lblLuz.Name = "lblLuz";
            this.lblLuz.Size = new System.Drawing.Size(43, 24);
            this.lblLuz.TabIndex = 27;
            this.lblLuz.Text = "Luz";
            // 
            // lblColorLuz
            // 
            this.lblColorLuz.AutoSize = true;
            this.lblColorLuz.Location = new System.Drawing.Point(320, 289);
            this.lblColorLuz.Name = "lblColorLuz";
            this.lblColorLuz.Size = new System.Drawing.Size(31, 13);
            this.lblColorLuz.TabIndex = 28;
            this.lblColorLuz.Text = "Color";
            // 
            // cmbColorLuz
            // 
            this.cmbColorLuz.FormattingEnabled = true;
            this.cmbColorLuz.Items.AddRange(new object[] {
            "Roja",
            "Blanca",
            "Amarilla"});
            this.cmbColorLuz.Location = new System.Drawing.Point(374, 286);
            this.cmbColorLuz.Name = "cmbColorLuz";
            this.cmbColorLuz.Size = new System.Drawing.Size(121, 21);
            this.cmbColorLuz.TabIndex = 29;
            // 
            // lblCantidadLuz
            // 
            this.lblCantidadLuz.AutoSize = true;
            this.lblCantidadLuz.Location = new System.Drawing.Point(320, 310);
            this.lblCantidadLuz.Name = "lblCantidadLuz";
            this.lblCantidadLuz.Size = new System.Drawing.Size(49, 13);
            this.lblCantidadLuz.TabIndex = 30;
            this.lblCantidadLuz.Text = "Cantidad";
            // 
            // numUDLuz
            // 
            this.numUDLuz.Location = new System.Drawing.Point(375, 308);
            this.numUDLuz.Name = "numUDLuz";
            this.numUDLuz.Size = new System.Drawing.Size(120, 20);
            this.numUDLuz.TabIndex = 31;
            // 
            // cmbMaterialMB
            // 
            this.cmbMaterialMB.FormattingEnabled = true;
            this.cmbMaterialMB.Items.AddRange(new object[] {
            "Acero",
            "Aluminio",
            "Titanio",
            "Fibra de Carbono"});
            this.cmbMaterialMB.Location = new System.Drawing.Point(119, 133);
            this.cmbMaterialMB.Name = "cmbMaterialMB";
            this.cmbMaterialMB.Size = new System.Drawing.Size(121, 21);
            this.cmbMaterialMB.TabIndex = 33;
            // 
            // lblMaterialMB
            // 
            this.lblMaterialMB.AutoSize = true;
            this.lblMaterialMB.Location = new System.Drawing.Point(13, 136);
            this.lblMaterialMB.Name = "lblMaterialMB";
            this.lblMaterialMB.Size = new System.Drawing.Size(44, 13);
            this.lblMaterialMB.TabIndex = 32;
            this.lblMaterialMB.Text = "Material";
            // 
            // cmbMaterialP
            // 
            this.cmbMaterialP.FormattingEnabled = true;
            this.cmbMaterialP.Items.AddRange(new object[] {
            "Acero",
            "Aluminio",
            "Titanio",
            "Fibra de Carbono"});
            this.cmbMaterialP.Location = new System.Drawing.Point(119, 328);
            this.cmbMaterialP.Name = "cmbMaterialP";
            this.cmbMaterialP.Size = new System.Drawing.Size(121, 21);
            this.cmbMaterialP.TabIndex = 35;
            // 
            // lblMaterialP
            // 
            this.lblMaterialP.AutoSize = true;
            this.lblMaterialP.Location = new System.Drawing.Point(13, 331);
            this.lblMaterialP.Name = "lblMaterialP";
            this.lblMaterialP.Size = new System.Drawing.Size(44, 13);
            this.lblMaterialP.TabIndex = 34;
            this.lblMaterialP.Text = "Material";
            // 
            // FrmOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 494);
            this.Controls.Add(this.cmbMaterialP);
            this.Controls.Add(this.lblMaterialP);
            this.Controls.Add(this.cmbMaterialMB);
            this.Controls.Add(this.lblMaterialMB);
            this.Controls.Add(this.numUDLuz);
            this.Controls.Add(this.lblCantidadLuz);
            this.Controls.Add(this.cmbColorLuz);
            this.Controls.Add(this.lblColorLuz);
            this.Controls.Add(this.lblLuz);
            this.Controls.Add(this.numUDCasco);
            this.Controls.Add(this.lblCantidadCasco);
            this.Controls.Add(this.cmbTalleCasco);
            this.Controls.Add(this.lblTallaCasco);
            this.Controls.Add(this.lblCasco);
            this.Controls.Add(this.lblAccesorios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.numUDPlayera);
            this.Controls.Add(this.numUDMountainBike);
            this.Controls.Add(this.lblCantidadP);
            this.Controls.Add(this.lblCantidadMB);
            this.Controls.Add(this.chkFrenos);
            this.Controls.Add(this.lblFrenos);
            this.Controls.Add(this.chkCambios);
            this.Controls.Add(this.lblCambios);
            this.Controls.Add(this.cmbCuadroP);
            this.Controls.Add(this.cmbCuadroMB);
            this.Controls.Add(this.lblCuadroP);
            this.Controls.Add(this.lblCuadroMB);
            this.Controls.Add(this.cmbRodadoP);
            this.Controls.Add(this.cmbRodadoMB);
            this.Controls.Add(this.lblRodadoP);
            this.Controls.Add(this.lblRodadoMB);
            this.Controls.Add(this.lblPlayera);
            this.Controls.Add(this.lblMountainBike);
            this.Controls.Add(this.lblBicicleta);
            this.Name = "FrmOrden";
            this.Text = "Nueva Orden";
            ((System.ComponentModel.ISupportInitialize)(this.numUDMountainBike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPlayera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCasco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDLuz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBicicleta;
        private System.Windows.Forms.Label lblMountainBike;
        private System.Windows.Forms.Label lblPlayera;
        private System.Windows.Forms.Label lblRodadoMB;
        private System.Windows.Forms.Label lblRodadoP;
        private System.Windows.Forms.ComboBox cmbRodadoMB;
        private System.Windows.Forms.ComboBox cmbRodadoP;
        private System.Windows.Forms.Label lblCuadroMB;
        private System.Windows.Forms.Label lblCuadroP;
        private System.Windows.Forms.ComboBox cmbCuadroMB;
        private System.Windows.Forms.ComboBox cmbCuadroP;
        private System.Windows.Forms.Label lblCambios;
        private System.Windows.Forms.CheckBox chkCambios;
        private System.Windows.Forms.Label lblFrenos;
        private System.Windows.Forms.CheckBox chkFrenos;
        private System.Windows.Forms.Label lblCantidadMB;
        private System.Windows.Forms.Label lblCantidadP;
        private System.Windows.Forms.NumericUpDown numUDMountainBike;
        private System.Windows.Forms.NumericUpDown numUDPlayera;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAccesorios;
        private System.Windows.Forms.Label lblCasco;
        private System.Windows.Forms.Label lblTallaCasco;
        private System.Windows.Forms.ComboBox cmbTalleCasco;
        private System.Windows.Forms.Label lblCantidadCasco;
        private System.Windows.Forms.NumericUpDown numUDCasco;
        private System.Windows.Forms.Label lblLuz;
        private System.Windows.Forms.Label lblColorLuz;
        private System.Windows.Forms.ComboBox cmbColorLuz;
        private System.Windows.Forms.Label lblCantidadLuz;
        private System.Windows.Forms.NumericUpDown numUDLuz;
        private System.Windows.Forms.ComboBox cmbMaterialMB;
        private System.Windows.Forms.Label lblMaterialMB;
        private System.Windows.Forms.ComboBox cmbMaterialP;
        private System.Windows.Forms.Label lblMaterialP;
    }
}