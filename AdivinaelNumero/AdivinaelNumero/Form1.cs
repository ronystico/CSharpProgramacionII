using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdivinaelNumero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAdivinar.Enabled = false;
            txtNumero.Enabled = false;

        }

        int ngenerado, nusuario, intentos = 5;
        Random rand = new Random();

        private void ComenzaryReiniciar ()
        {
            if (btnComenzar.Text == "Comenzar")
            {
                ngenerado = rand.Next(1, 11);
                timer1.Enabled = true;

                txtNumero.Text = string.Empty;
                btnAdivinar.Enabled = true;
                btnComenzar.Text = "Reiniciar";
                txtNumero.Enabled = true;
            }
            else if (btnComenzar.Text == "Reiniciar") 
            {
                // Reiniciar intentos
                btnAdivinar.Enabled = false;
                intentos = 5;
                btnComenzar.Text = "Comenzar";
                txtNumero.Enabled = false;
            }
        }

        private void Verificar()
        {
            nusuario = Convert.ToInt32(txtNumero.Text);

            if (ngenerado == nusuario)
            {
                MessageBox.Show("GANASTE!!!", "GANASTE!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ComenzaryReiniciar();
            }
            else if (ngenerado != nusuario)
            {
                intentos = intentos - 1;
                txtNumero.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elige un número del 1 al 10. Tienes 5 intentos para descubrir cuál es","Ayuda",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            ComenzaryReiniciar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (intentos <= 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("perdiste","perdiste",MessageBoxButtons.OK,MessageBoxIcon.Error);
                intentos = 5;
                label3.Text = "Intentos disponibles: " + intentos;
                ComenzaryReiniciar();
            }
            else
            {
                label3.Text = "Intentos disponibles: " + intentos;
            }
        }

        private void btnAdivinar_Click(object sender, EventArgs e)
        {
            Verificar();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
