
using Liga_Cordobesa.Backend.Dominio;
using Liga_Cordobesa.Backend.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liga_Cordobesa.Frontend.Presentacion
{
    public enum Accion
    {
        CREATE,
        READ,
        UPDATE,
        DELETE
    }
    public partial class FormInsertarPersona : Form
    {
        private IEquipoService servicio;
        private Accion modo;

        Equipo oEquipo = new Equipo();
        
        public FormInsertarPersona(Accion modo, int nro)
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearEquipoService();
            this.modo = modo;

            //if (modo.Equals(Accion.READ))
            //{
            //    gbDatosPresupuesto.Enabled = false;
            //    btnAceptar.Enabled = false;
            //    this.Text = "VER EQUIPO";
            //    this.Cargar_presupuesto(nro);
            //}

        }

        private void FormInsertarPersona_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptarPersona_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Persona oPersona = new Persona();  
                //pasar datos al objeto 
                oPersona.Dni = Convert.ToInt32(txtDni.Text);
                oPersona.Nombre = txtNombre.Text.ToString();
                oPersona.Apellido = txtApellido.Text.ToString();
                oPersona.FechaNac = Convert.ToDateTime(dtpFechaPersona.Text);

                if (servicio.Insertar(oPersona))
                {
                    MessageBox.Show("Persona ingresada con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al intentar ingresar Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validarCampos()
        {
            if (txtDni.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un dni", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtDni.Text);
                }

                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar valores numericos");
                    txtDni.Focus();
                    return false;
                }
            }
            // ver como se corroboran 8 digitos del dni
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }

            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Apellido", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return false;
            }

            return true;
        }

        private void btnCancelarPersona_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar la carga?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
