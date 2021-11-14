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
    public partial class Ticket_MPreventivo : Form
    {
        public Ticket_MPreventivo()
        {
            InitializeComponent();
        }
        ConexionDB conexion = new ConexionDB();
        Tickets tickets = new Tickets();

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            int Precio, cantidad;
            double Subtotal, Total, Impuesto;
            cantidad = Convert.ToInt32(CantidadtextBox.Text);
            Precio = 600;
            Subtotal = Convert.ToInt32(Precio * cantidad);
            Impuesto = Convert.ToInt32(Subtotal * 0.15);
            Total = Convert.ToInt32(Subtotal + Impuesto);
            PreciotextBox.Text = Convert.ToString(Precio);
            SubtotaltextBox.Text = Convert.ToString(Subtotal);
            ImpuestotextBox.Text = Convert.ToString(Impuesto);
            TotaltextBox.Text = Convert.ToString(Total);
            dataGridView.Rows.Add(NombretextBox.Text, "Mantenimiento preventivo", SOcomboBox.Text, SubtotaltextBox.Text,
                                    ImpuestotextBox.Text, TotaltextBox.Text);

            tickets.Nombre = NombretextBox.Text;
            tickets.Tipo_servicio = "Mantenimiento Preventivo";
            tickets.Sistema_operativo = SOcomboBox.Text;
            tickets.Precio = Convert.ToInt32("600");
            tickets.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
            tickets.Subtotal = Convert.ToDecimal(SubtotaltextBox.Text);
            tickets.Impuesto = Convert.ToDecimal(ImpuestotextBox.Text);
            tickets.Total = Convert.ToDecimal(TotaltextBox.Text);

            bool inserto = conexion.InsertarTICKETS(tickets);

            if (inserto)
            {
                MessageBox.Show("Ticket registrado");
            }
            else
            {
                MessageBox.Show("No se registro el ticket");
            }
            if (NombretextBox.Text == "")
            {
                errorProvider.SetError(NombretextBox, "Ingrese el nombre");
                NombretextBox.Focus();
                return;
            }
            if (SOcomboBox.Text == "")
            {
                errorProvider.SetError(SOcomboBox, "Ingrese el sistema operativo");
                SOcomboBox.Focus();
                return;
            }
            if (MarcatextBox.Text == "")
            {
                errorProvider.SetError(MarcatextBox, "Ingrese la marca de su computadora");
                MarcatextBox.Focus();
                return;
            }
            if (CantidadtextBox.Text == "")
            {
                errorProvider.SetError(CantidadtextBox, "Ingrese la cantidad");
                CantidadtextBox.Focus();
                return;
            }
        }
        private void Salirbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menubutton_Click(object sender, EventArgs e)
        {
            Menu formulario = new Menu();
            this.Hide();
            formulario.Show();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            NombretextBox.Text = "";
            SOcomboBox.Text = "";
            MarcatextBox.Text = "";
            CantidadtextBox.Clear();
            PreciotextBox.Clear();
            SubtotaltextBox.Clear();
            ImpuestotextBox.Clear();
            TotaltextBox.Clear();
        }
    }
}
