using Liga_Cordobesa.App.Presentacion;
using System;
using System.Windows.Forms;

namespace EquipoTP
{
    public partial class FormPrincipal : Form
    {
        private Accion modo;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1 de la App " + "\n" + "Integrantes:" + "\n" + "Aronica Andres," + "\n" + "Sisneros Alexis," + "\n" + "Spicoña Analia, " + "\n" + "Spicoña Lourdes, " + "\n" + "Sosa Diego", "Equipos");

        }

        private void nuevoEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Alta_Equipo frmNuevo = new Form_Alta_Equipo(modo,1);
            frmNuevo.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
