using Liga_Cordobesa.App.Acceso_a_datos;
using Liga_Cordobesa.App.Dominio;
using Liga_Cordobesa.App.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liga_Cordobesa.App.Presentacion
{
    public partial class Form_Alta_Equipo : Form
    {
        private IDao dao;
        private Equipo equipo;
        private IService servicio;
        private Accion modo;

        Equipo oEquipo = new Equipo();
        Posicion oPosicion = new Posicion();

        public Form_Alta_Equipo(Accion modo, int nro)
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearService();
            this.modo = modo;
            dao = new EquipoDao();
        }

        private void Form_Alta_Equipo_Load(object sender, EventArgs e)
        {
            CargarComboPersonas();
            CargarComboPosicion();
            lblNroEquipo.Text = "Equipo Nro: " + dao.TraerNroEquipo();
        }

        private void FormInsertarPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Alta_Equipo_Load(sender, e);
        }

        private void CargarComboPosicion()
        {
            List<Posicion> lstPosicion = dao.TraerPosicion();

            //source es una lista de objetos
            cboPosicion.DataSource = lstPosicion;
            //valueMember y DisplayMember serán las properties de los objetos
            cboPosicion.ValueMember = "id_posicion";
            cboPosicion.DisplayMember = "NombrePosicion";
        }

        private void CargarComboPersonas()
        {
            List<Persona> lst = dao.TraerPersonas();

            //source es una lista de objetos
            cboJugador.DataSource = lst;
            //valueMember y DisplayMember serán las properties de los objetos
            cboJugador.ValueMember = "id_persona";
            cboJugador.DisplayMember = "nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInsertarPersona frmNuevo = new FormInsertarPersona(modo, 1);
            frmNuevo.ShowDialog();
        }

        private void dgvEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEquipo.CurrentCell.ColumnIndex == 5)
            {
                oEquipo.QuitarJugador(dgvEquipo.CurrentRow.Index);
                dgvEquipo.Rows.Remove(dgvEquipo.CurrentRow);
            }
        }

        private bool ExisteJugadorEnGrilla(string text)
        {
            foreach (DataGridViewRow fila in dgvEquipo.Rows)
            {
                if (fila.Cells["jugador"].Value.Equals(text))
                    return true;
            }
            return false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ExisteJugadorEnGrilla(cboJugador.Text))
            {
                MessageBox.Show("Jugador ya agregado en el equipo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Jugador item = new Jugador();

            Persona oPersona = (Persona)cboJugador.SelectedItem;
            Posicion oPosicion = (Posicion)cboPosicion.SelectedItem;
            item.Persona = oPersona;
            item.Posicion = oPosicion;
            item.Camiseta = (int)nudCamiseta.Value;

            oEquipo.AgregarJugador(item);

            dgvEquipo.Rows.Add(new object[] { "", oPersona.Nombre, oPosicion.NombrePosicion, item.Camiseta });
        }

        private void btnAceptar_Click(object sender, EventArgs e)
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
            //oEquipo.IdEquipo = dao.TraerNroEquipo();


            if (servicio.GrabarEquipo(oEquipo))
            {
                MessageBox.Show("Equipo guardado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error al intentar grabar el equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
