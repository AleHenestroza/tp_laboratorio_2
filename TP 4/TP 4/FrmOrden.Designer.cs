
namespace TP_4
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.splitProductos = new System.Windows.Forms.SplitContainer();
            this.splitBicicletas = new System.Windows.Forms.SplitContainer();
            this.lblTituloMB = new System.Windows.Forms.Label();
            this.rtbStockMaterial = new System.Windows.Forms.RichTextBox();
            this.lblStockMaterial = new System.Windows.Forms.Label();
            this.rtbMaterialNecesario = new System.Windows.Forms.RichTextBox();
            this.lblMaterialNeceario = new System.Windows.Forms.Label();
            this.chkCambios = new System.Windows.Forms.CheckBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cmbCuadro = new System.Windows.Forms.ComboBox();
            this.lblTamanio = new System.Windows.Forms.Label();
            this.cmbRodado = new System.Windows.Forms.ComboBox();
            this.lblRodado = new System.Windows.Forms.Label();
            this.lblTituloP = new System.Windows.Forms.Label();
            this.rtbStockMaterialPlayera = new System.Windows.Forms.RichTextBox();
            this.lblStockMaterial2 = new System.Windows.Forms.Label();
            this.rtbMaterialNecesarioPlayera = new System.Windows.Forms.RichTextBox();
            this.lblMaterialNecesario2 = new System.Windows.Forms.Label();
            this.chkFreno = new System.Windows.Forms.CheckBox();
            this.numCantidadPlayera = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad2 = new System.Windows.Forms.Label();
            this.cmbMaterialPlayera = new System.Windows.Forms.ComboBox();
            this.lblMaterial2 = new System.Windows.Forms.Label();
            this.cmbCuadroPlayera = new System.Windows.Forms.ComboBox();
            this.lblCuadro2 = new System.Windows.Forms.Label();
            this.cmbRodadoPlayera = new System.Windows.Forms.ComboBox();
            this.lblRodado2 = new System.Windows.Forms.Label();
            this.grpChkBicicletas = new System.Windows.Forms.GroupBox();
            this.chkPlayera = new System.Windows.Forms.CheckBox();
            this.chkMountainBike = new System.Windows.Forms.CheckBox();
            this.lblBicicletas = new System.Windows.Forms.Label();
            this.splitAccesorios = new System.Windows.Forms.SplitContainer();
            this.lblTituloCasco = new System.Windows.Forms.Label();
            this.numCantidadCasco = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad3 = new System.Windows.Forms.Label();
            this.cmbTalleCasco = new System.Windows.Forms.ComboBox();
            this.lblTalleCasco = new System.Windows.Forms.Label();
            this.lblTituloLuz = new System.Windows.Forms.Label();
            this.numCantidadLuz = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad4 = new System.Windows.Forms.Label();
            this.cmbColorLuz = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.grpChkAccesorios = new System.Windows.Forms.GroupBox();
            this.chkLuz = new System.Windows.Forms.CheckBox();
            this.chkCasco = new System.Windows.Forms.CheckBox();
            this.lblAccesorios = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitProductos)).BeginInit();
            this.splitProductos.Panel1.SuspendLayout();
            this.splitProductos.Panel2.SuspendLayout();
            this.splitProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitBicicletas)).BeginInit();
            this.splitBicicletas.Panel1.SuspendLayout();
            this.splitBicicletas.Panel2.SuspendLayout();
            this.splitBicicletas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadPlayera)).BeginInit();
            this.grpChkBicicletas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitAccesorios)).BeginInit();
            this.splitAccesorios.Panel1.SuspendLayout();
            this.splitAccesorios.Panel2.SuspendLayout();
            this.splitAccesorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadCasco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadLuz)).BeginInit();
            this.grpChkAccesorios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1060, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Generar Orden";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitProductos
            // 
            this.splitProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitProductos.IsSplitterFixed = true;
            this.splitProductos.Location = new System.Drawing.Point(16, 35);
            this.splitProductos.Name = "splitProductos";
            // 
            // splitProductos.Panel1
            // 
            this.splitProductos.Panel1.Controls.Add(this.splitBicicletas);
            this.splitProductos.Panel1.Controls.Add(this.grpChkBicicletas);
            this.splitProductos.Panel1.Controls.Add(this.lblBicicletas);
            this.splitProductos.Panel1MinSize = 526;
            // 
            // splitProductos.Panel2
            // 
            this.splitProductos.Panel2.Controls.Add(this.splitAccesorios);
            this.splitProductos.Panel2.Controls.Add(this.grpChkAccesorios);
            this.splitProductos.Panel2.Controls.Add(this.lblAccesorios);
            this.splitProductos.Panel2MinSize = 526;
            this.splitProductos.Size = new System.Drawing.Size(1056, 455);
            this.splitProductos.SplitterDistance = 526;
            this.splitProductos.TabIndex = 1;
            // 
            // splitBicicletas
            // 
            this.splitBicicletas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitBicicletas.IsSplitterFixed = true;
            this.splitBicicletas.Location = new System.Drawing.Point(3, 66);
            this.splitBicicletas.Name = "splitBicicletas";
            // 
            // splitBicicletas.Panel1
            // 
            this.splitBicicletas.Panel1.Controls.Add(this.lblTituloMB);
            this.splitBicicletas.Panel1.Controls.Add(this.rtbStockMaterial);
            this.splitBicicletas.Panel1.Controls.Add(this.lblStockMaterial);
            this.splitBicicletas.Panel1.Controls.Add(this.rtbMaterialNecesario);
            this.splitBicicletas.Panel1.Controls.Add(this.lblMaterialNeceario);
            this.splitBicicletas.Panel1.Controls.Add(this.chkCambios);
            this.splitBicicletas.Panel1.Controls.Add(this.numCantidad);
            this.splitBicicletas.Panel1.Controls.Add(this.lblCantidad);
            this.splitBicicletas.Panel1.Controls.Add(this.cmbMaterial);
            this.splitBicicletas.Panel1.Controls.Add(this.lblMaterial);
            this.splitBicicletas.Panel1.Controls.Add(this.cmbCuadro);
            this.splitBicicletas.Panel1.Controls.Add(this.lblTamanio);
            this.splitBicicletas.Panel1.Controls.Add(this.cmbRodado);
            this.splitBicicletas.Panel1.Controls.Add(this.lblRodado);
            this.splitBicicletas.Panel1.Enabled = false;
            // 
            // splitBicicletas.Panel2
            // 
            this.splitBicicletas.Panel2.Controls.Add(this.lblTituloP);
            this.splitBicicletas.Panel2.Controls.Add(this.rtbStockMaterialPlayera);
            this.splitBicicletas.Panel2.Controls.Add(this.lblStockMaterial2);
            this.splitBicicletas.Panel2.Controls.Add(this.rtbMaterialNecesarioPlayera);
            this.splitBicicletas.Panel2.Controls.Add(this.lblMaterialNecesario2);
            this.splitBicicletas.Panel2.Controls.Add(this.chkFreno);
            this.splitBicicletas.Panel2.Controls.Add(this.numCantidadPlayera);
            this.splitBicicletas.Panel2.Controls.Add(this.lblCantidad2);
            this.splitBicicletas.Panel2.Controls.Add(this.cmbMaterialPlayera);
            this.splitBicicletas.Panel2.Controls.Add(this.lblMaterial2);
            this.splitBicicletas.Panel2.Controls.Add(this.cmbCuadroPlayera);
            this.splitBicicletas.Panel2.Controls.Add(this.lblCuadro2);
            this.splitBicicletas.Panel2.Controls.Add(this.cmbRodadoPlayera);
            this.splitBicicletas.Panel2.Controls.Add(this.lblRodado2);
            this.splitBicicletas.Panel2.Enabled = false;
            this.splitBicicletas.Size = new System.Drawing.Size(518, 384);
            this.splitBicicletas.SplitterDistance = 252;
            this.splitBicicletas.TabIndex = 2;
            this.splitBicicletas.Visible = false;
            // 
            // lblTituloMB
            // 
            this.lblTituloMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMB.Location = new System.Drawing.Point(3, 2);
            this.lblTituloMB.Name = "lblTituloMB";
            this.lblTituloMB.Size = new System.Drawing.Size(244, 23);
            this.lblTituloMB.TabIndex = 14;
            this.lblTituloMB.Text = "Mountain Bike";
            this.lblTituloMB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbStockMaterial
            // 
            this.rtbStockMaterial.Location = new System.Drawing.Point(114, 341);
            this.rtbStockMaterial.Name = "rtbStockMaterial";
            this.rtbStockMaterial.ReadOnly = true;
            this.rtbStockMaterial.Size = new System.Drawing.Size(124, 23);
            this.rtbStockMaterial.TabIndex = 13;
            this.rtbStockMaterial.Text = "";
            // 
            // lblStockMaterial
            // 
            this.lblStockMaterial.AutoSize = true;
            this.lblStockMaterial.Location = new System.Drawing.Point(9, 346);
            this.lblStockMaterial.Name = "lblStockMaterial";
            this.lblStockMaterial.Size = new System.Drawing.Size(90, 13);
            this.lblStockMaterial.TabIndex = 12;
            this.lblStockMaterial.Text = "Material en Stock";
            // 
            // rtbMaterialNecesario
            // 
            this.rtbMaterialNecesario.Location = new System.Drawing.Point(114, 290);
            this.rtbMaterialNecesario.Name = "rtbMaterialNecesario";
            this.rtbMaterialNecesario.ReadOnly = true;
            this.rtbMaterialNecesario.Size = new System.Drawing.Size(124, 23);
            this.rtbMaterialNecesario.TabIndex = 11;
            this.rtbMaterialNecesario.Text = "";
            // 
            // lblMaterialNeceario
            // 
            this.lblMaterialNeceario.AutoSize = true;
            this.lblMaterialNeceario.Location = new System.Drawing.Point(9, 295);
            this.lblMaterialNeceario.Name = "lblMaterialNeceario";
            this.lblMaterialNeceario.Size = new System.Drawing.Size(95, 13);
            this.lblMaterialNeceario.TabIndex = 10;
            this.lblMaterialNeceario.Text = "Material Necesario";
            // 
            // chkCambios
            // 
            this.chkCambios.AutoSize = true;
            this.chkCambios.Location = new System.Drawing.Point(114, 245);
            this.chkCambios.Name = "chkCambios";
            this.chkCambios.Size = new System.Drawing.Size(88, 17);
            this.chkCambios.TabIndex = 9;
            this.chkCambios.Text = "Con Cambios";
            this.chkCambios.UseVisualStyleBackColor = true;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(114, 196);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(124, 20);
            this.numCantidad.TabIndex = 7;
            this.numCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCantidad.ValueChanged += new System.EventHandler(this.numCantidad_ValueChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(9, 200);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Items.AddRange(new object[] {
            "Acero",
            "Aluminio",
            "Titanio",
            "Fibra de Carbono"});
            this.cmbMaterial.Location = new System.Drawing.Point(114, 146);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(124, 21);
            this.cmbMaterial.TabIndex = 5;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(9, 151);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(44, 13);
            this.lblMaterial.TabIndex = 4;
            this.lblMaterial.Text = "Material";
            // 
            // cmbCuadro
            // 
            this.cmbCuadro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuadro.FormattingEnabled = true;
            this.cmbCuadro.Items.AddRange(new object[] {
            "47,5",
            "49,5",
            "51,5",
            "53,5",
            "55,5",
            "57,5",
            "59,5",
            "61"});
            this.cmbCuadro.Location = new System.Drawing.Point(114, 99);
            this.cmbCuadro.Name = "cmbCuadro";
            this.cmbCuadro.Size = new System.Drawing.Size(124, 21);
            this.cmbCuadro.TabIndex = 3;
            this.cmbCuadro.SelectedIndexChanged += new System.EventHandler(this.cmbCuadro_SelectedIndexChanged);
            // 
            // lblTamanio
            // 
            this.lblTamanio.AutoSize = true;
            this.lblTamanio.Location = new System.Drawing.Point(9, 103);
            this.lblTamanio.Name = "lblTamanio";
            this.lblTamanio.Size = new System.Drawing.Size(100, 13);
            this.lblTamanio.TabIndex = 2;
            this.lblTamanio.Text = "Tamaño del Cuadro";
            // 
            // cmbRodado
            // 
            this.cmbRodado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRodado.FormattingEnabled = true;
            this.cmbRodado.Items.AddRange(new object[] {
            "26",
            "27",
            "28"});
            this.cmbRodado.Location = new System.Drawing.Point(114, 53);
            this.cmbRodado.Name = "cmbRodado";
            this.cmbRodado.Size = new System.Drawing.Size(124, 21);
            this.cmbRodado.TabIndex = 1;
            // 
            // lblRodado
            // 
            this.lblRodado.AutoSize = true;
            this.lblRodado.Location = new System.Drawing.Point(9, 59);
            this.lblRodado.Name = "lblRodado";
            this.lblRodado.Size = new System.Drawing.Size(45, 13);
            this.lblRodado.TabIndex = 0;
            this.lblRodado.Text = "Rodado";
            // 
            // lblTituloP
            // 
            this.lblTituloP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloP.Location = new System.Drawing.Point(3, 2);
            this.lblTituloP.Name = "lblTituloP";
            this.lblTituloP.Size = new System.Drawing.Size(254, 23);
            this.lblTituloP.TabIndex = 15;
            this.lblTituloP.Text = "Playera";
            this.lblTituloP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbStockMaterialPlayera
            // 
            this.rtbStockMaterialPlayera.Location = new System.Drawing.Point(121, 341);
            this.rtbStockMaterialPlayera.Name = "rtbStockMaterialPlayera";
            this.rtbStockMaterialPlayera.ReadOnly = true;
            this.rtbStockMaterialPlayera.Size = new System.Drawing.Size(124, 23);
            this.rtbStockMaterialPlayera.TabIndex = 26;
            this.rtbStockMaterialPlayera.Text = "";
            // 
            // lblStockMaterial2
            // 
            this.lblStockMaterial2.AutoSize = true;
            this.lblStockMaterial2.Location = new System.Drawing.Point(16, 346);
            this.lblStockMaterial2.Name = "lblStockMaterial2";
            this.lblStockMaterial2.Size = new System.Drawing.Size(90, 13);
            this.lblStockMaterial2.TabIndex = 25;
            this.lblStockMaterial2.Text = "Material en Stock";
            // 
            // rtbMaterialNecesarioPlayera
            // 
            this.rtbMaterialNecesarioPlayera.Location = new System.Drawing.Point(121, 290);
            this.rtbMaterialNecesarioPlayera.Name = "rtbMaterialNecesarioPlayera";
            this.rtbMaterialNecesarioPlayera.ReadOnly = true;
            this.rtbMaterialNecesarioPlayera.Size = new System.Drawing.Size(124, 23);
            this.rtbMaterialNecesarioPlayera.TabIndex = 24;
            this.rtbMaterialNecesarioPlayera.Text = "";
            // 
            // lblMaterialNecesario2
            // 
            this.lblMaterialNecesario2.AutoSize = true;
            this.lblMaterialNecesario2.Location = new System.Drawing.Point(16, 295);
            this.lblMaterialNecesario2.Name = "lblMaterialNecesario2";
            this.lblMaterialNecesario2.Size = new System.Drawing.Size(95, 13);
            this.lblMaterialNecesario2.TabIndex = 23;
            this.lblMaterialNecesario2.Text = "Material Necesario";
            // 
            // chkFreno
            // 
            this.chkFreno.AutoSize = true;
            this.chkFreno.Location = new System.Drawing.Point(121, 245);
            this.chkFreno.Name = "chkFreno";
            this.chkFreno.Size = new System.Drawing.Size(75, 17);
            this.chkFreno.TabIndex = 22;
            this.chkFreno.Text = "Con Freno";
            this.chkFreno.UseVisualStyleBackColor = true;
            // 
            // numCantidadPlayera
            // 
            this.numCantidadPlayera.Location = new System.Drawing.Point(121, 196);
            this.numCantidadPlayera.Name = "numCantidadPlayera";
            this.numCantidadPlayera.Size = new System.Drawing.Size(124, 20);
            this.numCantidadPlayera.TabIndex = 21;
            this.numCantidadPlayera.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCantidadPlayera.ValueChanged += new System.EventHandler(this.numCantidadPlayera_ValueChanged);
            // 
            // lblCantidad2
            // 
            this.lblCantidad2.AutoSize = true;
            this.lblCantidad2.Location = new System.Drawing.Point(16, 200);
            this.lblCantidad2.Name = "lblCantidad2";
            this.lblCantidad2.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad2.TabIndex = 20;
            this.lblCantidad2.Text = "Cantidad";
            // 
            // cmbMaterialPlayera
            // 
            this.cmbMaterialPlayera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterialPlayera.FormattingEnabled = true;
            this.cmbMaterialPlayera.Items.AddRange(new object[] {
            "Acero",
            "Aluminio",
            "Titanio",
            "Fibra de Carbono"});
            this.cmbMaterialPlayera.Location = new System.Drawing.Point(121, 146);
            this.cmbMaterialPlayera.Name = "cmbMaterialPlayera";
            this.cmbMaterialPlayera.Size = new System.Drawing.Size(124, 21);
            this.cmbMaterialPlayera.TabIndex = 19;
            this.cmbMaterialPlayera.SelectedIndexChanged += new System.EventHandler(this.cmbMaterialPlayera_SelectedIndexChanged);
            // 
            // lblMaterial2
            // 
            this.lblMaterial2.AutoSize = true;
            this.lblMaterial2.Location = new System.Drawing.Point(16, 151);
            this.lblMaterial2.Name = "lblMaterial2";
            this.lblMaterial2.Size = new System.Drawing.Size(44, 13);
            this.lblMaterial2.TabIndex = 18;
            this.lblMaterial2.Text = "Material";
            // 
            // cmbCuadroPlayera
            // 
            this.cmbCuadroPlayera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuadroPlayera.FormattingEnabled = true;
            this.cmbCuadroPlayera.Items.AddRange(new object[] {
            "41,5",
            "43,5",
            "45,5",
            "47,5",
            "49,5",
            "51,5",
            "53,5",
            "55,5",
            "57,5"});
            this.cmbCuadroPlayera.Location = new System.Drawing.Point(121, 99);
            this.cmbCuadroPlayera.Name = "cmbCuadroPlayera";
            this.cmbCuadroPlayera.Size = new System.Drawing.Size(124, 21);
            this.cmbCuadroPlayera.TabIndex = 17;
            this.cmbCuadroPlayera.SelectedIndexChanged += new System.EventHandler(this.cmbCuadroPlayera_SelectedIndexChanged);
            // 
            // lblCuadro2
            // 
            this.lblCuadro2.AutoSize = true;
            this.lblCuadro2.Location = new System.Drawing.Point(16, 103);
            this.lblCuadro2.Name = "lblCuadro2";
            this.lblCuadro2.Size = new System.Drawing.Size(100, 13);
            this.lblCuadro2.TabIndex = 16;
            this.lblCuadro2.Text = "Tamaño del Cuadro";
            // 
            // cmbRodadoPlayera
            // 
            this.cmbRodadoPlayera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRodadoPlayera.FormattingEnabled = true;
            this.cmbRodadoPlayera.Items.AddRange(new object[] {
            "20",
            "22",
            "24",
            "26",
            "28"});
            this.cmbRodadoPlayera.Location = new System.Drawing.Point(121, 53);
            this.cmbRodadoPlayera.Name = "cmbRodadoPlayera";
            this.cmbRodadoPlayera.Size = new System.Drawing.Size(124, 21);
            this.cmbRodadoPlayera.TabIndex = 15;
            // 
            // lblRodado2
            // 
            this.lblRodado2.AutoSize = true;
            this.lblRodado2.Location = new System.Drawing.Point(16, 59);
            this.lblRodado2.Name = "lblRodado2";
            this.lblRodado2.Size = new System.Drawing.Size(45, 13);
            this.lblRodado2.TabIndex = 14;
            this.lblRodado2.Text = "Rodado";
            // 
            // grpChkBicicletas
            // 
            this.grpChkBicicletas.Controls.Add(this.chkPlayera);
            this.grpChkBicicletas.Controls.Add(this.chkMountainBike);
            this.grpChkBicicletas.Location = new System.Drawing.Point(6, 26);
            this.grpChkBicicletas.Name = "grpChkBicicletas";
            this.grpChkBicicletas.Size = new System.Drawing.Size(515, 40);
            this.grpChkBicicletas.TabIndex = 1;
            this.grpChkBicicletas.TabStop = false;
            // 
            // chkPlayera
            // 
            this.chkPlayera.AutoSize = true;
            this.chkPlayera.Location = new System.Drawing.Point(340, 17);
            this.chkPlayera.Name = "chkPlayera";
            this.chkPlayera.Size = new System.Drawing.Size(101, 17);
            this.chkPlayera.TabIndex = 1;
            this.chkPlayera.Text = "Agregar Playera";
            this.chkPlayera.UseVisualStyleBackColor = true;
            this.chkPlayera.CheckedChanged += new System.EventHandler(this.chkPlayera_CheckedChanged);
            // 
            // chkMountainBike
            // 
            this.chkMountainBike.AutoSize = true;
            this.chkMountainBike.Location = new System.Drawing.Point(31, 17);
            this.chkMountainBike.Name = "chkMountainBike";
            this.chkMountainBike.Size = new System.Drawing.Size(134, 17);
            this.chkMountainBike.TabIndex = 0;
            this.chkMountainBike.Text = "Agregar Mountain Bike";
            this.chkMountainBike.UseVisualStyleBackColor = true;
            this.chkMountainBike.CheckedChanged += new System.EventHandler(this.chkMountainBike_CheckedChanged);
            // 
            // lblBicicletas
            // 
            this.lblBicicletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBicicletas.Location = new System.Drawing.Point(3, 0);
            this.lblBicicletas.Name = "lblBicicletas";
            this.lblBicicletas.Size = new System.Drawing.Size(518, 23);
            this.lblBicicletas.TabIndex = 0;
            this.lblBicicletas.Text = "Bicicletas";
            this.lblBicicletas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitAccesorios
            // 
            this.splitAccesorios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitAccesorios.IsSplitterFixed = true;
            this.splitAccesorios.Location = new System.Drawing.Point(3, 66);
            this.splitAccesorios.Name = "splitAccesorios";
            // 
            // splitAccesorios.Panel1
            // 
            this.splitAccesorios.Panel1.Controls.Add(this.lblTituloCasco);
            this.splitAccesorios.Panel1.Controls.Add(this.numCantidadCasco);
            this.splitAccesorios.Panel1.Controls.Add(this.lblCantidad3);
            this.splitAccesorios.Panel1.Controls.Add(this.cmbTalleCasco);
            this.splitAccesorios.Panel1.Controls.Add(this.lblTalleCasco);
            this.splitAccesorios.Panel1.Enabled = false;
            // 
            // splitAccesorios.Panel2
            // 
            this.splitAccesorios.Panel2.Controls.Add(this.lblTituloLuz);
            this.splitAccesorios.Panel2.Controls.Add(this.numCantidadLuz);
            this.splitAccesorios.Panel2.Controls.Add(this.lblCantidad4);
            this.splitAccesorios.Panel2.Controls.Add(this.cmbColorLuz);
            this.splitAccesorios.Panel2.Controls.Add(this.lblColor);
            this.splitAccesorios.Panel2.Enabled = false;
            this.splitAccesorios.Size = new System.Drawing.Size(518, 384);
            this.splitAccesorios.SplitterDistance = 252;
            this.splitAccesorios.TabIndex = 3;
            this.splitAccesorios.Visible = false;
            // 
            // lblTituloCasco
            // 
            this.lblTituloCasco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCasco.Location = new System.Drawing.Point(3, 2);
            this.lblTituloCasco.Name = "lblTituloCasco";
            this.lblTituloCasco.Size = new System.Drawing.Size(244, 23);
            this.lblTituloCasco.TabIndex = 14;
            this.lblTituloCasco.Text = "Casco";
            this.lblTituloCasco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numCantidadCasco
            // 
            this.numCantidadCasco.Location = new System.Drawing.Point(114, 100);
            this.numCantidadCasco.Name = "numCantidadCasco";
            this.numCantidadCasco.Size = new System.Drawing.Size(124, 20);
            this.numCantidadCasco.TabIndex = 7;
            this.numCantidadCasco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCantidad3
            // 
            this.lblCantidad3.AutoSize = true;
            this.lblCantidad3.Location = new System.Drawing.Point(9, 104);
            this.lblCantidad3.Name = "lblCantidad3";
            this.lblCantidad3.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad3.TabIndex = 6;
            this.lblCantidad3.Text = "Cantidad";
            // 
            // cmbTalleCasco
            // 
            this.cmbTalleCasco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbTalleCasco.Location = new System.Drawing.Point(114, 53);
            this.cmbTalleCasco.Name = "cmbTalleCasco";
            this.cmbTalleCasco.Size = new System.Drawing.Size(124, 21);
            this.cmbTalleCasco.TabIndex = 1;
            // 
            // lblTalleCasco
            // 
            this.lblTalleCasco.AutoSize = true;
            this.lblTalleCasco.Location = new System.Drawing.Point(9, 59);
            this.lblTalleCasco.Name = "lblTalleCasco";
            this.lblTalleCasco.Size = new System.Drawing.Size(30, 13);
            this.lblTalleCasco.TabIndex = 0;
            this.lblTalleCasco.Text = "Talle";
            // 
            // lblTituloLuz
            // 
            this.lblTituloLuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLuz.Location = new System.Drawing.Point(3, 2);
            this.lblTituloLuz.Name = "lblTituloLuz";
            this.lblTituloLuz.Size = new System.Drawing.Size(254, 23);
            this.lblTituloLuz.TabIndex = 15;
            this.lblTituloLuz.Text = "Luz";
            this.lblTituloLuz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numCantidadLuz
            // 
            this.numCantidadLuz.Location = new System.Drawing.Point(121, 100);
            this.numCantidadLuz.Name = "numCantidadLuz";
            this.numCantidadLuz.Size = new System.Drawing.Size(124, 20);
            this.numCantidadLuz.TabIndex = 21;
            this.numCantidadLuz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCantidad4
            // 
            this.lblCantidad4.AutoSize = true;
            this.lblCantidad4.Location = new System.Drawing.Point(16, 104);
            this.lblCantidad4.Name = "lblCantidad4";
            this.lblCantidad4.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad4.TabIndex = 20;
            this.lblCantidad4.Text = "Cantidad";
            // 
            // cmbColorLuz
            // 
            this.cmbColorLuz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorLuz.FormattingEnabled = true;
            this.cmbColorLuz.Items.AddRange(new object[] {
            "Roja",
            "Blanca",
            "Amarilla"});
            this.cmbColorLuz.Location = new System.Drawing.Point(121, 53);
            this.cmbColorLuz.Name = "cmbColorLuz";
            this.cmbColorLuz.Size = new System.Drawing.Size(124, 21);
            this.cmbColorLuz.TabIndex = 15;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(16, 59);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 14;
            this.lblColor.Text = "Color";
            // 
            // grpChkAccesorios
            // 
            this.grpChkAccesorios.Controls.Add(this.chkLuz);
            this.grpChkAccesorios.Controls.Add(this.chkCasco);
            this.grpChkAccesorios.Location = new System.Drawing.Point(6, 26);
            this.grpChkAccesorios.Name = "grpChkAccesorios";
            this.grpChkAccesorios.Size = new System.Drawing.Size(515, 40);
            this.grpChkAccesorios.TabIndex = 2;
            this.grpChkAccesorios.TabStop = false;
            // 
            // chkLuz
            // 
            this.chkLuz.AutoSize = true;
            this.chkLuz.Location = new System.Drawing.Point(340, 17);
            this.chkLuz.Name = "chkLuz";
            this.chkLuz.Size = new System.Drawing.Size(83, 17);
            this.chkLuz.TabIndex = 1;
            this.chkLuz.Text = "Agregar Luz";
            this.chkLuz.UseVisualStyleBackColor = true;
            this.chkLuz.CheckedChanged += new System.EventHandler(this.chkLuz_CheckedChanged);
            // 
            // chkCasco
            // 
            this.chkCasco.AutoSize = true;
            this.chkCasco.Location = new System.Drawing.Point(49, 17);
            this.chkCasco.Name = "chkCasco";
            this.chkCasco.Size = new System.Drawing.Size(96, 17);
            this.chkCasco.TabIndex = 0;
            this.chkCasco.Text = "Agregar Casco";
            this.chkCasco.UseVisualStyleBackColor = true;
            this.chkCasco.CheckedChanged += new System.EventHandler(this.chkCasco_CheckedChanged);
            // 
            // lblAccesorios
            // 
            this.lblAccesorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccesorios.Location = new System.Drawing.Point(3, 0);
            this.lblAccesorios.Name = "lblAccesorios";
            this.lblAccesorios.Size = new System.Drawing.Size(518, 23);
            this.lblAccesorios.TabIndex = 0;
            this.lblAccesorios.Text = "Accesorios";
            this.lblAccesorios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(489, 507);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(111, 54);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Crear Orden";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 573);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.splitProductos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrden";
            this.Text = "FrmOrden";
            this.splitProductos.Panel1.ResumeLayout(false);
            this.splitProductos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitProductos)).EndInit();
            this.splitProductos.ResumeLayout(false);
            this.splitBicicletas.Panel1.ResumeLayout(false);
            this.splitBicicletas.Panel1.PerformLayout();
            this.splitBicicletas.Panel2.ResumeLayout(false);
            this.splitBicicletas.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitBicicletas)).EndInit();
            this.splitBicicletas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadPlayera)).EndInit();
            this.grpChkBicicletas.ResumeLayout(false);
            this.grpChkBicicletas.PerformLayout();
            this.splitAccesorios.Panel1.ResumeLayout(false);
            this.splitAccesorios.Panel1.PerformLayout();
            this.splitAccesorios.Panel2.ResumeLayout(false);
            this.splitAccesorios.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitAccesorios)).EndInit();
            this.splitAccesorios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadCasco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadLuz)).EndInit();
            this.grpChkAccesorios.ResumeLayout(false);
            this.grpChkAccesorios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.SplitContainer splitProductos;
        private System.Windows.Forms.SplitContainer splitBicicletas;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbCuadro;
        private System.Windows.Forms.Label lblTamanio;
        private System.Windows.Forms.ComboBox cmbRodado;
        private System.Windows.Forms.Label lblRodado;
        private System.Windows.Forms.GroupBox grpChkBicicletas;
        private System.Windows.Forms.CheckBox chkPlayera;
        private System.Windows.Forms.CheckBox chkMountainBike;
        private System.Windows.Forms.Label lblBicicletas;
        private System.Windows.Forms.Label lblAccesorios;
        private System.Windows.Forms.RichTextBox rtbStockMaterial;
        private System.Windows.Forms.Label lblStockMaterial;
        private System.Windows.Forms.RichTextBox rtbMaterialNecesario;
        private System.Windows.Forms.Label lblMaterialNeceario;
        private System.Windows.Forms.CheckBox chkCambios;
        private System.Windows.Forms.RichTextBox rtbStockMaterialPlayera;
        private System.Windows.Forms.Label lblStockMaterial2;
        private System.Windows.Forms.RichTextBox rtbMaterialNecesarioPlayera;
        private System.Windows.Forms.Label lblMaterialNecesario2;
        private System.Windows.Forms.CheckBox chkFreno;
        private System.Windows.Forms.NumericUpDown numCantidadPlayera;
        private System.Windows.Forms.Label lblCantidad2;
        private System.Windows.Forms.ComboBox cmbMaterialPlayera;
        private System.Windows.Forms.Label lblMaterial2;
        private System.Windows.Forms.ComboBox cmbCuadroPlayera;
        private System.Windows.Forms.Label lblCuadro2;
        private System.Windows.Forms.ComboBox cmbRodadoPlayera;
        private System.Windows.Forms.Label lblRodado2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTituloMB;
        private System.Windows.Forms.Label lblTituloP;
        private System.Windows.Forms.SplitContainer splitAccesorios;
        private System.Windows.Forms.Label lblTituloCasco;
        private System.Windows.Forms.NumericUpDown numCantidadCasco;
        private System.Windows.Forms.Label lblCantidad3;
        private System.Windows.Forms.ComboBox cmbTalleCasco;
        private System.Windows.Forms.Label lblTalleCasco;
        private System.Windows.Forms.Label lblTituloLuz;
        private System.Windows.Forms.NumericUpDown numCantidadLuz;
        private System.Windows.Forms.Label lblCantidad4;
        private System.Windows.Forms.ComboBox cmbColorLuz;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.GroupBox grpChkAccesorios;
        private System.Windows.Forms.CheckBox chkLuz;
        private System.Windows.Forms.CheckBox chkCasco;
    }
}