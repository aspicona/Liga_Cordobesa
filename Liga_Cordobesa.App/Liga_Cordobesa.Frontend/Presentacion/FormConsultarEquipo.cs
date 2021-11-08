using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liga_Cordobesa.Frontend.Presentacion
{
    public partial class FormConsultarEquipo : Form
    {
        public FormConsultarEquipo()
        {
            InitializeComponent();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar la consulta?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
