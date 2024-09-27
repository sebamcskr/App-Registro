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
    public partial class Form6 : Form
    {

        private List<Empleado> listaEmpleados = new List<Empleado>();

        public Form6()
        {
            InitializeComponent();
            InicializarDataGridView();
            CargarTodosLosEmpleados();



        }
        

        SqlConnection conexion = new SqlConnection(@"Server=moneyboyzz;Database=GestionAsistencia;Integrated Security=True;");
    

        private void InicializarDataGridView()
        {

        }

       

        private void CargarDatos()
        {
            // Crear la conexión SQL
                //conexion.Open ();
            {
                //try
                {
                   
                    // Consulta SQL
                   // string query = "SELECT * FROM Empleados";

                    // Adaptador para llenar el DataTable
                   // SqlDataAdapter da = new SqlDataAdapter(query, conexion);

                    // Llenar el DataTable con los datos
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);

                    // Asignar los datos al DataGridView
                    //dtEditarPersonal.DataSource = dt;
                }
               // catch (Exception ex)
                {
                 //   MessageBox.Show("Error: " + ex.Message);
                }
            }



        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide(); // Ocultar el Form1 actual
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cambios guardados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            var filtro = txtEditarPersonal.Text.ToLower();
            dtEditarPersonal.DataSource = listaEmpleados
                .Where(emp => emp.Nombre.ToLower().Contains(filtro))
                .ToList();
        }

        private void dtEditarPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide(); // Ocultar el Form1 actual
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
                dtEditarPersonal.DataSource = dt; // Asignar los datos al DataGridView
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


        private void btnBuscarEmpleado_Click_1(object sender, EventArgs e)
        {
            int idEmpleado;

            // Validar si el valor ingresado es un número entero
            if (!int.TryParse(txtEditarPersonal.Text, out idEmpleado))
            {
                MessageBox.Show("Por favor, ingrese un número entero válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si la validación falla
            }

            try
            {
                conexion.Open();

                string consulta = "select * from Empleados where id_empleado = @idEmpleado";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta, conexion);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dtEditarPersonal.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al realizar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarTodosLosEmpleados();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtEditarPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dtEditarPersonal.SelectedCells[0].Value.ToString();
            textBox2.Text = dtEditarPersonal.SelectedCells[1].Value.ToString();
            textBox3.Text = dtEditarPersonal.SelectedCells[2].Value.ToString();
            textBox4.Text = dtEditarPersonal.SelectedCells[3].Value.ToString();
            textBox5.Text = dtEditarPersonal.SelectedCells[4].Value.ToString();
            textBox6.Text = dtEditarPersonal.SelectedCells[5].Value.ToString();
        }
    }

    public class Empleado3
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Estado { get; set; }
    }
}
       
  


