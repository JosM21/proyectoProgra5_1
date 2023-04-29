namespace proyectoProgra5_1.Formularios
{
    partial class FrmSucursalGestion1
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
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtIdSucursal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CidSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.CidSucursal,
            this.Cnombre,
            this.Ctelefono,
            this.Cemail,
            this.Cdireccion});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgLista.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgLista.Location = new System.Drawing.Point(59, 277);
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
            this.DgLista.Size = new System.Drawing.Size(827, 210);
            this.DgLista.TabIndex = 57;
            this.DgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLista_CellClick_1);
            this.DgLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgLista_DataBindingComplete_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(705, 203);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(181, 50);
            this.BtnCancelar.TabIndex = 56;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(498, 203);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(181, 50);
            this.BtnLimpiar.TabIndex = 55;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click_1);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Orange;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(273, 203);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(181, 50);
            this.BtnModificar.TabIndex = 53;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click_1);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(58, 203);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(181, 50);
            this.BtnAgregar.TabIndex = 52;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtDireccion);
            this.groupBox2.Controls.Add(this.TxtEmail);
            this.groupBox2.Controls.Add(this.TxtTelefono);
            this.groupBox2.Controls.Add(this.TxtNombre);
            this.groupBox2.Controls.Add(this.TxtIdSucursal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DeepPink;
            this.groupBox2.Location = new System.Drawing.Point(59, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 177);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Sucursal";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtDireccion.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtDireccion.Location = new System.Drawing.Point(533, 81);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDireccion.Size = new System.Drawing.Size(271, 71);
            this.TxtDireccion.TabIndex = 15;
            this.TxtDireccion.UseSystemPasswordChar = true;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccion_KeyPress);
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtEmail.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtEmail.Location = new System.Drawing.Point(99, 119);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(298, 30);
            this.TxtEmail.TabIndex = 13;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtTelefono.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtTelefono.Location = new System.Drawing.Point(533, 35);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(271, 30);
            this.TxtTelefono.TabIndex = 11;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtNombre.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtNombre.Location = new System.Drawing.Point(99, 78);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(298, 30);
            this.TxtNombre.TabIndex = 9;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtIdSucursal
            // 
            this.TxtIdSucursal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtIdSucursal.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtIdSucursal.Location = new System.Drawing.Point(97, 37);
            this.TxtIdSucursal.Name = "TxtIdSucursal";
            this.TxtIdSucursal.ReadOnly = true;
            this.TxtIdSucursal.Size = new System.Drawing.Size(298, 30);
            this.TxtIdSucursal.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Direccion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 40);
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
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtBuscar.Location = new System.Drawing.Point(158, 521);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(739, 30);
            this.TxtBuscar.TabIndex = 58;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(54, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Buscar:";
            // 
            // CidSucursal
            // 
            this.CidSucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CidSucursal.DataPropertyName = "idSucursal";
            this.CidSucursal.HeaderText = "Codigo";
            this.CidSucursal.MinimumWidth = 6;
            this.CidSucursal.Name = "CidSucursal";
            this.CidSucursal.ReadOnly = true;
            // 
            // Cnombre
            // 
            this.Cnombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cnombre.DataPropertyName = "nombreSucursal";
            this.Cnombre.HeaderText = "Nombre";
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
            // Cemail
            // 
            this.Cemail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cemail.DataPropertyName = "email";
            this.Cemail.HeaderText = "Email";
            this.Cemail.MinimumWidth = 6;
            this.Cemail.Name = "Cemail";
            this.Cemail.ReadOnly = true;
            this.Cemail.Width = 125;
            // 
            // Cdireccion
            // 
            this.Cdireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cdireccion.DataPropertyName = "direccion";
            this.Cdireccion.HeaderText = "Direccion";
            this.Cdireccion.MinimumWidth = 6;
            this.Cdireccion.Name = "Cdireccion";
            this.Cdireccion.ReadOnly = true;
            this.Cdireccion.Width = 150;
            // 
            // FrmSucursalGestion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(946, 582);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmSucursalGestion1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Sucursal";
            this.Load += new System.EventHandler(this.FrmSucursalGestion1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgLista;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtIdSucursal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdireccion;
    }
}