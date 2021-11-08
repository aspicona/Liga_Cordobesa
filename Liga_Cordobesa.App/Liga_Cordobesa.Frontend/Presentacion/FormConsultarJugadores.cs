using Liga_Cordobesa.Backend.Dominio;
using Liga_Cordobesa.Backend.Servicios;
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
    public partial class FormConsultarJugadores : Form
    {
        public FormConsultarJugadores()
        {
            InitializeComponent();
            btnEdit.Text = "Editar";
        }

        private void FormConsultarJugadores_Load(object sender, EventArgs e)
        {
            CargarComboEquipo();
            CargarJugadores();
        }

        private async void CargarComboEquipo()
        {
            string url = "https://localhost:44342/api/Equipo";
            HttpClient client = new HttpClient();

            var result = await client.GetAsync(url);

            var bodyJSON = await result.Content.ReadAsStringAsync();

            List<Equipo> lst = JsonConvert.DeserializeObject<List<Equipo>>(bodyJSON);

            //valueMember y DisplayMember serán las properties de los objetos
            cmbEquipos.DataSource = lst;
            cmbEquipos.ValueMember = "idEquipo";
            cmbEquipos.DisplayMember = "nombreEquipo";
        }

        private async void CargarJugadores()
        {
            string url = "https://localhost:44342/api/Jugadores";
            HttpClient client = new HttpClient();

            var result = await client.GetAsync(url);

            var bodyJSON = await result.Content.ReadAsStringAsync();

            List<JugadoresDTO> lst = JsonConvert.DeserializeObject<List<JugadoresDTO>>(bodyJSON);

            CargarJugadoresEnGrilla(lst);
        }

        private void CargarJugadoresEnGrilla(List<JugadoresDTO> lst)
        {
            dataGridView1.Rows.Clear();
            foreach (JugadoresDTO oJug in lst)
            {
                dataGridView1.Rows.Add(new object[]{
                                        oJug.Id_jugador,
                                        oJug.Nombre,
                                        oJug.Apellido,
                                        oJug.Dni,
                                        oJug.FechaNac.ToString("dd/MM/yyyy"),
                                        oJug.NombreEquipo,
                                        oJug.Camiseta,
                                        oJug.NombrePosicion,
                                        oJug.Id_persona
                 });
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 9)
            {
                JugadoresDTO jugador = new JugadoresDTO();
                jugador.Apellido = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                jugador.Nombre = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                jugador.Dni = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
                jugador.FechaNac = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);

                FormInsertarPersona form = new FormInsertarPersona(Accion.UPDATE, jugador,
                    Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value));
                
                form.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Parametro> filtros = new List<Parametro>();
            Parametro equipo = new Parametro();
            equipo.Nombre = "@equipo";
            equipo.Valor = cmbEquipos.SelectedValue;
            filtros.Add(equipo);

            List<JugadoresDTO> lst = null;

            string filtrosJSON = JsonConvert.SerializeObject(filtros);
            string url = "https://localhost:44342/api/Jugadores/filtro";

            HttpClient client = new HttpClient();
            var resultado = await PostAsync(url, filtrosJSON);

            lst = JsonConvert.DeserializeObject<List<JugadoresDTO>>(resultado);

            CargarJugadoresEnGrilla(lst);
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
    }
}
