﻿using System;
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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void buttonProducao_Click(object sender, EventArgs e)
        {
            Producao producao = new Producao();
            producao.ShowDialog();
        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            vendas.ShowDialog();
        }

        private void buttonPerfil_Click(object sender, EventArgs e)
        {
            TelaPerfil perfil = new TelaPerfil(); 
            perfil.ShowDialog();
        }

        private void buttonGestão_Click(object sender, EventArgs e)
        {
            Gestao gestao = new Gestao();
            gestao.ShowDialog();
        }
    }
}