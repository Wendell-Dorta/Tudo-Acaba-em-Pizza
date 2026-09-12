namespace TudoAcabaEmPizza
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            gbProdutos = new GroupBox();
            cbDestaque = new CheckBox();
            btnAddFoto = new Button();
            pb_foto = new PictureBox();
            cbmCategoria = new ComboBox();
            mskCodigo = new MaskedTextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            txtValor = new TextBox();
            txtDescricao = new TextBox();
            txtRotulo = new TextBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnInserir = new Button();
            label1 = new Label();
            txtId = new TextBox();
            dgvProdutos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValor = new DataGridViewTextBoxColumn();
            clncodBar = new DataGridViewTextBoxColumn();
            clnImage = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            label9 = new Label();
            openFileDialog1 = new OpenFileDialog();
            gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_foto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // gbProdutos
            // 
            gbProdutos.Controls.Add(cbDestaque);
            gbProdutos.Controls.Add(btnAddFoto);
            gbProdutos.Controls.Add(pb_foto);
            gbProdutos.Controls.Add(cbmCategoria);
            gbProdutos.Controls.Add(mskCodigo);
            gbProdutos.Controls.Add(label7);
            gbProdutos.Controls.Add(label5);
            gbProdutos.Controls.Add(label4);
            gbProdutos.Controls.Add(label3);
            gbProdutos.Controls.Add(label6);
            gbProdutos.Controls.Add(txtValor);
            gbProdutos.Controls.Add(txtDescricao);
            gbProdutos.Controls.Add(txtRotulo);
            gbProdutos.Controls.Add(btnConsultar);
            gbProdutos.Controls.Add(btnEditar);
            gbProdutos.Controls.Add(btnInserir);
            gbProdutos.Controls.Add(label1);
            gbProdutos.Controls.Add(txtId);
            gbProdutos.ForeColor = Color.ForestGreen;
            gbProdutos.Location = new Point(190, 64);
            gbProdutos.Name = "gbProdutos";
            gbProdutos.Size = new Size(539, 361);
            gbProdutos.TabIndex = 16;
            gbProdutos.TabStop = false;
            gbProdutos.Text = "Dados de inserção";
            // 
            // cbDestaque
            // 
            cbDestaque.AutoSize = true;
            cbDestaque.Location = new Point(131, 249);
            cbDestaque.Name = "cbDestaque";
            cbDestaque.Size = new Size(75, 19);
            cbDestaque.TabIndex = 24;
            cbDestaque.Text = "Destaque";
            cbDestaque.UseVisualStyleBackColor = true;
            // 
            // btnAddFoto
            // 
            btnAddFoto.Location = new Point(390, 83);
            btnAddFoto.Name = "btnAddFoto";
            btnAddFoto.Size = new Size(132, 23);
            btnAddFoto.TabIndex = 23;
            btnAddFoto.Text = "Adicione  Foto";
            btnAddFoto.UseVisualStyleBackColor = true;
            btnAddFoto.Click += btnAddFoto_Click;
            // 
            // pb_foto
            // 
            pb_foto.BorderStyle = BorderStyle.FixedSingle;
            pb_foto.Location = new Point(390, 112);
            pb_foto.Name = "pb_foto";
            pb_foto.Size = new Size(132, 171);
            pb_foto.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_foto.TabIndex = 22;
            pb_foto.TabStop = false;
            // 
            // cbmCategoria
            // 
            cbmCategoria.FormattingEnabled = true;
            cbmCategoria.Location = new Point(131, 220);
            cbmCategoria.Name = "cbmCategoria";
            cbmCategoria.Size = new Size(211, 23);
            cbmCategoria.TabIndex = 21;
            // 
            // mskCodigo
            // 
            mskCodigo.Location = new Point(131, 191);
            mskCodigo.Mask = "0.000000.000000";
            mskCodigo.Name = "mskCodigo";
            mskCodigo.Size = new Size(211, 23);
            mskCodigo.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(57, 223);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 19;
            label7.Text = "* Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(31, 199);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 19;
            label5.Text = "Codigo de barras";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(84, 170);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 19;
            label4.Text = "* Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(61, 136);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 19;
            label3.Text = " *Descrição";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(77, 107);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 19;
            label6.Text = "* Rotulo";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(131, 162);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Obrigatório";
            txtValor.Size = new Size(211, 23);
            txtValor.TabIndex = 18;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(131, 133);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Obrigatório";
            txtDescricao.Size = new Size(211, 23);
            txtDescricao.TabIndex = 18;
            // 
            // txtRotulo
            // 
            txtRotulo.Location = new Point(131, 104);
            txtRotulo.Name = "txtRotulo";
            txtRotulo.PlaceholderText = "Obrigatório";
            txtRotulo.Size = new Size(211, 23);
            txtRotulo.TabIndex = 18;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.ForestGreen;
            btnConsultar.ForeColor = SystemColors.HighlightText;
            btnConsultar.Location = new Point(402, 326);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(79, 30);
            btnConsultar.TabIndex = 17;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.ForestGreen;
            btnEditar.ForeColor = SystemColors.HighlightText;
            btnEditar.Location = new Point(237, 326);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(79, 30);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.ForestGreen;
            btnInserir.ForeColor = SystemColors.ControlLightLight;
            btnInserir.Location = new Point(53, 326);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(79, 30);
            btnInserir.TabIndex = 15;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(107, 74);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(131, 74);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(55, 23);
            txtId.TabIndex = 1;
            // 
            // dgvProdutos
            // 
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { Id, clnNome, clnDescricao, clnValor, clncodBar, clnImage, clnCategoria });
            dgvProdutos.Location = new Point(26, 431);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(825, 150);
            dgvProdutos.TabIndex = 18;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 60;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.Width = 127;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 127;
            // 
            // clnValor
            // 
            clnValor.Frozen = true;
            clnValor.HeaderText = "Valor";
            clnValor.Name = "clnValor";
            clnValor.ReadOnly = true;
            clnValor.Width = 127;
            // 
            // clncodBar
            // 
            clncodBar.Frozen = true;
            clncodBar.HeaderText = "Codigo de Barras";
            clncodBar.Name = "clncodBar";
            clncodBar.ReadOnly = true;
            clncodBar.Width = 127;
            // 
            // clnImage
            // 
            clnImage.Frozen = true;
            clnImage.HeaderText = "Link imagem";
            clnImage.Name = "clnImage";
            clnImage.ReadOnly = true;
            clnImage.Width = 127;
            // 
            // clnCategoria
            // 
            clnCategoria.Frozen = true;
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            clnCategoria.Width = 127;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(350, 25);
            label9.Name = "label9";
            label9.Size = new Size(156, 36);
            label9.TabIndex = 19;
            label9.Text = "Produto";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = resources.GetString("openFileDialog1.Filter");
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(862, 613);
            Controls.Add(label9);
            Controls.Add(dgvProdutos);
            Controls.Add(gbProdutos);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            gbProdutos.ResumeLayout(false);
            gbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_foto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbProdutos;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnInserir;
        private Label label1;
        private TextBox txtId;
        private DataGridView dgvProdutos;
        private Label label9;
        private TextBox txtNome;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtValor;
        private TextBox txtDescricao;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValor;
        private DataGridViewTextBoxColumn clncodBar;
        private DataGridViewTextBoxColumn clnImage;
        private DataGridViewTextBoxColumn clnCategoria;
        private MaskedTextBox mskCodigo;
        private ComboBox cbmCategoria;
        private Button btnAddFoto;
        private PictureBox pb_foto;
        private OpenFileDialog openFileDialog1;
        private Label label6;
        private TextBox txtRotulo;
        private CheckBox cbDestaque;
        private TextBox textBox1;
    }
}