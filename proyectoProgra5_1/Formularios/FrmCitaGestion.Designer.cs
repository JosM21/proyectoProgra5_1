namespace proyectoProgra5_1.Formularios
{
    partial class FrmCitaGestion
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
            this.TxtInmueble = new System.Windows.Forms.TextBox();
            this.TxtAgente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.TxtHora = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.TxtIdCita = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CidCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cagente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinmueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.CidCita,
            this.Cfecha,
            this.Chora,
            this.Cagente,
            this.Ccliente,
            this.Cinmueble});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgLista.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgLista.Location = new System.Drawing.Point(58, 264);
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
            this.DgLista.Size = new System.Drawing.Size(849, 235);
            this.DgLista.TabIndex = 40;
            this.DgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLista_CellClick);
            this.DgLista.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgLista_DataBindingComplete);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(726, 193);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(181, 50);
            this.BtnCancelar.TabIndex = 39;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(512, 193);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(181, 50);
            this.BtnLimpiar.TabIndex = 38;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Orange;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(285, 193);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(181, 50);
            this.BtnModificar.TabIndex = 36;
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
            this.BtnAgregar.Location = new System.Drawing.Point(59, 193);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(181, 50);
            this.BtnAgregar.TabIndex = 35;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtInmueble);
            this.groupBox2.Controls.Add(this.TxtAgente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtCliente);
            this.groupBox2.Controls.Add(this.TxtHora);
            this.groupBox2.Controls.Add(this.TxtFecha);
            this.groupBox2.Controls.Add(this.TxtIdCita);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DeepPink;
            this.groupBox2.Location = new System.Drawing.Point(58, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(849, 175);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Cita";
            // 
            // TxtInmueble
            // 
            this.TxtInmueble.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtInmueble.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtInmueble.Location = new System.Drawing.Point(538, 117);
            this.TxtInmueble.Name = "TxtInmueble";
            this.TxtInmueble.Size = new System.Drawing.Size(276, 30);
            this.TxtInmueble.TabIndex = 18;
            this.TxtInmueble.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInmueble_KeyPress);
            // 
            // TxtAgente
            // 
            this.TxtAgente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtAgente.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtAgente.Location = new System.Drawing.Point(538, 78);
            this.TxtAgente.Name = "TxtAgente";
            this.TxtAgente.Size = new System.Drawing.Size(276, 30);
            this.TxtAgente.TabIndex = 17;
            this.TxtAgente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAgente_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Agente:";
            // 
            // TxtCliente
            // 
            this.TxtCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtCliente.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtCliente.Location = new System.Drawing.Point(538, 39);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(276, 30);
            this.TxtCliente.TabIndex = 13;
            this.TxtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCliente_KeyPress);
            // 
            // TxtHora
            // 
            this.TxtHora.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtHora.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtHora.Location = new System.Drawing.Point(96, 120);
            this.TxtHora.Name = "TxtHora";
            this.TxtHora.Size = new System.Drawing.Size(298, 30);
            this.TxtHora.TabIndex = 10;
            this.TxtHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHora_KeyPress);
            // 
            // TxtFecha
            // 
            this.TxtFecha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtFecha.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtFecha.Location = new System.Drawing.Point(96, 78);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(298, 30);
            this.TxtFecha.TabIndex = 9;
            this.TxtFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFecha_KeyPress);
            // 
            // TxtIdCita
            // 
            this.TxtIdCita.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtIdCita.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtIdCita.Location = new System.Drawing.Point(96, 37);
            this.TxtIdCita.Name = "TxtIdCita";
            this.TxtIdCita.ReadOnly = true;
            this.TxtIdCita.Size = new System.Drawing.Size(298, 30);
            this.TxtIdCita.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Inmueble:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Cliente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Hora:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Fecha:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(64, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.DeepPink;
            this.TxtBuscar.Location = new System.Drawing.Point(168, 539);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(739, 30);
            this.TxtBuscar.TabIndex = 19;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // CidCita
            // 
            this.CidCita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CidCita.DataPropertyName = "idCita";
            this.CidCita.HeaderText = "Codigo";
            this.CidCita.MinimumWidth = 6;
            this.CidCita.Name = "CidCita";
            this.CidCita.ReadOnly = true;
            // 
            // Cfecha
            // 
            this.Cfecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cfecha.DataPropertyName = "fecha";
            this.Cfecha.HeaderText = "Fecha";
            this.Cfecha.MinimumWidth = 6;
            this.Cfecha.Name = "Cfecha";
            this.Cfecha.ReadOnly = true;
            // 
            // Chora
            // 
            this.Chora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Chora.DataPropertyName = "hora";
            this.Chora.HeaderText = "Hora";
            this.Chora.MinimumWidth = 6;
            this.Chora.Name = "Chora";
            this.Chora.ReadOnly = true;
            // 
            // Cagente
            // 
            this.Cagente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cagente.DataPropertyName = "nombre";
            this.Cagente.HeaderText = "Agente";
            this.Cagente.MinimumWidth = 6;
            this.Cagente.Name = "Cagente";
            this.Cagente.ReadOnly = true;
            // 
            // Ccliente
            // 
            this.Ccliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ccliente.DataPropertyName = "nombreCliente";
            this.Ccliente.HeaderText = "Cliente";
            this.Ccliente.MinimumWidth = 6;
            this.Ccliente.Name = "Ccliente";
            this.Ccliente.ReadOnly = true;
            // 
            // Cinmueble
            // 
            this.Cinmueble.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cinmueble.DataPropertyName = "numeroLote";
            this.Cinmueble.HeaderText = "Numero Lote";
            this.Cinmueble.MinimumWidth = 6;
            this.Cinmueble.Name = "Cinmueble";
            this.Cinmueble.ReadOnly = true;
            // 
            // FrmCitaGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(952, 605);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgLista);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox2);
            this.MinimizeBox = false;
            this.Name = "FrmCitaGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Citas";
            this.Load += new System.EventHandler(this.FrmCitaGestion_Load);
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
        private System.Windows.Forms.TextBox TxtInmueble;
        private System.Windows.Forms.TextBox TxtAgente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.TextBox TxtHora;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.TextBox TxtIdCita;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cagente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinmueble;
    }
}