using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeanCarlosCortes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        ConexionDB conexion = new ConexionDB();
        Usuarios user = new Usuarios();
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            user.Nombre = NombretextBox.Text;
            user.Usuario = CorreotextBox.Text;
            user.Contraseña = ContraseñatextBox.Text;

            bool valido = conexion.ValidarUsuarios(user);
            if (valido)
            {
                Menu formulario = new Menu();
                this.Hide();
                formulario.Show();

            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
            if (CorreotextBox.Text == "")
            {
                errorProvider1.SetError(CorreotextBox, "Ingrese correo");
                CorreotextBox.Focus();
                return;
            }
            if (ContraseñatextBox.Text == "")
            {
                errorProvider1.SetError(ContraseñatextBox, "Ingrese contraseña");
                ContraseñatextBox.Focus();
                return;
            }


        }
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
