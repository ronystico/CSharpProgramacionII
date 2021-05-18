using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemesasAhorro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Luisa trabaja en Monterrey. De cada $5 que gana, ahorra $3 y de cada $12 que ahorra, manda 7 a su mamá que vive en Oaxaca. La semana pasada ganó $1000. ¿Cuánto le enviará a su mamá?", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            double valorganado, gruposganado, gruposahorrado, totalahorro;

            valorganado = Convert.ToDouble(textBox1.Text);
            gruposganado = 5;
            gruposahorrado = 3;
            totalahorro = (valorganado / 5) * 3;
            label9.Text = Convert.ToString(totalahorro);

            double gruposremesa, gruposenviado, totalenviado;
            gruposremesa = 12;
            gruposenviado = 7;
            totalenviado = (totalahorro / 12) * 7;
            label5.Text = Convert.ToString(totalenviado);

            double totalquedado;
            totalquedado = totalahorro - totalenviado;
            label7.Text = Convert.ToString(totalquedado);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
