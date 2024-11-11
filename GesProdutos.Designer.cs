namespace TelasDesktopPIM
{
    partial class GesProdutos
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
            this.textBoxEstoque = new System.Windows.Forms.TextBox();
            this.textProdutoNome = new System.Windows.Forms.TextBox();
            this.textBoxCodProduto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGestao = new System.Windows.Forms.Label();
            this.pictureBoxDelProduto = new System.Windows.Forms.PictureBox();
            this.textBoxPreco2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxEditProduto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonVendas);
            this.panel1.Controls.Add(this.buttonGestão);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 64);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSair.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSair.Location = new System.Drawing.Point(742, 22);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(56, 26);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TelasDesktopPIM.Properties.Resources.LogoHorizontal_250;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonVendas
            // 
            this.buttonVendas.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonVendas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVendas.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonVendas.Location = new System.Drawing.Point(433, 18);
            this.buttonVendas.Name = "buttonVendas";
            this.buttonVendas.Size = new System.Drawing.Size(120, 35);
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
            this.buttonGestão.Location = new System.Drawing.Point(275, 18);
            this.buttonGestão.Name = "buttonGestão";
            this.buttonGestão.Size = new System.Drawing.Size(120, 35);
            this.buttonGestão.TabIndex = 1;
            this.buttonGestão.Text = "Gestão";
            this.buttonGestão.UseVisualStyleBackColor = false;
            this.buttonGestão.Click += new System.EventHandler(this.buttonGestão_Click);
            // 
            // textBoxEstoque
            // 
            this.textBoxEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEstoque.Location = new System.Drawing.Point(527, 191);
            this.textBoxEstoque.Name = "textBoxEstoque";
            this.textBoxEstoque.Size = new System.Drawing.Size(127, 21);
            this.textBoxEstoque.TabIndex = 30;
            this.textBoxEstoque.TextChanged += new System.EventHandler(this.textBoxEstoque_TextChanged);
            // 
            // textProdutoNome
            // 
            this.textProdutoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProdutoNome.Location = new System.Drawing.Point(172, 191);
            this.textProdutoNome.Name = "textProdutoNome";
            this.textProdutoNome.Size = new System.Drawing.Size(123, 21);
            this.textProdutoNome.TabIndex = 29;
            this.textProdutoNome.Text = "Grão-de-bico";
            this.textProdutoNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxCodProduto
            // 
            this.textBoxCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodProduto.Location = new System.Drawing.Point(36, 191);
            this.textBoxCodProduto.Name = "textBoxCodProduto";
            this.textBoxCodProduto.Size = new System.Drawing.Size(96, 21);
            this.textBoxCodProduto.TabIndex = 28;
            this.textBoxCodProduto.Text = "123";
            this.textBoxCodProduto.TextChanged += new System.EventHandler(this.textBoxCodProduto_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(495, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 46);
            this.button1.TabIndex = 27;
            this.button1.Text = "Cadastrar produto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(524, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Estoque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(169, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nome do Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(33, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Código";
            // 
            // labelGestao
            // 
            this.labelGestao.AutoSize = true;
            this.labelGestao.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestao.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelGestao.Location = new System.Drawing.Point(82, 93);
            this.labelGestao.Name = "labelGestao";
            this.labelGestao.Size = new System.Drawing.Size(234, 28);
            this.labelGestao.TabIndex = 23;
            this.labelGestao.Text = "LISTA DE PRODUTOS";
            // 
            // pictureBoxDelProduto
            // 
            this.pictureBoxDelProduto.Image = global::TelasDesktopPIM.Properties.Resources.ic_lixeira_70;
            this.pictureBoxDelProduto.Location = new System.Drawing.Point(703, 185);
            this.pictureBoxDelProduto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxDelProduto.Name = "pictureBoxDelProduto";
            this.pictureBoxDelProduto.Size = new System.Drawing.Size(19, 27);
            this.pictureBoxDelProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDelProduto.TabIndex = 44;
            this.pictureBoxDelProduto.TabStop = false;
            this.pictureBoxDelProduto.Click += new System.EventHandler(this.pictureBoxDelProduto_Click);
            // 
            // textBoxPreco2
            // 
            this.textBoxPreco2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPreco2.Location = new System.Drawing.Point(358, 191);
            this.textBoxPreco2.Name = "textBoxPreco2";
            this.textBoxPreco2.Size = new System.Drawing.Size(127, 21);
            this.textBoxPreco2.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(355, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Preço";
            // 
            // pictureBoxEditProduto
            // 
            this.pictureBoxEditProduto.Image = global::TelasDesktopPIM.Properties.Resources.ic_lapis352;
            this.pictureBoxEditProduto.Location = new System.Drawing.Point(659, 185);
            this.pictureBoxEditProduto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEditProduto.Name = "pictureBoxEditProduto";
            this.pictureBoxEditProduto.Size = new System.Drawing.Size(38, 37);
            this.pictureBoxEditProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEditProduto.TabIndex = 48;
            this.pictureBoxEditProduto.TabStop = false;
            this.pictureBoxEditProduto.Click += new System.EventHandler(this.pictureBoxEditProduto_Click);
            // 
            // GesProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxEditProduto);
            this.Controls.Add(this.textBoxPreco2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxDelProduto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxEstoque);
            this.Controls.Add(this.textProdutoNome);
            this.Controls.Add(this.textBoxCodProduto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGestao);
            this.Name = "GesProdutos";
            this.Text = "GesProdutos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonVendas;
        private System.Windows.Forms.Button buttonGestão;
        private System.Windows.Forms.TextBox textBoxEstoque;
        private System.Windows.Forms.TextBox textProdutoNome;
        private System.Windows.Forms.TextBox textBoxCodProduto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGestao;
        private System.Windows.Forms.PictureBox pictureBoxDelProduto;
        private System.Windows.Forms.TextBox textBoxPreco2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxEditProduto;
    }
}