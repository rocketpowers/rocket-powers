using rocketpowers.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rocketpowers.view
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem=controle.cadastrar(txtLogin.Text, TxtSenha.Text, txtConfirm.Text);
            if(controle.tem)
            {
                MessageBox.Show(mensagem, "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);//errrr
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
