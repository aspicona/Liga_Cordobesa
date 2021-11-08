using System;
using System.Windows.Forms;

namespace Liga_Cordobesa.Frontend.Presentacion
{
    public partial class FormPrincipal : Form
    {
        private Login login;
        private Accion modo;

        public FormPrincipal(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1 de la App " + "\n" + "Integrantes:" + "\n" + "Aronica Andres," + "\n" + "Sisneros Alexis," + "\n" + "Spicoña Analia, " + "\n" + "Spicoña Lourdes, " + "\n" + "Sosa Diego", "Equipos");

        }

        private void nuevoEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Alta_Equipo frmNuevo = new Form_Alta_Equipo(modo,1);
            frmNuevo.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login.Dispose();
                this.Dispose();
            }
        }

        private void cerrarSesionMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar Sesion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                login.Show();
            }
        }

        private void jugadoresMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarJugadores form = new FormConsultarJugadores();
            form.Show();
        }
    }
}
