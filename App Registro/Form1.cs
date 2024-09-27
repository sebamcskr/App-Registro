using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Registro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Obtener el usuario y la contraseña ingresados
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Verificar si es empleado o administrador
            if (usuario == "empleado" && contraseña == "0000")
            {
                // Si es empleado, abrir Form2
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide(); // Ocultar el Form1 actual
            }
            else if (usuario == "admin" && contraseña == "1111")
            {
                // Si es administrador, abrir Form3
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide(); // Ocultar el Form1 actual
            }
            else
            {
                // Si los datos son incorrectos, mostrar un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
