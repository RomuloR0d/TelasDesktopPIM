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
    public partial class CadastroProducao : Form
    {
        public CadastroProducao()
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



        private void textBoxProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPlantio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxColheita_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxProduto1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {

        }
    }
}
