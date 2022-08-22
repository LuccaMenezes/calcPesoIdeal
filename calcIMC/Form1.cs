using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAltura.Clear();
            cmbSexo.Text = "";
            txtNome.Focus();
        }

        private void btnPesoIdeal_Click(object sender, EventArgs e)
        {
            try
            {
                Double Altura = 0;
                Double PesoIdeal = 0;

                Altura = double.Parse(txtAltura.Text);
                if (cmbSexo.Text == "Feminino")
                {
                    PesoIdeal = (62.7 * Altura) - 44.7;
                    MessageBox.Show(txtNome.Text + ", seu peso ideal é: " + PesoIdeal.ToString() + " Kg.", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbSexo.Text == "Masculino")
                {
                    PesoIdeal = (72.7 * Altura) - 58;
                    MessageBox.Show(txtNome.Text + ", seu peso ideal é: " + PesoIdeal.ToString() + " Kg.", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Escolha o sexo", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique os valores informados", "Peso ideal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
