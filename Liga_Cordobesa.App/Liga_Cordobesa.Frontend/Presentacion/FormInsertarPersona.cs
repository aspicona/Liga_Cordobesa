
using Liga_Cordobesa.Backend.Dominio;
using Liga_Cordobesa.Backend.Servicios;
using Liga_Cordobesa.Backend.Servicios.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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
        private IPersonaService servicio;
        private Accion modo;

        private Equipo oEquipo;
        private JugadoresDTO jugador;
        private int id_persona;
        
        public FormInsertarPersona(Accion modo, JugadoresDTO jugador, int idPers)
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearPersonaService();
            this.modo = modo;
            this.jugador = jugador;
            this.id_persona = idPers;

            if (modo.Equals(Accion.UPDATE))
            {
                btnAceptarPersona.Text = "Actualizar";
                txtApellido.Text = jugador.Apellido;
                txtNombre.Text = jugador.Nombre;
                txtDni.Text = jugador.Dni.ToString();
                dtpFechaPersona.Value = jugador.FechaNac;
            } 
            else if (modo.Equals(Accion.CREATE))
            {

            }

        }

        private void FormInsertarPersona_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptarPersona_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                if(modo.Equals(Accion.CREATE))
                {
                    InsertarPersona();
                } else if(modo.Equals(Accion.UPDATE))
                {
                    ActualizarPersona();
                }
                
            }
        }

        private async void ActualizarPersona()
        {
            Persona oPersona = new Persona();
            //pasar datos al objeto 
            oPersona.Dni = Convert.ToInt32(txtDni.Text);
            oPersona.Nombre = txtNombre.Text.ToString();
            oPersona.Apellido = txtApellido.Text.ToString();
            oPersona.FechaNac = Convert.ToDateTime(dtpFechaPersona.Text);
            oPersona.Id_Persona = this.id_persona;

            HttpClient client = new HttpClient();
            string url = "https://localhost:44342/api/Persona/update";
            string persJSON = JsonConvert.SerializeObject(oPersona);

            var result = await PostAsync(url, persJSON);
            bool personaCreada = JsonConvert.DeserializeObject<Boolean>(result);

            if (personaCreada)
            {
                MessageBox.Show("Persona actualizada con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al intentar actualizar Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void InsertarPersona()
        {
            Persona oPersona = new Persona();
            //pasar datos al objeto 
            oPersona.Dni = Convert.ToInt32(txtDni.Text);
            oPersona.Nombre = txtNombre.Text.ToString();
            oPersona.Apellido = txtApellido.Text.ToString();
            oPersona.FechaNac = Convert.ToDateTime(dtpFechaPersona.Text);

            HttpClient client = new HttpClient();
            string url = "https://localhost:44342/api/Persona";
            string persJSON = JsonConvert.SerializeObject(oPersona);

            var result = await PostAsync(url, persJSON);
            bool personaCreada = JsonConvert.DeserializeObject<Boolean>(result);

            if (personaCreada)
            {
                MessageBox.Show("Persona ingresada con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al intentar ingresar Persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LimpiarCampos()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
        }

        public async Task<string> PostAsync(string url, string data)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
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
