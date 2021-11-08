using Liga_Cordobesa.Backend.Dominio;
using Liga_Cordobesa.Backend.Servicios;
using Liga_Cordobesa.Backend.Servicios.Implementaciones;
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
    public partial class FormConsultarEquipo : Form
    {
        private Equipo oEquipo;
        private IJugadoresService service;

        public FormConsultarEquipo()
        {
            InitializeComponent();
            service = new JugadoresServiceImpl();
            CargarComboEquipo();
            CargarComboPersonas();
            CargarComboPosicion();
            DesabilitarComponentesJugador();
            btnUpdateTeam.Enabled = false;
        }

        private void DesabilitarComponentesJugador()
        {
            cboJugador.Enabled = false;
            button1.Enabled = false;
            btnUpdateTeam.Enabled = false;
            cboPosicion.Enabled = false;
            nudCamiseta.Enabled = false;
            btnAgregar.Enabled = false;
            txtDt.Enabled = false;
            txtNombre.Enabled = false;
        }

        private void HabilitarComponentesJugador()
        {
            cboJugador.Enabled = true;
            button1.Enabled = true;
            btnUpdateTeam.Enabled = true;
            cboPosicion.Enabled = true;
            nudCamiseta.Enabled = true;
            btnAgregar.Enabled = true;
            txtDt.Enabled = true;
            txtNombre.Enabled = true;
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar la consulta?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cboEquipo.Enabled = false;
            CargarJugadores();
            CargarDatosEquipo();

            HabilitarComponentesJugador();
        }

        private async void CargarJugadores()
        {
            List<Parametro> filtros = new List<Parametro>();
            Parametro equipo = new Parametro();
            equipo.Nombre = "@equipo";
            equipo.Valor = cboEquipo.SelectedValue;
            filtros.Add(equipo);

            List<JugadoresDTO> lst = null;

            string filtrosJSON = JsonConvert.SerializeObject(filtros);
            string url = "https://localhost:44342/api/Jugadores/filtro";

            HttpClient client = new HttpClient();
            var resultado = await PostAsync(url, filtrosJSON);

            lst = JsonConvert.DeserializeObject<List<JugadoresDTO>>(resultado);

            dataGridView2.Rows.Clear();
            
            foreach (JugadoresDTO oJug in lst)
            {
                dataGridView2.Rows.Add(new object[]{
                                        oJug.Id_jugador,
                                        oJug.Nombre,
                                        oJug.Apellido,
                                        oJug.Dni,
                                        oJug.FechaNac.ToString("dd/MM/yyyy"),
                                        oJug.NombreEquipo,
                                        oJug.Camiseta,
                                        oJug.NombrePosicion,
                                        oJug.Id_persona
                 }); ;
            }
        }

        private async void CargarDatosEquipo()
        {
            int numeroEquipo = Convert.ToInt32(cboEquipo.SelectedValue);
            string url = "https://localhost:44342/api/Equipo/" + numeroEquipo;
            HttpClient client = new HttpClient();

            var result = await client.GetAsync(url);

            var bodyJSON = await result.Content.ReadAsStringAsync();

            Equipo team = JsonConvert.DeserializeObject<Equipo>(bodyJSON);

            if(team != null)
            {
                oEquipo = team;
                txtDt.Text = team.Dt;
                txtNombre.Text = team.NombreEquipo;
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

        private async void CargarComboEquipo()
        {
            string url = "https://localhost:44342/api/Equipo";
            HttpClient client = new HttpClient();

            var result = await client.GetAsync(url);

            var bodyJSON = await result.Content.ReadAsStringAsync();

            List<Equipo> lst = JsonConvert.DeserializeObject<List<Equipo>>(bodyJSON);

            //valueMember y DisplayMember serán las properties de los objetos
            cboEquipo.DataSource = lst;
            cboEquipo.ValueMember = "idEquipo";
            cboEquipo.DisplayMember = "nombreEquipo";
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDt.Text = "";
            txtDt.Enabled = false;
            dataGridView2.Rows.Clear();
            DesabilitarComponentesJugador();
            cboEquipo.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInsertarPersona frmNuevo = new FormInsertarPersona(Accion.CREATE, null, 0);
            frmNuevo.ShowDialog();
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

            if (service.InsertarJugador(item, oEquipo.IdEquipo))
            {
                MessageBox.Show("Se agrego Jugador al equipo", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarJugadores();
            }
        }

        private bool ExisteJugadorEnGrilla(string text, string pos)
        {
            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                if(fila.Cells["idPers"].Value != null && fila.Cells["camiseta"].Value != null)
                {
                    if (fila.Cells["idPers"].Value.ToString().Equals(text))
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
            }

            return false;
        }

        private async void btnUpdateTeam_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre de equipo", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            if (txtDt.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre de Tecnico", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDt.Focus();
                return;
            }

            oEquipo.NombreEquipo = txtNombre.Text;
            oEquipo.Dt = txtDt.Text;

            string url = "https://localhost:44342/api/Equipo/update";
            string equipoJSON = JsonConvert.SerializeObject(oEquipo);

            var result = await PutAsync(url, equipoJSON);

            bool response = JsonConvert.DeserializeObject<Boolean>(result);
            if (response)
            {
                MessageBox.Show("Se Actualizo los datos del Equipo", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarComboEquipo();
                DesabilitarComponentesJugador();
            }
        }

        public async Task<string> PutAsync(string url, string data)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await client.PutAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex == 9)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el Jugador del equipo?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    QuitarJugador();
                }
            }
        }

        private async void QuitarJugador()
        {
            int nroJugador = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            string url = "https://localhost:44342/api/Jugadores/" + nroJugador;
            HttpClient client = new HttpClient();

            var result = await client.DeleteAsync(url);

            var bodyJSON = await result.Content.ReadAsStringAsync();

            bool isDeleted = JsonConvert.DeserializeObject<Boolean>(bodyJSON);

            if (isDeleted)
            {
                MessageBox.Show("Se elimino Jugador del Equipo", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarJugadores();
            }
        }
    }
}
