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
    public partial class GesProducoes : Form
    {
        public GesProducoes()
        {
            InitializeComponent();
        }

        private void buttonGestão_Click(object sender, EventArgs e)
        {
            Gestao gestao = new Gestao();
            gestao.ShowDialog();
        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            vendas.ShowDialog();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroProducao cadastroProducao = new CadastroProducao();
            cadastroProducao.ShowDialog();
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDataPlantio_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxDelProducao_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxEditProducao_Click(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {

        }
    }
}
