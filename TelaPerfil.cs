using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasDesktopPIM
{
    public partial class TelaPerfil : Form
    {
        public TelaPerfil()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void buttonVendas_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            vendas.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {

        }

        private void buttonGestao_Click(object sender, EventArgs e)
        {
            Gestao gestao = new Gestao();
            gestao.ShowDialog();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEndereco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
