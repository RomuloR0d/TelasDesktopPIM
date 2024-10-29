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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void buttonGestão_Click(object sender, EventArgs e)
        {
            Gestao gestao = new Gestao();
            gestao.ShowDialog();
        }



        private void buttonPerfil_Click(object sender, EventArgs e)
        {
            TelaPerfil perfil = new TelaPerfil();
            perfil.ShowDialog();
        }

        private void textBoxcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDataCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {

        }
    }
}
