namespace TudoAcabaEmPizza
{
    partial class FrmTipoPag
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
            dgvTipoPagamento = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnPreco = new DataGridViewTextBoxColumn();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtDescricao = new TextBox();
            txtId = new TextBox();
            btnObterPorId = new Button();
            label4 = new Label();
            txtSigla = new TextBox();
            btnEditar = new Button();
            btnInserir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTipoPagamento).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTipoPagamento
            // 
            dgvTipoPagamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoPagamento.Columns.AddRange(new DataGridViewColumn[] { clnId, clnDescricao, clnPreco });
            dgvTipoPagamento.Location = new Point(189, 284);
            dgvTipoPagamento.Name = "dgvTipoPagamento";
            dgvTipoPagamento.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTipoPagamento.RowHeadersVisible = false;
            dgvTipoPagamento.Size = new Size(422, 150);
            dgvTipoPagamento.TabIndex = 7;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 140;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 140;
            // 
            // clnPreco
            // 
            clnPreco.Frozen = true;
            clnPreco.HeaderText = "Preço";
            clnPreco.Name = "clnPreco";
            clnPreco.ReadOnly = true;
            clnPreco.Width = 140;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(229, 9);
            label3.Name = "label3";
            label3.Size = new Size(327, 36);
            label3.TabIndex = 6;
            label3.Text = "TIPO DE PAGAMENTO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnObterPorId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSigla);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Location = new Point(189, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 222);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados de inserção";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(6, 68);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 1;
            label1.Text = "Sigla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(6, 115);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(130, 115);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(100, 23);
            txtDescricao.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(130, 18);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(55, 23);
            txtId.TabIndex = 0;
            // 
            // btnObterPorId
            // 
            btnObterPorId.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnObterPorId.ForeColor = Color.ForestGreen;
            btnObterPorId.Location = new Point(315, 185);
            btnObterPorId.Name = "btnObterPorId";
            btnObterPorId.Size = new Size(79, 31);
            btnObterPorId.TabIndex = 2;
            btnObterPorId.Text = "&Consultar";
            btnObterPorId.UseVisualStyleBackColor = true;
            btnObterPorId.Click += btnObterPorId_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(6, 18);
            label4.Name = "label4";
            label4.Size = new Size(28, 23);
            label4.TabIndex = 1;
            label4.Text = "ID";
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(130, 68);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(284, 23);
            txtSigla.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.ForestGreen;
            btnEditar.Location = new Point(179, 185);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(81, 31);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnInserir.ForeColor = Color.ForestGreen;
            btnInserir.Location = new Point(28, 185);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(84, 31);
            btnInserir.TabIndex = 2;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // FrmTipoPag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTipoPagamento);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "FrmTipoPag";
            Text = "TipoPag";
            Load += FrmTipoPag_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTipoPagamento).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTipoPagamento;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnPreco;
        private Label label3;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtDescricao;
        private TextBox txtId;
        private Button btnObterPorId;
        private Label label4;
        private TextBox txtSigla;
        private Button btnEditar;
        private Button btnInserir;
    }
}