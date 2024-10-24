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
    public partial class Producao : Form
    {
        public Producao()
        {
            InitializeComponent();
        }

        private void buttonGestão_Click(object sender, EventArgs e)
        {
            Gestao Gestao = new Gestao();
            Gestao.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            vendas.ShowDialog();
        }

        private void buttonRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio Relatorio = new Relatorio();
            Relatorio.ShowDialog();
        }

        private void buttonPerfil_Click(object sender, EventArgs e)
        {
            TelaPerfil perfil = new TelaPerfil();   
            perfil.ShowDialog();
        }

        private void buttonProducao_Click(object sender, EventArgs e)
        {

        }
    }
}
