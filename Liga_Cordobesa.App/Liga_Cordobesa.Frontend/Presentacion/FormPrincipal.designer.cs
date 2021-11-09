
namespace Liga_Cordobesa.Frontend.Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.BackgroundImage = global::Liga_Cordobesa.Frontend.Properties.Resources.perfil_H;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.soporteToolStripMenuItem,
            this.transaccionToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(171, 591);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Elephant", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(158, 33);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesionMenuItem
            // 
            this.cerrarSesionMenuItem.BackColor = System.Drawing.Color.Black;
            this.cerrarSesionMenuItem.ForeColor = System.Drawing.Color.White;
            this.cerrarSesionMenuItem.Name = "cerrarSesionMenuItem";
            this.cerrarSesionMenuItem.Size = new System.Drawing.Size(254, 34);
            this.cerrarSesionMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionMenuItem.Click += new System.EventHandler(this.cerrarSesionMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jugadoresMenuItem});
            this.soporteToolStripMenuItem.Font = new System.Drawing.Font("Elephant", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soporteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(158, 33);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // jugadoresMenuItem
            // 
            this.jugadoresMenuItem.BackColor = System.Drawing.Color.Black;
            this.jugadoresMenuItem.ForeColor = System.Drawing.Color.White;
            this.jugadoresMenuItem.Name = "jugadoresMenuItem";
            this.jugadoresMenuItem.Size = new System.Drawing.Size(329, 34);
            this.jugadoresMenuItem.Text = "Consultar Jugadores";
            this.jugadoresMenuItem.Click += new System.EventHandler(this.jugadoresMenuItem_Click);
            // 
            // transaccionToolStripMenuItem
            // 
            this.transaccionToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.transaccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEquipoToolStripMenuItem,
            this.consultarEquipoToolStripMenuItem});
            this.transaccionToolStripMenuItem.Font = new System.Drawing.Font("Elephant", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transaccionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.transaccionToolStripMenuItem.Name = "transaccionToolStripMenuItem";
            this.transaccionToolStripMenuItem.Size = new System.Drawing.Size(158, 33);
            this.transaccionToolStripMenuItem.Text = "Transaccion";
            // 
            // nuevoEquipoToolStripMenuItem
            // 
            this.nuevoEquipoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.nuevoEquipoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nuevoEquipoToolStripMenuItem.Name = "nuevoEquipoToolStripMenuItem";
            this.nuevoEquipoToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.nuevoEquipoToolStripMenuItem.Text = "Nuevo Equipo";
            this.nuevoEquipoToolStripMenuItem.Click += new System.EventHandler(this.nuevoEquipoToolStripMenuItem_Click);
            // 
            // consultarEquipoToolStripMenuItem
            // 
            this.consultarEquipoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.consultarEquipoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultarEquipoToolStripMenuItem.Name = "consultarEquipoToolStripMenuItem";
            this.consultarEquipoToolStripMenuItem.Size = new System.Drawing.Size(295, 34);
            this.consultarEquipoToolStripMenuItem.Text = "Consultar Equipo";
            this.consultarEquipoToolStripMenuItem.Click += new System.EventHandler(this.consultarEquipoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaReportesToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Elephant", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(158, 33);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // consultaReportesToolStripMenuItem
            // 
            this.consultaReportesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.consultaReportesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultaReportesToolStripMenuItem.Name = "consultaReportesToolStripMenuItem";
            this.consultaReportesToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            this.consultaReportesToolStripMenuItem.Text = "Consulta Reportes";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Font = new System.Drawing.Font("Elephant", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(158, 33);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.informacionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.informacionToolStripMenuItem.Text = "Informacion";
            this.informacionToolStripMenuItem.Click += new System.EventHandler(this.informacionToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Liga_Cordobesa.Frontend.Properties.Resources.descarga_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(171, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(882, 317);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Liga_Cordobesa.Frontend.Properties.Resources.fondopasto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1051, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liga Futbol";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadoresMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

