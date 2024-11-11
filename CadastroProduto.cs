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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
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



        private void textBoxProduto2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEstoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConProduto_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCanProduto_Click(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {

        }
    }
}
