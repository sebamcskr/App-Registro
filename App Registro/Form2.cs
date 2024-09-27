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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxpresente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxterreno_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Verificar si ninguno o ambos CheckBox están seleccionados
            if (checkBoxpresente.Checked && checkBoxterreno.Checked)
            {
                MessageBox.Show("No puedes seleccionar ambos campos. Por favor, selecciona solo uno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!checkBoxpresente.Checked && !checkBoxterreno.Checked)
            {
                MessageBox.Show("Debes seleccionar al menos una opción antes de enviar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Guardar los datos si solo un CheckBox está seleccionado
                if (checkBoxpresente.Checked)
                {
                    // Guardar lógica para "Presente"
                    MessageBox.Show("Se ha registrado como presente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (checkBoxterreno.Checked)
                {
                    // Guardar lógica para "Terreno"
                    MessageBox.Show("Se ha registrado en terreno.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Aquí puedes agregar tu lógica para guardar los datos
            }
        }
    }
}
