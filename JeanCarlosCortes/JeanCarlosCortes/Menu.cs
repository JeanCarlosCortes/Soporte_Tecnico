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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Tiposbutton_Click(object sender, EventArgs e)
        {
            Tipos formulario = new Tipos();
            this.Hide();
            formulario.Show();
        }

        private void Estadosbutton_Click(object sender, EventArgs e)
        {
            Estados formulario = new Estados();
            this.Hide();
            formulario.Show();
        }

        private void Ticketbutton_Click(object sender, EventArgs e)
        {
            Ticket_RPantalla formulario = new Ticket_RPantalla();
            this.Hide();
            formulario.Show();
        }

        private void Detallesbutton_Click(object sender, EventArgs e)
        {
            Detalles formulario = new Detalles();
            this.Hide();
            formulario.Show();
        }
    }
}
