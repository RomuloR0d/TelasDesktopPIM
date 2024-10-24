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
    public partial class Gestao : Form
    {
        public Gestao()
        {
            InitializeComponent();
        }

        private void Gestao_Load(object sender, EventArgs e)
        {

        }

        private void buttonPerfil_Click(object sender, EventArgs e)
        {
            TelaPerfil perfil = new TelaPerfil();
            perfil.ShowDialog();
        }

        private void buttonGestão_Click(object sender, EventArgs e)
        {

        }

        private void buttonProducao_Click(object sender, EventArgs e)
        {
            Producao Producao = new Producao();
            Producao.ShowDialog();
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
    }
}
