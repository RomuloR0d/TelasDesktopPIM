namespace TelasDesktopPIM
{
    partial class CadastroProducao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonVendas = new System.Windows.Forms.Button();
            this.buttonGestão = new System.Windows.Forms.Button();
            this.labelGestao = new System.Windows.Forms.Label();
            this.textBoxPlantio = new System.Windows.Forms.TextBox();
            this.textBoxColheita = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProduto1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonVendas);
            this.panel1.Controls.Add(this.buttonGestão);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 62);
            this.panel1.TabIndex = 32;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSair.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSair.Location = new System.Drawing.Point(732, 19);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(63, 32);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TelasDesktopPIM.Properties.Resources.LogoHorizontal_250;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonVendas
            // 
            this.buttonVendas.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonVendas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVendas.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonVendas.Location = new System.Drawing.Point(410, 14);
            this.buttonVendas.Name = "buttonVendas";
            this.buttonVendas.Size = new System.Drawing.Size(117, 37);
            this.buttonVendas.TabIndex = 3;
            this.buttonVendas.Text = "Vendas";
            this.buttonVendas.UseVisualStyleBackColor = false;
            this.buttonVendas.Click += new System.EventHandler(this.buttonVendas_Click);
            // 
            // buttonGestão
            // 
            this.buttonGestão.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGestão.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestão.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGestão.Location = new System.Drawing.Point(248, 14);
            this.buttonGestão.Name = "buttonGestão";
            this.buttonGestão.Size = new System.Drawing.Size(117, 37);
            this.buttonGestão.TabIndex = 1;
            this.buttonGestão.Text = "Gestão";
            this.buttonGestão.UseVisualStyleBackColor = false;
            this.buttonGestão.Click += new System.EventHandler(this.buttonGestão_Click);
            // 
            // labelGestao
            // 
            this.labelGestao.AutoSize = true;
            this.labelGestao.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestao.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelGestao.Location = new System.Drawing.Point(244, 95);
            this.labelGestao.Name = "labelGestao";
            this.labelGestao.Size = new System.Drawing.Size(319, 28);
            this.labelGestao.TabIndex = 33;
            this.labelGestao.Text = "CADASTRO DE PRODUÇÃO";
            // 
            // textBoxPlantio
            // 
            this.textBoxPlantio.Location = new System.Drawing.Point(249, 212);
            this.textBoxPlantio.Name = "textBoxPlantio";
            this.textBoxPlantio.Size = new System.Drawing.Size(194, 20);
            this.textBoxPlantio.TabIndex = 35;
            this.textBoxPlantio.TextChanged += new System.EventHandler(this.textBoxPlantio_TextChanged);
            // 
            // textBoxColheita
            // 
            this.textBoxColheita.Location = new System.Drawing.Point(249, 265);
            this.textBoxColheita.Name = "textBoxColheita";
            this.textBoxColheita.Size = new System.Drawing.Size(194, 20);
            this.textBoxColheita.TabIndex = 36;
            this.textBoxColheita.TextChanged += new System.EventHandler(this.textBoxColheita_TextChanged);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(249, 320);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(194, 20);
            this.textBoxQuantidade.TabIndex = 37;
            this.textBoxQuantidade.TextChanged += new System.EventHandler(this.textBoxQuantidade_TextChanged);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonConfirmar.ForeColor = System.Drawing.Color.MintCream;
            this.buttonConfirmar.Location = new System.Drawing.Point(249, 373);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmar.TabIndex = 38;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancelar.Location = new System.Drawing.Point(368, 373);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 39;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(246, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(246, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Data do Plantio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(246, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Data da Colheita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(246, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Quantidade";
            // 
            // textBoxProduto1
            // 
            this.textBoxProduto1.Location = new System.Drawing.Point(249, 171);
            this.textBoxProduto1.Name = "textBoxProduto1";
            this.textBoxProduto1.Size = new System.Drawing.Size(194, 20);
            this.textBoxProduto1.TabIndex = 44;
            this.textBoxProduto1.TextChanged += new System.EventHandler(this.textBoxProduto1_TextChanged);
            // 
            // CadastroProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxProduto1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxColheita);
            this.Controls.Add(this.textBoxPlantio);
            this.Controls.Add(this.labelGestao);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastroProducao";
            this.Text = "CadastroProducao";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonVendas;
        private System.Windows.Forms.Button buttonGestão;
        private System.Windows.Forms.Label labelGestao;
        private System.Windows.Forms.TextBox textBoxPlantio;
        private System.Windows.Forms.TextBox textBoxColheita;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProduto1;
    }
}