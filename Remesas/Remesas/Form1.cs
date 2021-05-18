using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remesas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Miguel trabaja en Estados Unidos. Por cada 10 dólares que gana, envía 6 a su familia que vive en el estado de Guerrero. La semana pasada ganó 300 dólares ¿Cuánto enviará a su familia?","Ayuda",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calcular()
        {
            double valorusuario, dividir, resultadodivision, familia, final;

            valorusuario = Convert.ToDouble(textBox1.Text);
            dividir = 10;
            resultadodivision = valorusuario / dividir;
            familia = 6;
            final = resultadodivision * familia;

            label5.Text = Convert.ToString(final);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
