namespace proyectoProgra5_1.Formularios
{
    partial class FrmClienteGestion1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtTelefonos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.CboxVerActivos = new System.Windows.Forms.CheckBox();
            this.CidCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtBuscar.Location = new System.Drawing.Point(160, 595);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(631, 30);
            this.TxtBuscar.TabIndex = 50;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(62, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Buscar";
            // 
            // DgLista
            // 
            this.DgLista.AllowUserToAddRows = false;
            this.DgLista.AllowUserToDeleteRows = false;
            this.DgLista.AllowUserToOrderColumns = true;
            this.DgLista.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CidCliente,
            this.Cnombre,
            this.Ccedula,
            this.Ctelefono,
            this.Cemail});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgLista.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgLista.Location = new System.Drawing.Point(61, 314);
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
            this.DgLista.Size = new System.Drawing.Size(978, 254);
            this.DgLista.TabIndex = 48;
            this.DgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLista_CellClick);
            this.DgLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgLista_DataBindingComplete);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(857, 233);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(181, 50);
            this.BtnCancelar.TabIndex = 47;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(658, 233);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(181, 50);
            this.BtnLimpiar.TabIndex = 46;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click_1);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(459, 233);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(181, 50);
            this.BtnEliminar.TabIndex = 45;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Orange;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(260, 233);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(181, 50);
            this.BtnModificar.TabIndex = 44;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(61, 233);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(181, 50);
            this.BtnAgregar.TabIndex = 43;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtTelefonos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtDireccion);
            this.groupBox2.Controls.Add(this.TxtEmail);
            this.groupBox2.Controls.Add(this.TxtCedula);
            this.groupBox2.Controls.Add(this.TxtNombre);
            this.groupBox2.Controls.Add(this.TxtIdCliente);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DeepPink;
            this.groupBox2.Location = new System.Drawing.Point(60, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(978, 215);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Cliente";
            // 
            // TxtTelefonos
            // 
            this.TxtTelefonos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtTelefonos.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtTelefonos.Location = new System.Drawing.Point(619, 42);
            this.TxtTelefonos.Name = "TxtTelefonos";
            this.TxtTelefonos.Size = new System.Drawing.Size(321, 30);
            this.TxtTelefonos.TabIndex = 51;
            this.TxtTelefonos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonos_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cedula:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtDireccion.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtDireccion.Location = new System.Drawing.Point(619, 83);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDireccion.Size = new System.Drawing.Size(321, 113);
            this.TxtDireccion.TabIndex = 15;
            this.TxtDireccion.UseSystemPasswordChar = true;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtEmail.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtEmail.Location = new System.Drawing.Point(137, 166);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(298, 30);
            this.TxtEmail.TabIndex = 13;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // TxtCedula
            // 
            this.TxtCedula.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtCedula.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtCedula.Location = new System.Drawing.Point(137, 124);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(298, 30);
            this.TxtCedula.TabIndex = 11;
            this.TxtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtNombre.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtNombre.Location = new System.Drawing.Point(137, 81);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(298, 30);
            this.TxtNombre.TabIndex = 9;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtIdCliente.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtIdCliente.Location = new System.Drawing.Point(137, 42);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.ReadOnly = true;
            this.TxtIdCliente.Size = new System.Drawing.Size(298, 30);
            this.TxtIdCliente.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Direccion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(455, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Telefono:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nombre:";
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.ForeColor = System.Drawing.Color.DeepPink;
            this.textBox1.Location = new System.Drawing.Point(630, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 22);
            this.textBox1.TabIndex = 17;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtTelefono.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtTelefono.Location = new System.Drawing.Point(630, 39);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(321, 22);
            this.TxtTelefono.TabIndex = 17;
            // 
            // CboxVerActivos
            // 
            this.CboxVerActivos.AutoSize = true;
            this.CboxVerActivos.Checked = true;
            this.CboxVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CboxVerActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxVerActivos.ForeColor = System.Drawing.Color.DeepPink;
            this.CboxVerActivos.Location = new System.Drawing.Point(826, 594);
            this.CboxVerActivos.Name = "CboxVerActivos";
            this.CboxVerActivos.Size = new System.Drawing.Size(212, 29);
            this.CboxVerActivos.TabIndex = 51;
            this.CboxVerActivos.Text = "Ver Agentes Activos";
            this.CboxVerActivos.UseVisualStyleBackColor = true;
            this.CboxVerActivos.CheckedChanged += new System.EventHandler(this.CboxVerActivos_CheckedChanged);
            // 
            // CidCliente
            // 
            this.CidCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CidCliente.DataPropertyName = "idCliente";
            this.CidCliente.HeaderText = "Codigo";
            this.CidCliente.MinimumWidth = 6;
            this.CidCliente.Name = "CidCliente";
            this.CidCliente.ReadOnly = true;
            // 
            // Cnombre
            // 
            this.Cnombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cnombre.DataPropertyName = "nombre";
            this.Cnombre.HeaderText = "Nombre";
            this.Cnombre.MinimumWidth = 6;
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.ReadOnly = true;
            // 
            // Ccedula
            // 
            this.Ccedula.DataPropertyName = "cedula";
            this.Ccedula.HeaderText = "Cedula";
            this.Ccedula.MinimumWidth = 6;
            this.Ccedula.Name = "Ccedula";
            this.Ccedula.ReadOnly = true;
            this.Ccedula.Width = 125;
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
            // Cemail
            // 
            this.Cemail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cemail.DataPropertyName = "email";
            this.Cemail.HeaderText = "Email";
            this.Cemail.MinimumWidth = 6;
            this.Cemail.Name = "Cemail";
            this.Cemail.ReadOnly = true;
            this.Cemail.Width = 150;
            // 
            // FrmClienteGestion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1123, 659);
            this.Controls.Add(this.CboxVerActivos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmClienteGestion1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Clientes";
            this.Load += new System.EventHandler(this.FrmClienteGestion1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgLista;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtTelefonos;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.CheckBox CboxVerActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cemail;
    }
}