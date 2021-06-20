
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using rocketpowers.Model;
using rocketpowers.view;

namespace rocketpowers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }

        private void btnCad_Click(object sender, EventArgs e)
        {


            Cadastro cad = new Cadastro();
            cad.Show();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtlogin.Text, txtsenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {

                    MessageBox.Show("login sucess", "waiting loading", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    View.Form3 well = new View.Form3();
                    well.Show();
                }



                else
                {

                    MessageBox.Show("login not found, check the login and password inserted", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);

                {

                }

            }
        }
    }
}