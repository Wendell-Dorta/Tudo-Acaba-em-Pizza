namespace TudoAcabaEmPizza
{
    partial class FrmCaixa
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
            label5 = new Label();
            label1 = new Label();
            txtAtendente = new TextBox();
            label2 = new Label();
            txtIdCliente = new TextBox();
            label3 = new Label();
            txtCod = new TextBox();
            label4 = new Label();
            dgvCaixa = new DataGridView();
            txtNomeCliente = new TextBox();
            txtDescricao = new TextBox();
            txtPreco = new TextBox();
            txtQuantidade = new TextBox();
            txtValor = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnCaixa = new Button();
            btnProduto = new Button();
            btnDeletar = new Button();
            btnEfetuarVenda = new Button();
            btnSair = new Button();
            label11 = new Label();
            label12 = new Label();
            btnIncluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCaixa).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Showcard Gothic", 55.75F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(685, 32);
            label5.Name = "label5";
            label5.Size = new Size(517, 95);
            label5.TabIndex = 12;
            label5.Text = "Cowabunga";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(122, 30);
            label1.TabIndex = 13;
            label1.Text = "Atendente:";
            // 
            // txtAtendente
            // 
            txtAtendente.Font = new Font("Segoe UI", 11F);
            txtAtendente.Location = new Point(152, 25);
            txtAtendente.Name = "txtAtendente";
            txtAtendente.Size = new Size(439, 27);
            txtAtendente.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(196, 30);
            label2.TabIndex = 13;
            label2.Text = "Código do Cliente:";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 11F);
            txtIdCliente.Location = new Point(214, 90);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(98, 27);
            txtIdCliente.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(185, 30);
            label3.TabIndex = 13;
            label3.Text = "Nome do Cliente:";
            // 
            // txtCod
            // 
            txtCod.Font = new Font("Segoe UI", 11F);
            txtCod.Location = new Point(12, 252);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(122, 27);
            txtCod.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(12, 148);
            label4.Name = "label4";
            label4.Size = new Size(185, 30);
            label4.TabIndex = 13;
            label4.Text = "Nome do Cliente:";
            // 
            // dgvCaixa
            // 
            dgvCaixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaixa.Location = new Point(12, 302);
            dgvCaixa.Name = "dgvCaixa";
            dgvCaixa.Size = new Size(1190, 274);
            dgvCaixa.TabIndex = 15;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Segoe UI", 11F);
            txtNomeCliente.Location = new Point(203, 153);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(377, 27);
            txtNomeCliente.TabIndex = 14;
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 11F);
            txtDescricao.Location = new Point(177, 252);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(286, 27);
            txtDescricao.TabIndex = 14;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Segoe UI", 11F);
            txtPreco.Location = new Point(492, 252);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(215, 27);
            txtPreco.TabIndex = 14;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 11F);
            txtQuantidade.Location = new Point(735, 252);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(113, 27);
            txtQuantidade.TabIndex = 14;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Segoe UI", 11F);
            txtValor.Location = new Point(879, 252);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(113, 27);
            txtValor.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.75F, FontStyle.Bold);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(49, 223);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 13;
            label6.Text = "Cod";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.75F, FontStyle.Bold);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(565, 223);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 13;
            label7.Text = "Preço";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.75F, FontStyle.Bold);
            label8.ForeColor = Color.Green;
            label8.Location = new Point(285, 223);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 13;
            label8.Text = "Descrição";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.75F, FontStyle.Bold);
            label9.ForeColor = Color.Green;
            label9.Location = new Point(767, 223);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 13;
            label9.Text = "Quantidade";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8.75F, FontStyle.Bold);
            label10.ForeColor = Color.Green;
            label10.Location = new Point(904, 223);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 13;
            label10.Text = "Valor";
            // 
            // btnCaixa
            // 
            btnCaixa.ForeColor = Color.Green;
            btnCaixa.Location = new Point(12, 610);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(137, 38);
            btnCaixa.TabIndex = 16;
            btnCaixa.Text = "&CLIENTE";
            btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnProduto
            // 
            btnProduto.ForeColor = Color.Green;
            btnProduto.Location = new Point(230, 610);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(137, 38);
            btnProduto.TabIndex = 16;
            btnProduto.Text = "&PRODUTO";
            btnProduto.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.ForeColor = Color.Green;
            btnDeletar.Location = new Point(443, 610);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(137, 38);
            btnDeletar.TabIndex = 16;
            btnDeletar.Text = "&DELETAR";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnEfetuarVenda
            // 
            btnEfetuarVenda.ForeColor = Color.Green;
            btnEfetuarVenda.Location = new Point(636, 610);
            btnEfetuarVenda.Name = "btnEfetuarVenda";
            btnEfetuarVenda.Size = new Size(137, 38);
            btnEfetuarVenda.TabIndex = 16;
            btnEfetuarVenda.Text = "&EFETUAR VENDA";
            btnEfetuarVenda.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.ForeColor = Color.Green;
            btnSair.Location = new Point(838, 610);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(137, 38);
            btnSair.TabIndex = 16;
            btnSair.Text = "&SAIR";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.75F, FontStyle.Bold);
            label11.ForeColor = Color.Green;
            label11.Location = new Point(1100, 614);
            label11.Name = "label11";
            label11.Size = new Size(60, 25);
            label11.TabIndex = 17;
            label11.Text = "Total:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold);
            label12.ForeColor = Color.Green;
            label12.Location = new Point(1001, 619);
            label12.Name = "label12";
            label12.Size = new Size(48, 20);
            label12.TabIndex = 17;
            label12.Text = "Total:";
            // 
            // btnIncluir
            // 
            btnIncluir.ForeColor = Color.Green;
            btnIncluir.Location = new Point(1025, 244);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(177, 44);
            btnIncluir.TabIndex = 18;
            btnIncluir.Text = "&INCLUIR";
            btnIncluir.UseVisualStyleBackColor = true;
            // 
            // FrmCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 660);
            Controls.Add(btnIncluir);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(btnSair);
            Controls.Add(btnEfetuarVenda);
            Controls.Add(btnDeletar);
            Controls.Add(btnProduto);
            Controls.Add(btnCaixa);
            Controls.Add(dgvCaixa);
            Controls.Add(txtNomeCliente);
            Controls.Add(txtValor);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtDescricao);
            Controls.Add(txtCod);
            Controls.Add(txtIdCliente);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtAtendente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            ForeColor = SystemColors.HotTrack;
            Name = "FrmCaixa";
            Text = "FrmCaixa";
            ((System.ComponentModel.ISupportInitialize)dgvCaixa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label1;
        private TextBox txtAtendente;
        private Label label2;
        private TextBox txtIdCliente;
        private Label label3;
        private TextBox txtCod;
        private Label label4;
        private DataGridView dgvCaixa;
        private TextBox txtNomeCliente;
        private TextBox txtDescricao;
        private TextBox txtPreco;
        private TextBox txtQuantidade;
        private TextBox txtValor;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnCaixa;
        private Button btnProduto;
        private Button btnDeletar;
        private Button btnEfetuarVenda;
        private Button btnSair;
        private Label label11;
        private Label label12;
        private Button btnIncluir;
    }
}