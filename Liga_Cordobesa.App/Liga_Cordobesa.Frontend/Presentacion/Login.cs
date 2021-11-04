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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void chbMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            string text = txtContraseña.Text;
            if (chbMostrarPass.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
                txtContraseña.Text = text;

            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
                txtContraseña.Text = text;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "" || txtContraseña.Text.Trim() == "")
            {
                MessageBox.Show("No se ingreso usuario y/o contraseña");
                return;
            }

            List<Parametro> filtros = new List<Parametro>();
            Parametro login = new Parametro();
            login.Nombre = "usuario";
            login.Valor = txtUsuario.Text;
            filtros.Add(login);
            filtros.Add(new Parametro("contraseña", txtContraseña.Text));

            bool existUser = false;

            string filtrosJSON = JsonConvert.SerializeObject(filtros);
            string url = "https://localhost:44342/api/Usuarios";
            

            var result = await this.PostAsync(url, filtrosJSON);

            existUser = JsonConvert.DeserializeObject<Boolean>(result);

            if(existUser)
            {
                FormPrincipal form = new FormPrincipal();
                form.Show();
                //this.Close();
            } else
            {
                MessageBox.Show("Usuario y/o contraseña Incorrecta");
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
    }
}
