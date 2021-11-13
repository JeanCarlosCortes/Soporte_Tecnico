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
    public partial class Detalles : Form
    {

        public Detalles()
        {
            InitializeComponent();
        }
        Tickets tickets = new Tickets();
        private void Historialbutton_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Add(tickets.Nombre, tickets.Tipo_servicio, tickets.Sistema_operativo, tickets.Precio,
                                          tickets.Cantidad, tickets.Subtotal, tickets.Impuesto, tickets.Total);
        }

        private void Menubutton_Click(object sender, EventArgs e)
        {
            Menu formulario = new Menu();
            this.Hide();
            formulario.Show();
        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
