using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Registro
{
    internal class GestionAsistenciaDB
    {
        private string connectionString = @"Server=moneyboyzz;Database=GestionAsistencia;Integrated Security=True;";


        public DataTable ObtenerDatosAsistencia()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    conn.Open();

                    // Consulta para obtener los datos de la tabla de asistencia
                    string query = "SELECT * FROM Asistencia"; // Ajusta la consulta según tu tabla

                    // Crear un adaptador para llenar el DataTable
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    // Llenar el DataTable con los datos obtenidos
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos: " + ex.Message);
                }
            }

            return dt;
        }
    }
}
