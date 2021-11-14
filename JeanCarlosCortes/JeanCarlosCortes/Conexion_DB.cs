using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeanCarlosCortes
{
    public class ConexionDB
    {
        readonly string cadena = "Data Source=DESKTOP-6ER197J\\SQLEXPRESS;Initial Catalog=Soporte; Integrated Security=True";

        public bool ValidarUsuarios(Usuarios user)
        {
            bool esUsuarioValido = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT 1 FROM LOGIN WHERE USUARIO = @User AND CONTRASEÑA = @Contraseña AND NOMBRE = @Nombre;");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@User", SqlDbType.NVarChar, 50).Value = user.Usuario;
                        comando.Parameters.Add("@Contraseña", SqlDbType.NVarChar, 50).Value = user.Contraseña;
                        comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = user.Nombre;
                        esUsuarioValido = Convert.ToBoolean(comando.ExecuteScalar());
                    }
                }
            }
            catch (Exception)
            {

            }
            return esUsuarioValido;
        }

        public bool InsertarTICKETS(Tickets tickets)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TICKETS ");
                sql.Append(" VALUES (@Nombre, @Tipo_servicio, @Sistema_operativo, @Precio, @Cantidad, @Subtotal, @Impuesto, @Total); ");


                string sentenciaSQL = "INSERT INTO TICKETS VALUES (@Nombre, @Tipo_servicio, @Sistema_operativo, " +
                    "                                              @Precio, @Cantidad, @Subtotal, @Impuesto, @Total); ";

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = tickets.Nombre;
                        comando.Parameters.Add("@Tipo_servicio", SqlDbType.NVarChar, 50).Value = tickets.Tipo_servicio;
                        comando.Parameters.Add("@Sistema_operativo", SqlDbType.NVarChar, 50).Value = tickets.Sistema_operativo;
                        comando.Parameters.Add("@Precio", SqlDbType.Int).Value = tickets.Precio;
                        comando.Parameters.Add("@Cantidad", SqlDbType.Int).Value = tickets.Cantidad;
                        comando.Parameters.Add("@Subtotal", SqlDbType.Decimal).Value = tickets.Subtotal;
                        comando.Parameters.Add("@Impuesto", SqlDbType.Decimal).Value = tickets.Impuesto;
                        comando.Parameters.Add("@Total", SqlDbType.Decimal).Value = tickets.Total;

                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
