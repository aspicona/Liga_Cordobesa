
namespace Liga_Cordobesa.Frontend.Presentacion
{
    partial class FormInsertarPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsertarPersona));
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaPersona = new System.Windows.Forms.DateTimePicker();
            this.btnAceptarPersona = new System.Windows.Forms.Button();
            this.btnCancelarPersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Black;
            this.lblDni.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.ImageKey = "(ninguna)";
            this.lblDni.Location = new System.Drawing.Point(104, 33);
            this.lblDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(35, 18);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "Dni";
            this.lblDni.Click += new System.EventHandler(this.lblDni_Click);
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.White;
            this.txtDni.Location = new System.Drawing.Point(148, 29);
            this.txtDni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(216, 23);
            this.txtDni.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(148, 67);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.Location = new System.Drawing.Point(148, 105);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(216, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de Nac.";
            // 
            // dtpFechaPersona
            // 
            this.dtpFechaPersona.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPersona.Location = new System.Drawing.Point(148, 142);
            this.dtpFechaPersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaPersona.Name = "dtpFechaPersona";
            this.dtpFechaPersona.Size = new System.Drawing.Size(216, 23);
            this.dtpFechaPersona.TabIndex = 4;
            // 
            // btnAceptarPersona
            // 
            this.btnAceptarPersona.BackColor = System.Drawing.Color.Black;
            this.btnAceptarPersona.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptarPersona.ForeColor = System.Drawing.Color.White;
            this.btnAceptarPersona.Location = new System.Drawing.Point(111, 183);
            this.btnAceptarPersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptarPersona.Name = "btnAceptarPersona";
            this.btnAceptarPersona.Size = new System.Drawing.Size(93, 34);
            this.btnAceptarPersona.TabIndex = 5;
            this.btnAceptarPersona.Text = "Insertar";
            this.btnAceptarPersona.UseVisualStyleBackColor = false;
            this.btnAceptarPersona.Click += new System.EventHandler(this.btnAceptarPersona_Click);
            // 
            // btnCancelarPersona
            // 
            this.btnCancelarPersona.BackColor = System.Drawing.Color.Black;
            this.btnCancelarPersona.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarPersona.ForeColor = System.Drawing.Color.White;
            this.btnCancelarPersona.Location = new System.Drawing.Point(245, 183);
            this.btnCancelarPersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarPersona.Name = "btnCancelarPersona";
            this.btnCancelarPersona.Size = new System.Drawing.Size(93, 34);
            this.btnCancelarPersona.TabIndex = 6;
            this.btnCancelarPersona.Text = "Cancelar";
            this.btnCancelarPersona.UseVisualStyleBackColor = false;
            this.btnCancelarPersona.Click += new System.EventHandler(this.btnCancelarPersona_Click);
            // 
            // FormInsertarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::Liga_Cordobesa.Frontend.Properties.Resources.fondopasto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(442, 228);
            this.Controls.Add(this.btnCancelarPersona);
            this.Controls.Add(this.btnAceptarPersona);
            this.Controls.Add(this.dtpFechaPersona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormInsertarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar Nueva Persona";
            this.Load += new System.EventHandler(this.FormInsertarPersona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaPersona;
        private System.Windows.Forms.Button btnAceptarPersona;
        private System.Windows.Forms.Button btnCancelarPersona;
    }
}