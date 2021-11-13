using System;
using System.Windows.Forms;

namespace JeanCarlosCortes
{
    public partial class Ticket_RPantalla : Form
    {
        public Ticket_RPantalla()
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
            Precio = 500;
            Subtotal = Convert.ToInt32(Precio * cantidad);
            Impuesto = Convert.ToInt32(Subtotal * 0.15);
            Total = Convert.ToInt32(Subtotal + Impuesto);
            PreciotextBox.Text = Convert.ToString(Precio);
            SubtotaltextBox.Text = Convert.ToString(Subtotal);
            ImpuestotextBox.Text = Convert.ToString(Impuesto);
            TotaltextBox.Text = Convert.ToString(Total);
            dataGridView.Rows.Add(NombretextBox.Text, "Reparación de panatalla", SOcomboBox.Text, SubtotaltextBox.Text, 
                                    ImpuestotextBox.Text, TotaltextBox.Text);
           
            tickets.Nombre = NombretextBox.Text;
            tickets.Tipo_servicio = "Reparacion de pantalla";
            tickets.Sistema_operativo = SOcomboBox.Text;
            tickets.Precio = Convert.ToInt32("500");
            tickets.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
            tickets.Subtotal = Convert.ToDecimal(SubtotaltextBox.Text);
            tickets.Impuesto = Convert.ToDecimal(ImpuestotextBox.Text);
            tickets.Total = Convert.ToDecimal(TotaltextBox.Text);

            bool inserto = conexion.InsertarTICKETS(tickets);

            if (inserto)
            {
                MessageBox.Show("Producto registrado");
                NombretextBox.Text = "";
                SOcomboBox.Text = "";
                CantidadtextBox.Clear();
                SubtotaltextBox.Clear();
                ImpuestotextBox.Clear();
                TotaltextBox.Clear();
                PreciotextBox.Text = string.Empty;
                tickets = null;
            }
            else
            {
                MessageBox.Show("No se registro el producto");
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

        private void Detallesbutton_Click(object sender, EventArgs e)
        {
            Detalles formulario = new Detalles();
            this.Hide();
            formulario.Show();
        }
    }
}
