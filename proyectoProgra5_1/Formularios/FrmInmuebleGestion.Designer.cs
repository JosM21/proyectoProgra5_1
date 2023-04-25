namespace proyectoProgra5_1.Formularios
{
    partial class FrmInmuebleGestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar1 = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtContacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbTipoInmueble = new System.Windows.Forms.ComboBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtConstruccion = new System.Windows.Forms.TextBox();
            this.TxtHabitaciones = new System.Windows.Forms.TextBox();
            this.TxtBanio = new System.Windows.Forms.TextBox();
            this.TxtTerreno = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtIdInmueble = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.CidInmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CnumeroLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cprecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CboxVerActivos = new System.Windows.Forms.CheckBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(853, 280);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(181, 50);
            this.BtnCancelar.TabIndex = 24;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(654, 280);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(181, 50);
            this.BtnLimpiar.TabIndex = 23;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(455, 280);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(181, 50);
            this.BtnEliminar.TabIndex = 22;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar1
            // 
            this.BtnModificar1.BackColor = System.Drawing.Color.Orange;
            this.BtnModificar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar1.ForeColor = System.Drawing.Color.White;
            this.BtnModificar1.Location = new System.Drawing.Point(256, 280);
            this.BtnModificar1.Name = "BtnModificar1";
            this.BtnModificar1.Size = new System.Drawing.Size(181, 50);
            this.BtnModificar1.TabIndex = 21;
            this.BtnModificar1.Text = "Modificar";
            this.BtnModificar1.UseVisualStyleBackColor = false;
            this.BtnModificar1.Click += new System.EventHandler(this.BtnModificar1_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(57, 280);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(181, 50);
            this.BtnAgregar.TabIndex = 20;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtContacto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtLote);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CbTipoInmueble);
            this.groupBox2.Controls.Add(this.TxtDescripcion);
            this.groupBox2.Controls.Add(this.TxtConstruccion);
            this.groupBox2.Controls.Add(this.TxtHabitaciones);
            this.groupBox2.Controls.Add(this.TxtBanio);
            this.groupBox2.Controls.Add(this.TxtTerreno);
            this.groupBox2.Controls.Add(this.TxtPrecio);
            this.groupBox2.Controls.Add(this.TxtIdInmueble);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DeepPink;
            this.groupBox2.Location = new System.Drawing.Point(57, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(978, 248);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Inmueble";
            // 
            // TxtContacto
            // 
            this.TxtContacto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtContacto.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtContacto.Location = new System.Drawing.Point(630, 156);
            this.TxtContacto.Name = "TxtContacto";
            this.TxtContacto.Size = new System.Drawing.Size(321, 30);
            this.TxtContacto.TabIndex = 20;
            this.TxtContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContacto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Contacto:";
            // 
            // TxtLote
            // 
            this.TxtLote.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtLote.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtLote.Location = new System.Drawing.Point(128, 201);
            this.TxtLote.Name = "TxtLote";
            this.TxtLote.Size = new System.Drawing.Size(298, 30);
            this.TxtLote.TabIndex = 18;
            this.TxtLote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLote_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "# Lote:";
            // 
            // CbTipoInmueble
            // 
            this.CbTipoInmueble.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CbTipoInmueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoInmueble.ForeColor = System.Drawing.Color.DeepPink;
            this.CbTipoInmueble.FormattingEnabled = true;
            this.CbTipoInmueble.Location = new System.Drawing.Point(630, 34);
            this.CbTipoInmueble.Name = "CbTipoInmueble";
            this.CbTipoInmueble.Size = new System.Drawing.Size(321, 33);
            this.CbTipoInmueble.TabIndex = 16;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtDescripcion.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtDescripcion.Location = new System.Drawing.Point(630, 196);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDescripcion.Size = new System.Drawing.Size(321, 35);
            this.TxtDescripcion.TabIndex = 15;
            this.TxtDescripcion.UseSystemPasswordChar = true;
            this.TxtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            // 
            // TxtConstruccion
            // 
            this.TxtConstruccion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtConstruccion.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtConstruccion.Location = new System.Drawing.Point(630, 117);
            this.TxtConstruccion.Name = "TxtConstruccion";
            this.TxtConstruccion.Size = new System.Drawing.Size(321, 30);
            this.TxtConstruccion.TabIndex = 14;
            this.TxtConstruccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConstruccion_KeyPress);
            // 
            // TxtHabitaciones
            // 
            this.TxtHabitaciones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtHabitaciones.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtHabitaciones.Location = new System.Drawing.Point(630, 77);
            this.TxtHabitaciones.Name = "TxtHabitaciones";
            this.TxtHabitaciones.Size = new System.Drawing.Size(321, 30);
            this.TxtHabitaciones.TabIndex = 13;
            this.TxtHabitaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHabitaciones_KeyPress);
            // 
            // TxtBanio
            // 
            this.TxtBanio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtBanio.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtBanio.Location = new System.Drawing.Point(128, 160);
            this.TxtBanio.Name = "TxtBanio";
            this.TxtBanio.Size = new System.Drawing.Size(298, 30);
            this.TxtBanio.TabIndex = 11;
            this.TxtBanio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBanio_KeyPress);
            // 
            // TxtTerreno
            // 
            this.TxtTerreno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtTerreno.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtTerreno.Location = new System.Drawing.Point(128, 119);
            this.TxtTerreno.Name = "TxtTerreno";
            this.TxtTerreno.Size = new System.Drawing.Size(298, 30);
            this.TxtTerreno.TabIndex = 10;
            this.TxtTerreno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTerreno_KeyPress);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtPrecio.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtPrecio.Location = new System.Drawing.Point(128, 78);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(298, 30);
            this.TxtPrecio.TabIndex = 9;
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // TxtIdInmueble
            // 
            this.TxtIdInmueble.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtIdInmueble.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtIdInmueble.Location = new System.Drawing.Point(128, 37);
            this.TxtIdInmueble.Name = "TxtIdInmueble";
            this.TxtIdInmueble.ReadOnly = true;
            this.TxtIdInmueble.Size = new System.Drawing.Size(298, 30);
            this.TxtIdInmueble.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Descripción:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Construcción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(451, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Habitaciones:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Baños:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Terreno:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Precio:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Codigo:";
            // 
            // DgLista
            // 
            this.DgLista.AllowUserToAddRows = false;
            this.DgLista.AllowUserToDeleteRows = false;
            this.DgLista.AllowUserToOrderColumns = true;
            this.DgLista.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CidInmueble,
            this.CnumeroLote,
            this.Cprecio,
            this.Cdescripcion,
            this.Cnombre,
            this.Ctelefono});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgLista.Location = new System.Drawing.Point(57, 352);
            this.DgLista.MultiSelect = false;
            this.DgLista.Name = "DgLista";
            this.DgLista.ReadOnly = true;
            this.DgLista.RowHeadersVisible = false;
            this.DgLista.RowHeadersWidth = 51;
            this.DgLista.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DeepPink;
            this.DgLista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Violet;
            this.DgLista.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DgLista.RowTemplate.Height = 24;
            this.DgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgLista.Size = new System.Drawing.Size(978, 229);
            this.DgLista.TabIndex = 18;
            this.DgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLista_CellClick);
            this.DgLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgLista_DataBindingComplete);
            // 
            // CidInmueble
            // 
            this.CidInmueble.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CidInmueble.DataPropertyName = "idInmueble";
            this.CidInmueble.HeaderText = "Codigo";
            this.CidInmueble.MinimumWidth = 6;
            this.CidInmueble.Name = "CidInmueble";
            this.CidInmueble.ReadOnly = true;
            this.CidInmueble.Width = 125;
            // 
            // CnumeroLote
            // 
            this.CnumeroLote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CnumeroLote.DataPropertyName = "numeroLote";
            this.CnumeroLote.HeaderText = "# Lote";
            this.CnumeroLote.MinimumWidth = 6;
            this.CnumeroLote.Name = "CnumeroLote";
            this.CnumeroLote.ReadOnly = true;
            this.CnumeroLote.Width = 125;
            // 
            // Cprecio
            // 
            this.Cprecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cprecio.DataPropertyName = "precio";
            this.Cprecio.HeaderText = "Precio";
            this.Cprecio.MinimumWidth = 6;
            this.Cprecio.Name = "Cprecio";
            this.Cprecio.ReadOnly = true;
            this.Cprecio.Width = 150;
            // 
            // Cdescripcion
            // 
            this.Cdescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cdescripcion.DataPropertyName = "descripcion";
            this.Cdescripcion.HeaderText = "Tipo";
            this.Cdescripcion.MinimumWidth = 6;
            this.Cdescripcion.Name = "Cdescripcion";
            this.Cdescripcion.ReadOnly = true;
            this.Cdescripcion.Width = 125;
            // 
            // Cnombre
            // 
            this.Cnombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cnombre.DataPropertyName = "nombre";
            this.Cnombre.HeaderText = "Dueño";
            this.Cnombre.MinimumWidth = 6;
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.ReadOnly = true;
            // 
            // Ctelefono
            // 
            this.Ctelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ctelefono.DataPropertyName = "telefono";
            this.Ctelefono.HeaderText = "Telefono";
            this.Ctelefono.MinimumWidth = 6;
            this.Ctelefono.Name = "Ctelefono";
            this.Ctelefono.ReadOnly = true;
            this.Ctelefono.Width = 125;
            // 
            // CboxVerActivos
            // 
            this.CboxVerActivos.AutoSize = true;
            this.CboxVerActivos.Checked = true;
            this.CboxVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CboxVerActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxVerActivos.ForeColor = System.Drawing.Color.DeepPink;
            this.CboxVerActivos.Location = new System.Drawing.Point(900, 603);
            this.CboxVerActivos.Name = "CboxVerActivos";
            this.CboxVerActivos.Size = new System.Drawing.Size(134, 29);
            this.CboxVerActivos.TabIndex = 17;
            this.CboxVerActivos.Text = "Ver Activos";
            this.CboxVerActivos.UseVisualStyleBackColor = true;
            this.CboxVerActivos.CheckedChanged += new System.EventHandler(this.CboxVerActivos_CheckedChanged);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtBuscar.Location = new System.Drawing.Point(152, 601);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(726, 30);
            this.TxtBuscar.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(52, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Buscar";
            // 
            // FrmInmuebleGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1096, 654);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.CboxVerActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "FrmInmuebleGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Inmueble";
            this.Load += new System.EventHandler(this.FrmInmuebleGestion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbTipoInmueble;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtConstruccion;
        private System.Windows.Forms.TextBox TxtHabitaciones;
        private System.Windows.Forms.TextBox TxtBanio;
        private System.Windows.Forms.TextBox TxtTerreno;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtIdInmueble;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView DgLista;
        private System.Windows.Forms.CheckBox CboxVerActivos;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtContacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidInmueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn CnumeroLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cprecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctelefono;
    }
}