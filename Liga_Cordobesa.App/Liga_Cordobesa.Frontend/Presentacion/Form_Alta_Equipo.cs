using Liga_Cordobesa.Backend.Acceso_a_datos;
using Liga_Cordobesa.Backend.Acceso_a_datos.Interfaces;
using Liga_Cordobesa.Backend.Dominio;
using Liga_Cordobesa.Backend.Servicios;
using Liga_Cordobesa.Backend.Servicios.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liga_Cordobesa.Frontend.Presentacion
{
    public partial class Form_Alta_Equipo : Form
    {
        private Accion modo;

        Equipo oEquipo = new Equipo();
        private IEquipoService service;

        public Form_Alta_Equipo(Accion modo, int nro)
        {
            InitializeComponent();
            service = new EquipoService();
            this.modo = modo;
        }

        private void Form_Alta_Equipo_Load(object sender, EventArgs e)
        {
            CargarComboPersonas();
            CargarComboPosicion();

            GetProximoIDEquipo();
        }

        private async void GetProximoIDEquipo()
        {
            string url = "https://localhost:44342/api/Equipo/proxID";
            HttpClient client = new HttpClient();

            var result = await client.GetAsync(url);

            var bodyJSON = await result.Content.ReadAsStringAsync();

            int nroProxEquipo = JsonConvert.DeserializeObject<int>(bodyJSON);

            lblNroEquipo.Text = "Equipo Nro: " + (nroProxEquipo == 0 ? 1 : nroProxEquipo);
        }

        private void FormInsertarPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Alta_Equipo_Load(sender, e);
        }

        private async void CargarComboPosicion()
        {
            string url = "https://localhost:44342/api/Equipo/posiciones";
            HttpClient client = new HttpClient();

            var result = await client.GetAsync(url);

            var bodyJSON = await result.Content.ReadAsStringAsync();

            List<Posicion> lstPosicion = JsonConvert.DeserializeObject<List<Posicion>>(bodyJSON);

            //source es una lista de objetos
            cboPosicion.DataSource = lstPosicion;
            
            //valueMember y DisplayMember serán las properties de los objetos
            cboPosicion.ValueMember = "id_posicion";
            cboPosicion.DisplayMember = "NombrePosicion";
        }

        private async void CargarComboPersonas()
        {
            string url = "https://localhost:44342/api/Persona";
            HttpClient client = new HttpClient();

            var result = await client.GetAsync(url);

            var bodyJSON = await result.Content.ReadAsStringAsync();

            List<Persona> lst = JsonConvert.DeserializeObject<List<Persona>>(bodyJSON); 

            //valueMember y DisplayMember serán las properties de los objetos
            cboJugador.DataSource = lst;
            cboJugador.ValueMember = "id_persona";
            cboJugador.DisplayMember = "nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInsertarPersona frmNuevo = new FormInsertarPersona(modo, null, 0);
            frmNuevo.ShowDialog();
        }

        private void dgvEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEquipo.CurrentCell.ColumnIndex == 4)
            {
                oEquipo.QuitarJugador(dgvEquipo.CurrentRow.Index);
                dgvEquipo.Rows.Remove(dgvEquipo.CurrentRow);
            }
        }

        private bool ExisteJugadorEnGrilla(string text, string pos)
        {
            foreach (DataGridViewRow fila in dgvEquipo.Rows)
            {
                if (fila.Cells["id"].Value.ToString().Equals(text))
                {
                    MessageBox.Show("Jugador ya agregado en el equipo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                   
                if (fila.Cells["camiseta"].Value.ToString().Equals(pos))
                {
                    MessageBox.Show("Nº de Camiseta ya esta asignada", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }

            }

            return false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ExisteJugadorEnGrilla(cboJugador.SelectedValue.ToString(), 
                Convert.ToString(nudCamiseta.Value)))
            {
                return;
            }

            Jugador item = new Jugador();

            Persona oPersona = (Persona)cboJugador.SelectedItem;
            Posicion oPosicion = (Posicion)cboPosicion.SelectedItem;
            item.Persona = oPersona;
            item.Posicion = oPosicion;
            item.Camiseta = (int)nudCamiseta.Value;

            oEquipo.AgregarJugador(item);

            dgvEquipo.Rows.Add(new object[] { oPersona.Id_Persona, oPersona.Nombre + ", " + oPersona.Apellido, oPosicion.NombrePosicion, item.Camiseta });
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvEquipo.Rows.Count <= 4)
            {
                MessageBox.Show("Debe ingresar al menos 5 jugadores por equipo", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboJugador.Focus();
                return;
            }

            if (txtNombreEquipo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre de equipo", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreEquipo.Focus();
                return;
            }
            if (cboJugador.SelectedIndex ==-1)
            {
                MessageBox.Show("Debe ingresar un jugador", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboJugador.Focus();
                return;
            }

            if (cboPosicion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una posicion", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPosicion.Focus();
                return;
            }

            if (nudCamiseta.Value==0)
            {
                MessageBox.Show("Debe ingresar un nro de camiseta", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudCamiseta.Focus();
                return;
            }
            
            oEquipo.NombreEquipo = txtNombreEquipo.Text;
            oEquipo.Dt = txtDT.Text;

            //string url = "https://localhost:44342/api/Equipo";
            //string equipoJSON = JsonConvert.SerializeObject(oEquipo);

            //var result = await PostAsync(url, equipoJSON);
            
            //bool equipoGuardado = JsonConvert.DeserializeObject<Boolean>(result);

            if (service.GrabarEquipo(oEquipo))
            {
                MessageBox.Show("Equipo guardado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al intentar grabar el equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void LimpiarCampos()
        {
            txtNombreEquipo.Text = "";
            txtDT.Text = "";
            dgvEquipo.Rows.Clear();
        }

        private void Form_Alta_Equipo_Activated(object sender, EventArgs e)
        {
            CargarComboPersonas();
            CargarComboPosicion();

            GetProximoIDEquipo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar la carga?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LimpiarCampos();
            }
        }
    }
}
