using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Registro
{

    public partial class Form5 : Form
    {
        // Simulamos una base de datos de empleados
        private List<Empleado2> listaEmpleados2 = new List<Empleado2>();

        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"Server=moneyboyzz;Database=GestionAsistencia;Integrated Security=True;");

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide(); // Ocultar el Form5 actual
        }

        private void btnAgregarNuevoEmpleado_Click(object sender, EventArgs e)
        {
            
                conexion.Open();
                string consulta = "insert into Empleados values (id_empleado, nombre, apellido, cargo, departamento, rol) values('" + txtIDNuevoEmpleado + "'," + txtNombreNuevoEmpleado + "," + txtApellidoNuevoEmpleado + "," + txtCargoNuevoEmpleado + "," + txtDepartamentoNuevoEmpleado + "," + txtRolNuevoEmpleado + ")";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("sisi");
            
        }

        private void txtNombreNuevoEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoNuevoEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCargoNuevoEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDepartamentoNuevoEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRolNuevoEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

    // Clase para representar un empleado
    public class Empleado2
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public string Rol { get; set; }
    }
}
