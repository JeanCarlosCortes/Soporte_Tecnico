using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeanCarlosCortes
{
    public partial class Tipos : Form
    {
        public Tipos()
        {
            InitializeComponent();
        }

        private void RPantallabutton_Click(object sender, EventArgs e)
        {
            Ticket_RPantalla formulario = new Ticket_RPantalla();
            this.Hide();
            formulario.Show();
        }

        private void RModulobutton_Click(object sender, EventArgs e)
        {
            Ticket_RCarga formulario = new Ticket_RCarga();
            this.Hide();
            formulario.Show();
        }

        private void CBateriabutton_Click(object sender, EventArgs e)
        {
            Ticket_CBateria formulario = new Ticket_CBateria();
            this.Hide();
            formulario.Show();
        }

        private void MPreventivobutton_Click(object sender, EventArgs e)
        {
            Ticket_MPreventivo formulario = new Ticket_MPreventivo();
            this.Hide();
            formulario.Show();
        }
    }
}
