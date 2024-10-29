namespace TelasDesktopPIM
{
    partial class TelaPerfil
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
            this.buttonPerfil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonVendas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.textBoxNascimento = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.buttonGestao = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.buttonGestao);
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.buttonPerfil);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonVendas);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 66);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSair.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSair.Location = new System.Drawing.Point(759, 22);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(39, 26);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonPerfil
            // 
            this.buttonPerfil.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonPerfil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPerfil.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPerfil.Location = new System.Drawing.Point(394, 22);
            this.buttonPerfil.Name = "buttonPerfil";
            this.buttonPerfil.Size = new System.Drawing.Size(93, 26);
            this.buttonPerfil.TabIndex = 4;
            this.buttonPerfil.Text = "Perfil";
            this.buttonPerfil.UseVisualStyleBackColor = false;
            this.buttonPerfil.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TelasDesktopPIM.Properties.Resources.LogoHorizontal_250;
            this.pictureBox1.Location = new System.Drawing.Point(529, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonVendas
            // 
            this.buttonVendas.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonVendas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVendas.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonVendas.Location = new System.Drawing.Point(224, 22);
            this.buttonVendas.Name = "buttonVendas";
            this.buttonVendas.Size = new System.Drawing.Size(93, 26);
            this.buttonVendas.TabIndex = 3;
            this.buttonVendas.Text = "Vendas";
            this.buttonVendas.UseVisualStyleBackColor = false;
            this.buttonVendas.Click += new System.EventHandler(this.buttonVendas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(249, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Olá Farmer!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(249, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mantenha seus dados sempre atualizados:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(252, 166);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(319, 20);
            this.textBoxNome.TabIndex = 11;
            this.textBoxNome.Text = "nome";
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(252, 224);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(147, 20);
            this.textBoxEmail.TabIndex = 12;
            this.textBoxEmail.Text = "e-mail";
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(424, 224);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(147, 20);
            this.textBoxTelefone.TabIndex = 13;
            this.textBoxTelefone.Text = "Telefone";
            this.textBoxTelefone.TextChanged += new System.EventHandler(this.textBoxTelefone_TextChanged);
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(252, 272);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(147, 20);
            this.textBoxCpf.TabIndex = 14;
            this.textBoxCpf.Text = "CPF";
            this.textBoxCpf.TextChanged += new System.EventHandler(this.textBoxCpf_TextChanged);
            // 
            // textBoxNascimento
            // 
            this.textBoxNascimento.Location = new System.Drawing.Point(424, 272);
            this.textBoxNascimento.Name = "textBoxNascimento";
            this.textBoxNascimento.Size = new System.Drawing.Size(147, 20);
            this.textBoxNascimento.TabIndex = 15;
            this.textBoxNascimento.Text = "Nascimento";
            this.textBoxNascimento.TextChanged += new System.EventHandler(this.textBoxNascimento_TextChanged);
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(252, 333);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(319, 20);
            this.textBoxEndereco.TabIndex = 16;
            this.textBoxEndereco.Text = "endereço";
            this.textBoxEndereco.TextChanged += new System.EventHandler(this.textBoxEndereco_TextChanged);
            // 
            // buttonGestao
            // 
            this.buttonGestao.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGestao.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestao.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGestao.Location = new System.Drawing.Point(51, 22);
            this.buttonGestao.Name = "buttonGestao";
            this.buttonGestao.Size = new System.Drawing.Size(93, 26);
            this.buttonGestao.TabIndex = 17;
            this.buttonGestao.Text = "Gestão";
            this.buttonGestao.UseVisualStyleBackColor = false;
            this.buttonGestao.Click += new System.EventHandler(this.buttonGestao_Click);
            // 
            // TelaPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.textBoxNascimento);
            this.Controls.Add(this.textBoxCpf);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "TelaPerfil";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonVendas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPerfil;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.TextBox textBoxNascimento;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Button buttonGestao;
    }
}