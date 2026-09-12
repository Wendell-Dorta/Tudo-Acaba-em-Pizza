namespace TudoAcabaEmPizza
{
    partial class FrmCategoria
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
            txtSigla = new TextBox();
            btnInserir = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnObterPorId = new Button();
            btnEditar = new Button();
            txtId = new TextBox();
            txtNome = new TextBox();
            dgvCategoria = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnSigla = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(62, 121);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(117, 23);
            txtSigla.TabIndex = 0;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(18, 177);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 32);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(299, 23);
            label1.Name = "label1";
            label1.Size = new Size(185, 36);
            label1.TabIndex = 2;
            label1.Text = "CATEGORIA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnObterPorId);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtSigla);
            groupBox1.Location = new Point(217, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 215);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados para inserir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(6, 124);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Sigla";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(18, 32);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 2;
            label4.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // btnObterPorId
            // 
            btnObterPorId.Location = new Point(233, 177);
            btnObterPorId.Name = "btnObterPorId";
            btnObterPorId.Size = new Size(75, 32);
            btnObterPorId.TabIndex = 1;
            btnObterPorId.Text = "&Consultar";
            btnObterPorId.UseVisualStyleBackColor = true;
            btnObterPorId.Click += btnObterPorId_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(121, 177);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 32);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(62, 32);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(81, 23);
            txtId.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(62, 69);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(214, 23);
            txtNome.TabIndex = 0;
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnSigla });
            dgvCategoria.Location = new Point(217, 297);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.RowHeadersVisible = false;
            dgvCategoria.Size = new Size(369, 150);
            dgvCategoria.TabIndex = 4;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 123;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 123;
            // 
            // clnSigla
            // 
            clnSigla.Frozen = true;
            clnSigla.HeaderText = "Sigla";
            clnSigla.Name = "clnSigla";
            clnSigla.ReadOnly = true;
            clnSigla.Width = 123;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(dgvCategoria);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            Load += FrmCategoria_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSigla;
        private Button btnInserir;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private DataGridView dgvCategoria;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNome;
        private Button btnObterPorId;
        private Button btnEditar;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnSigla;
    }
}