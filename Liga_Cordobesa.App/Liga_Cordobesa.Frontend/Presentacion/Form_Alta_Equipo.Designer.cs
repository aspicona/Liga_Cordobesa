
namespace Liga_Cordobesa.Frontend.Presentacion
{
    partial class Form_Alta_Equipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Alta_Equipo));
            this.lblNroEquipo = new System.Windows.Forms.Label();
            this.nudCamiseta = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboJugador = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.dgvEquipo = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camiseta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cboPosicion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamiseta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNroEquipo
            // 
            this.lblNroEquipo.AutoSize = true;
            this.lblNroEquipo.Location = new System.Drawing.Point(469, 12);
            this.lblNroEquipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroEquipo.Name = "lblNroEquipo";
            this.lblNroEquipo.Size = new System.Drawing.Size(73, 15);
            this.lblNroEquipo.TabIndex = 16;
            this.lblNroEquipo.Text = "Nro equipo: ";
            // 
            // nudCamiseta
            // 
            this.nudCamiseta.Location = new System.Drawing.Point(437, 138);
            this.nudCamiseta.Margin = new System.Windows.Forms.Padding(2);
            this.nudCamiseta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCamiseta.Name = "nudCamiseta";
            this.nudCamiseta.Size = new System.Drawing.Size(69, 23);
            this.nudCamiseta.TabIndex = 4;
            this.nudCamiseta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nº Camiseta";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(524, 165);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 27);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar Jugador";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboJugador
            // 
            this.cboJugador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJugador.FormattingEnabled = true;
            this.cboJugador.Location = new System.Drawing.Point(138, 96);
            this.cboJugador.Margin = new System.Windows.Forms.Padding(2);
            this.cboJugador.Name = "cboJugador";
            this.cboJugador.Size = new System.Drawing.Size(264, 23);
            this.cboJugador.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Jugador: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre Equipo: ";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(138, 9);
            this.txtNombreEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(264, 23);
            this.txtNombreEquipo.TabIndex = 1;
            // 
            // dgvEquipo
            // 
            this.dgvEquipo.AllowUserToAddRows = false;
            this.dgvEquipo.AllowUserToDeleteRows = false;
            this.dgvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.jugador,
            this.posicion,
            this.camiseta,
            this.accion});
            this.dgvEquipo.Location = new System.Drawing.Point(28, 196);
            this.dgvEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEquipo.Name = "dgvEquipo";
            this.dgvEquipo.ReadOnly = true;
            this.dgvEquipo.RowHeadersWidth = 62;
            this.dgvEquipo.RowTemplate.Height = 28;
            this.dgvEquipo.Size = new System.Drawing.Size(614, 194);
            this.dgvEquipo.TabIndex = 7;
            this.dgvEquipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipo_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // jugador
            // 
            this.jugador.HeaderText = "Jugador";
            this.jugador.MinimumWidth = 8;
            this.jugador.Name = "jugador";
            this.jugador.ReadOnly = true;
            this.jugador.Width = 150;
            // 
            // posicion
            // 
            this.posicion.HeaderText = "Posicion";
            this.posicion.MinimumWidth = 8;
            this.posicion.Name = "posicion";
            this.posicion.ReadOnly = true;
            this.posicion.Width = 150;
            // 
            // camiseta
            // 
            this.camiseta.HeaderText = "Camiseta";
            this.camiseta.MinimumWidth = 8;
            this.camiseta.Name = "camiseta";
            this.camiseta.ReadOnly = true;
            this.camiseta.Width = 150;
            // 
            // accion
            // 
            this.accion.HeaderText = "Accion";
            this.accion.MinimumWidth = 8;
            this.accion.Name = "accion";
            this.accion.ReadOnly = true;
            this.accion.Width = 150;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(402, 407);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 27);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(153, 407);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(118, 27);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 93);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar persona";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboPosicion
            // 
            this.cboPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosicion.FormattingEnabled = true;
            this.cboPosicion.Location = new System.Drawing.Point(138, 137);
            this.cboPosicion.Margin = new System.Windows.Forms.Padding(2);
            this.cboPosicion.Name = "cboPosicion";
            this.cboPosicion.Size = new System.Drawing.Size(199, 23);
            this.cboPosicion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Posicion: ";
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(138, 42);
            this.txtDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(264, 23);
            this.txtDT.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nombre DT: ";
            // 
            // Form_Alta_Equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 465);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.cboPosicion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvEquipo);
            this.Controls.Add(this.lblNroEquipo);
            this.Controls.Add(this.nudCamiseta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboJugador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreEquipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Alta_Equipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Equipos";
            this.Load += new System.EventHandler(this.Form_Alta_Equipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCamiseta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroEquipo;
        private System.Windows.Forms.NumericUpDown nudCamiseta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboJugador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.DataGridView dgvEquipo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboPosicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn jugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn camiseta;
        private System.Windows.Forms.DataGridViewButtonColumn accion;
    }
}