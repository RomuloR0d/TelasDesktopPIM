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
    public partial class ListClientes : Form
    {
        public ListClientes()
        {
            InitializeComponent();
        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            vendas.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGestão_Click(object sender, EventArgs e)
        {
            Gestao gestao = new Gestao();
            gestao.ShowDialog();
        }





        private void textBoxCpfCnpj_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDataRegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void DeletClient_Click(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {

        }
    }
}
