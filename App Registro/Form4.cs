using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Registro
{
    public partial class Form4 : Form
    {
        private List<Empleado> listaEmpleados = new List<Empleado>();
        public Form4()
        {
            InitializeComponent();
            CargarTodosLosEmpleados();  
            
        }

        SqlConnection conexion = new SqlConnection(@"Server=moneyboyzz;Database=GestionAsistencia;Integrated Security=True;");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void CargarTodosLosEmpleados()
        {
            try
            {
                conexion.Open();

                string consulta = "select * from Empleados"; // Seleccionar todos los empleados
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, conexion);

                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dtEliminarPersonal.DataSource = dt; // Asignar los datos al DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide(); // Ocultar el Form1 actual
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)

        {
            int idEmpleado;

            // Validar si el valor ingresado es un número entero
            if (!int.TryParse(txtEliminarEmpleado.Text, out idEmpleado))
            {
                MessageBox.Show("Por favor, ingrese un número entero válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si la validación falla
            }

            try
            {
                conexion.Open();

                // Crear consulta SQL con parámetro
                string consulta = "select * from Empleados where id_empleado = @idEmpleado";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, conexion);

                // Asignar el valor del parámetro
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                // Llenar DataTable con los resultados
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                // Mostrar los resultados en el DataGridView
                dtEliminarPersonal.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al realizar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión siempre, independientemente de si hubo un error o no
                conexion.Close();
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarTodosLosEmpleados();
        }
    }

    public class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Estado { get; set; }
    }

}
