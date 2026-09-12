namespace TudoAcabaEmPizza
{
    partial class FrmCliente
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
            label1 = new Label();
            grbCliente = new GroupBox();
            tabControl1 = new TabControl();
            tdpUsuario = new TabPage();
            txtIdBackUser = new TextBox();
            txtSenhaBack = new TextBox();
            txtNivelId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtClienteId = new TextBox();
            dtpDatanasc = new DateTimePicker();
            mskCpf = new MaskedTextBox();
            txtIdUsuario = new TextBox();
            txtEmailUsuario = new TextBox();
            txtNomeUsuario = new TextBox();
            txtIdUser = new TextBox();
            btnObterUsuarioPorId = new Button();
            btnEditarUsuario = new Button();
            btnInserirUsuario = new Button();
            label7 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            txtSenhaUsuario = new TextBox();
            tbpEnderecosCliente = new TabPage();
            txtEnderecoId = new TextBox();
            dgvEnderecos = new DataGridView();
            IdEndereco = new DataGridViewTextBoxColumn();
            clnCep = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnNumeroCasa = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnUf = new DataGridViewTextBoxColumn();
            clnTipoEnd = new DataGridViewTextBoxColumn();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtNumero = new TextBox();
            txtComplemento = new TextBox();
            txtLogradouro = new TextBox();
            mskCep = new MaskedTextBox();
            label16 = new Label();
            btnEditarEndereco = new Button();
            btnSalvarEndereco = new Button();
            mskUf = new MaskedTextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            cmbTipoEndereco = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label2 = new Label();
            tbpTelefonesCliente = new TabPage();
            txtTelefoneId = new TextBox();
            dgvTelefones = new DataGridView();
            IdTelefone = new DataGridViewTextBoxColumn();
            clnDdi = new DataGridViewTextBoxColumn();
            clnDdd = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnTipoTelefone = new DataGridViewTextBoxColumn();
            btnEditarTelefone = new Button();
            btnInserirTelefone = new Button();
            label21 = new Label();
            cmbTipoTelefone = new ComboBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            mskNumeroTelefone = new MaskedTextBox();
            mskDdd = new MaskedTextBox();
            mskDdi = new MaskedTextBox();
            label17 = new Label();
            txtConfSenha = new TextBox();
            label3 = new Label();
            grbCliente.SuspendLayout();
            tabControl1.SuspendLayout();
            tdpUsuario.SuspendLayout();
            tbpEnderecosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            tbpTelefonesCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTelefones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(287, 23);
            label1.Name = "label1";
            label1.Size = new Size(172, 29);
            label1.TabIndex = 0;
            label1.Text = "Dados Cliente";
            // 
            // grbCliente
            // 
            grbCliente.Controls.Add(tabControl1);
            grbCliente.Location = new Point(20, 57);
            grbCliente.Name = "grbCliente";
            grbCliente.Size = new Size(768, 575);
            grbCliente.TabIndex = 1;
            grbCliente.TabStop = false;
            grbCliente.Text = "Dados de Inserção";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tdpUsuario);
            tabControl1.Controls.Add(tbpEnderecosCliente);
            tabControl1.Controls.Add(tbpTelefonesCliente);
            tabControl1.Location = new Point(3, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(756, 547);
            tabControl1.TabIndex = 0;
            // 
            // tdpUsuario
            // 
            tdpUsuario.Controls.Add(txtIdBackUser);
            tdpUsuario.Controls.Add(txtSenhaBack);
            tdpUsuario.Controls.Add(txtNivelId);
            tdpUsuario.Controls.Add(label5);
            tdpUsuario.Controls.Add(label4);
            tdpUsuario.Controls.Add(txtClienteId);
            tdpUsuario.Controls.Add(dtpDatanasc);
            tdpUsuario.Controls.Add(mskCpf);
            tdpUsuario.Controls.Add(txtIdUsuario);
            tdpUsuario.Controls.Add(txtEmailUsuario);
            tdpUsuario.Controls.Add(txtNomeUsuario);
            tdpUsuario.Controls.Add(txtIdUser);
            tdpUsuario.Controls.Add(btnObterUsuarioPorId);
            tdpUsuario.Controls.Add(btnEditarUsuario);
            tdpUsuario.Controls.Add(btnInserirUsuario);
            tdpUsuario.Controls.Add(label3);
            tdpUsuario.Controls.Add(label7);
            tdpUsuario.Controls.Add(label24);
            tdpUsuario.Controls.Add(label25);
            tdpUsuario.Controls.Add(label26);
            tdpUsuario.Controls.Add(label27);
            tdpUsuario.Controls.Add(txtConfSenha);
            tdpUsuario.Controls.Add(txtSenhaUsuario);
            tdpUsuario.Location = new Point(4, 24);
            tdpUsuario.Name = "tdpUsuario";
            tdpUsuario.Padding = new Padding(3);
            tdpUsuario.Size = new Size(748, 519);
            tdpUsuario.TabIndex = 3;
            tdpUsuario.Text = "Dados Cliente";
            tdpUsuario.UseVisualStyleBackColor = true;
            // 
            // txtIdBackUser
            // 
            txtIdBackUser.Location = new Point(536, 6);
            txtIdBackUser.Name = "txtIdBackUser";
            txtIdBackUser.ReadOnly = true;
            txtIdBackUser.Size = new Size(100, 23);
            txtIdBackUser.TabIndex = 49;
            txtIdBackUser.Visible = false;
            // 
            // txtSenhaBack
            // 
            txtSenhaBack.Location = new Point(642, 93);
            txtSenhaBack.Name = "txtSenhaBack";
            txtSenhaBack.ReadOnly = true;
            txtSenhaBack.Size = new Size(100, 23);
            txtSenhaBack.TabIndex = 48;
            txtSenhaBack.Visible = false;
            // 
            // txtNivelId
            // 
            txtNivelId.Location = new Point(642, 64);
            txtNivelId.Name = "txtNivelId";
            txtNivelId.ReadOnly = true;
            txtNivelId.Size = new Size(100, 23);
            txtNivelId.TabIndex = 47;
            txtNivelId.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.ForestGreen;
            label5.Location = new Point(110, 289);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 44;
            label5.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(36, 253);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 45;
            label4.Text = "Data Nascimento";
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(642, 35);
            txtClienteId.Multiline = true;
            txtClienteId.Name = "txtClienteId";
            txtClienteId.ReadOnly = true;
            txtClienteId.Size = new Size(100, 23);
            txtClienteId.TabIndex = 41;
            txtClienteId.Visible = false;
            // 
            // dtpDatanasc
            // 
            dtpDatanasc.Format = DateTimePickerFormat.Short;
            dtpDatanasc.Location = new Point(157, 249);
            dtpDatanasc.Name = "dtpDatanasc";
            dtpDatanasc.Size = new Size(119, 23);
            dtpDatanasc.TabIndex = 43;
            dtpDatanasc.UseWaitCursor = true;
            dtpDatanasc.Value = new DateTime(2024, 8, 23, 9, 38, 30, 0);
            // 
            // mskCpf
            // 
            mskCpf.Location = new Point(157, 285);
            mskCpf.Mask = "000.000.000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(119, 23);
            mskCpf.TabIndex = 42;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(642, 6);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.ReadOnly = true;
            txtIdUsuario.Size = new Size(100, 23);
            txtIdUsuario.TabIndex = 39;
            txtIdUsuario.Visible = false;
            // 
            // txtEmailUsuario
            // 
            txtEmailUsuario.Location = new Point(157, 142);
            txtEmailUsuario.Name = "txtEmailUsuario";
            txtEmailUsuario.Size = new Size(250, 23);
            txtEmailUsuario.TabIndex = 26;
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Location = new Point(157, 106);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(250, 23);
            txtNomeUsuario.TabIndex = 27;
            // 
            // txtIdUser
            // 
            txtIdUser.Location = new Point(157, 70);
            txtIdUser.Name = "txtIdUser";
            txtIdUser.ReadOnly = true;
            txtIdUser.Size = new Size(51, 23);
            txtIdUser.TabIndex = 28;
            // 
            // btnObterUsuarioPorId
            // 
            btnObterUsuarioPorId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnObterUsuarioPorId.Location = new Point(600, 285);
            btnObterUsuarioPorId.Name = "btnObterUsuarioPorId";
            btnObterUsuarioPorId.Size = new Size(127, 32);
            btnObterUsuarioPorId.TabIndex = 36;
            btnObterUsuarioPorId.Text = "&Consultar";
            btnObterUsuarioPorId.UseVisualStyleBackColor = true;
            btnObterUsuarioPorId.Click += btnObterUsuarioPorId_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarUsuario.ForeColor = SystemColors.ActiveCaptionText;
            btnEditarUsuario.Location = new Point(600, 243);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(127, 32);
            btnEditarUsuario.TabIndex = 37;
            btnEditarUsuario.Text = "&Editar";
            btnEditarUsuario.UseVisualStyleBackColor = true;
            btnEditarUsuario.Click += btnEditarUsuario_Click_1;
            // 
            // btnInserirUsuario
            // 
            btnInserirUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserirUsuario.Location = new Point(600, 201);
            btnInserirUsuario.Name = "btnInserirUsuario";
            btnInserirUsuario.Size = new Size(127, 32);
            btnInserirUsuario.TabIndex = 38;
            btnInserirUsuario.Text = "&Inserir";
            btnInserirUsuario.UseVisualStyleBackColor = true;
            btnInserirUsuario.Click += btnInserirUsuario_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.ForestGreen;
            label7.Location = new Point(97, 182);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 31;
            label7.Text = "Senha";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.ForestGreen;
            label24.Location = new Point(102, 146);
            label24.Name = "label24";
            label24.Size = new Size(36, 15);
            label24.TabIndex = 32;
            label24.Text = "Email";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.ForestGreen;
            label25.Location = new Point(97, 110);
            label25.Name = "label25";
            label25.Size = new Size(41, 15);
            label25.TabIndex = 33;
            label25.Text = "Nome";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.ForestGreen;
            label26.Location = new Point(157, 15);
            label26.Name = "label26";
            label26.Size = new Size(163, 25);
            label26.TabIndex = 34;
            label26.Text = "INSERIR CLIENTE";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.ForestGreen;
            label27.Location = new Point(118, 74);
            label27.Name = "label27";
            label27.Size = new Size(20, 15);
            label27.TabIndex = 35;
            label27.Text = "ID";
            // 
            // txtSenhaUsuario
            // 
            txtSenhaUsuario.Location = new Point(157, 178);
            txtSenhaUsuario.Name = "txtSenhaUsuario";
            txtSenhaUsuario.Size = new Size(250, 23);
            txtSenhaUsuario.TabIndex = 25;
            txtSenhaUsuario.UseSystemPasswordChar = true;
            // 
            // tbpEnderecosCliente
            // 
            tbpEnderecosCliente.Controls.Add(txtEnderecoId);
            tbpEnderecosCliente.Controls.Add(dgvEnderecos);
            tbpEnderecosCliente.Controls.Add(txtCidade);
            tbpEnderecosCliente.Controls.Add(txtBairro);
            tbpEnderecosCliente.Controls.Add(txtNumero);
            tbpEnderecosCliente.Controls.Add(txtComplemento);
            tbpEnderecosCliente.Controls.Add(txtLogradouro);
            tbpEnderecosCliente.Controls.Add(mskCep);
            tbpEnderecosCliente.Controls.Add(label16);
            tbpEnderecosCliente.Controls.Add(btnEditarEndereco);
            tbpEnderecosCliente.Controls.Add(btnSalvarEndereco);
            tbpEnderecosCliente.Controls.Add(mskUf);
            tbpEnderecosCliente.Controls.Add(label15);
            tbpEnderecosCliente.Controls.Add(label14);
            tbpEnderecosCliente.Controls.Add(label13);
            tbpEnderecosCliente.Controls.Add(cmbTipoEndereco);
            tbpEnderecosCliente.Controls.Add(label11);
            tbpEnderecosCliente.Controls.Add(label10);
            tbpEnderecosCliente.Controls.Add(label9);
            tbpEnderecosCliente.Controls.Add(label8);
            tbpEnderecosCliente.Controls.Add(label2);
            tbpEnderecosCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tbpEnderecosCliente.ForeColor = Color.ForestGreen;
            tbpEnderecosCliente.Location = new Point(4, 24);
            tbpEnderecosCliente.Name = "tbpEnderecosCliente";
            tbpEnderecosCliente.Padding = new Padding(3);
            tbpEnderecosCliente.Size = new Size(748, 519);
            tbpEnderecosCliente.TabIndex = 1;
            tbpEnderecosCliente.Text = "Endereços Cliente";
            tbpEnderecosCliente.UseVisualStyleBackColor = true;
            // 
            // txtEnderecoId
            // 
            txtEnderecoId.Location = new Point(115, 57);
            txtEnderecoId.Name = "txtEnderecoId";
            txtEnderecoId.ReadOnly = true;
            txtEnderecoId.Size = new Size(100, 23);
            txtEnderecoId.TabIndex = 38;
            txtEnderecoId.Visible = false;
            // 
            // dgvEnderecos
            // 
            dgvEnderecos.AllowUserToOrderColumns = true;
            dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnderecos.Columns.AddRange(new DataGridViewColumn[] { IdEndereco, clnCep, clnLogradouro, clnNumeroCasa, clnComplemento, clnBairro, clnCidade, clnUf, clnTipoEnd });
            dgvEnderecos.Location = new Point(-1, 324);
            dgvEnderecos.Name = "dgvEnderecos";
            dgvEnderecos.RowHeadersVisible = false;
            dgvEnderecos.ScrollBars = ScrollBars.Horizontal;
            dgvEnderecos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEnderecos.Size = new Size(749, 195);
            dgvEnderecos.TabIndex = 35;
            dgvEnderecos.CellClick += dgvEnderecos_CellClick;
            // 
            // IdEndereco
            // 
            IdEndereco.Frozen = true;
            IdEndereco.HeaderText = "Id";
            IdEndereco.Name = "IdEndereco";
            IdEndereco.Visible = false;
            // 
            // clnCep
            // 
            clnCep.HeaderText = "CEP";
            clnCep.Name = "clnCep";
            clnCep.ReadOnly = true;
            clnCep.Width = 70;
            // 
            // clnLogradouro
            // 
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            clnLogradouro.Width = 160;
            // 
            // clnNumeroCasa
            // 
            clnNumeroCasa.HeaderText = "N°";
            clnNumeroCasa.Name = "clnNumeroCasa";
            clnNumeroCasa.ReadOnly = true;
            clnNumeroCasa.Width = 35;
            // 
            // clnComplemento
            // 
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            // 
            // clnBairro
            // 
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            clnBairro.Width = 111;
            // 
            // clnCidade
            // 
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            clnCidade.Width = 90;
            // 
            // clnUf
            // 
            clnUf.HeaderText = "UF";
            clnUf.Name = "clnUf";
            clnUf.ReadOnly = true;
            clnUf.Width = 35;
            // 
            // clnTipoEnd
            // 
            clnTipoEnd.HeaderText = "Tipo End";
            clnTipoEnd.Name = "clnTipoEnd";
            clnTipoEnd.ReadOnly = true;
            clnTipoEnd.Width = 150;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(115, 176);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(214, 23);
            txtCidade.TabIndex = 24;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(115, 206);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(214, 23);
            txtBairro.TabIndex = 23;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(115, 266);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(93, 23);
            txtNumero.TabIndex = 6;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(115, 146);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(214, 23);
            txtComplemento.TabIndex = 5;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(115, 116);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(214, 23);
            txtLogradouro.TabIndex = 3;
            // 
            // mskCep
            // 
            mskCep.Location = new Point(115, 86);
            mskCep.Mask = "00000-000";
            mskCep.Name = "mskCep";
            mskCep.Size = new Size(121, 23);
            mskCep.TabIndex = 34;
            mskCep.TextChanged += mskCep_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.ForestGreen;
            label16.Location = new Point(126, 17);
            label16.Name = "label16";
            label16.Size = new Size(519, 37);
            label16.TabIndex = 33;
            label16.Text = "cadastro de endereços do cliente";
            // 
            // btnEditarEndereco
            // 
            btnEditarEndereco.Location = new Point(615, 286);
            btnEditarEndereco.Name = "btnEditarEndereco";
            btnEditarEndereco.Size = new Size(127, 32);
            btnEditarEndereco.TabIndex = 31;
            btnEditarEndereco.Text = "&Editar";
            btnEditarEndereco.UseVisualStyleBackColor = true;
            // 
            // btnSalvarEndereco
            // 
            btnSalvarEndereco.Location = new Point(615, 238);
            btnSalvarEndereco.Name = "btnSalvarEndereco";
            btnSalvarEndereco.Size = new Size(127, 32);
            btnSalvarEndereco.TabIndex = 32;
            btnSalvarEndereco.Text = "&Salvar";
            btnSalvarEndereco.UseVisualStyleBackColor = true;
            btnSalvarEndereco.Click += buSalvar_Click;
            // 
            // mskUf
            // 
            mskUf.Location = new Point(280, 266);
            mskUf.Mask = "aa";
            mskUf.Name = "mskUf";
            mskUf.Size = new Size(49, 23);
            mskUf.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.ForeColor = Color.ForestGreen;
            label15.Location = new Point(241, 270);
            label15.Name = "label15";
            label15.Size = new Size(22, 15);
            label15.TabIndex = 28;
            label15.Text = "UF";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.ForeColor = Color.ForestGreen;
            label14.Location = new Point(65, 182);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 27;
            label14.Text = "Cidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.ForestGreen;
            label13.Location = new Point(68, 213);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 26;
            label13.Text = "Bairro";
            // 
            // cmbTipoEndereco
            // 
            cmbTipoEndereco.FormattingEnabled = true;
            cmbTipoEndereco.Location = new Point(115, 236);
            cmbTipoEndereco.Name = "cmbTipoEndereco";
            cmbTipoEndereco.Size = new Size(214, 23);
            cmbTipoEndereco.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.ForeColor = Color.ForestGreen;
            label11.Location = new Point(25, 151);
            label11.Name = "label11";
            label11.Size = new Size(86, 15);
            label11.TabIndex = 11;
            label11.Text = "Complemento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.ForestGreen;
            label10.Location = new Point(88, 270);
            label10.Name = "label10";
            label10.Size = new Size(21, 15);
            label10.TabIndex = 10;
            label10.Text = "N°";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(23, 244);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 9;
            label9.Text = "Tipo Endereço";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.ForestGreen;
            label8.Location = new Point(38, 120);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 8;
            label8.Text = "Logradouro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(82, 89);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 7;
            label2.Text = "CEP";
            // 
            // tbpTelefonesCliente
            // 
            tbpTelefonesCliente.Controls.Add(txtTelefoneId);
            tbpTelefonesCliente.Controls.Add(dgvTelefones);
            tbpTelefonesCliente.Controls.Add(btnEditarTelefone);
            tbpTelefonesCliente.Controls.Add(btnInserirTelefone);
            tbpTelefonesCliente.Controls.Add(label21);
            tbpTelefonesCliente.Controls.Add(cmbTipoTelefone);
            tbpTelefonesCliente.Controls.Add(label20);
            tbpTelefonesCliente.Controls.Add(label19);
            tbpTelefonesCliente.Controls.Add(label18);
            tbpTelefonesCliente.Controls.Add(mskNumeroTelefone);
            tbpTelefonesCliente.Controls.Add(mskDdd);
            tbpTelefonesCliente.Controls.Add(mskDdi);
            tbpTelefonesCliente.Controls.Add(label17);
            tbpTelefonesCliente.Location = new Point(4, 24);
            tbpTelefonesCliente.Name = "tbpTelefonesCliente";
            tbpTelefonesCliente.Padding = new Padding(3);
            tbpTelefonesCliente.Size = new Size(748, 519);
            tbpTelefonesCliente.TabIndex = 2;
            tbpTelefonesCliente.Text = "Telefones Cliente";
            tbpTelefonesCliente.UseVisualStyleBackColor = true;
            // 
            // txtTelefoneId
            // 
            txtTelefoneId.Location = new Point(269, 94);
            txtTelefoneId.Name = "txtTelefoneId";
            txtTelefoneId.ReadOnly = true;
            txtTelefoneId.Size = new Size(100, 23);
            txtTelefoneId.TabIndex = 37;
            txtTelefoneId.Visible = false;
            // 
            // dgvTelefones
            // 
            dgvTelefones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTelefones.Columns.AddRange(new DataGridViewColumn[] { IdTelefone, clnDdi, clnDdd, clnTelefone, clnTipoTelefone });
            dgvTelefones.Location = new Point(-1, 328);
            dgvTelefones.Name = "dgvTelefones";
            dgvTelefones.RowHeadersVisible = false;
            dgvTelefones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTelefones.Size = new Size(749, 191);
            dgvTelefones.TabIndex = 36;
            dgvTelefones.CellClick += dgvTelefones_CellClick;
            // 
            // IdTelefone
            // 
            IdTelefone.HeaderText = "Id";
            IdTelefone.Name = "IdTelefone";
            IdTelefone.Visible = false;
            // 
            // clnDdi
            // 
            clnDdi.HeaderText = "DDI";
            clnDdi.Name = "clnDdi";
            clnDdi.Width = 147;
            // 
            // clnDdd
            // 
            clnDdd.HeaderText = "DDD";
            clnDdd.Name = "clnDdd";
            clnDdd.Width = 149;
            // 
            // clnTelefone
            // 
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.Width = 300;
            // 
            // clnTipoTelefone
            // 
            clnTipoTelefone.HeaderText = "Tipo de Telefone";
            clnTipoTelefone.Name = "clnTipoTelefone";
            clnTipoTelefone.Width = 150;
            // 
            // btnEditarTelefone
            // 
            btnEditarTelefone.Location = new Point(615, 290);
            btnEditarTelefone.Name = "btnEditarTelefone";
            btnEditarTelefone.Size = new Size(127, 32);
            btnEditarTelefone.TabIndex = 32;
            btnEditarTelefone.Text = "&Editar";
            btnEditarTelefone.UseVisualStyleBackColor = true;
            // 
            // btnInserirTelefone
            // 
            btnInserirTelefone.Location = new Point(615, 252);
            btnInserirTelefone.Name = "btnInserirTelefone";
            btnInserirTelefone.Size = new Size(127, 32);
            btnInserirTelefone.TabIndex = 33;
            btnInserirTelefone.Text = "&Inserir";
            btnInserirTelefone.UseVisualStyleBackColor = true;
            btnInserirTelefone.Click += btnInserirTelefone_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label21.ForeColor = Color.ForestGreen;
            label21.Location = new Point(147, 214);
            label21.Name = "label21";
            label21.Size = new Size(100, 15);
            label21.TabIndex = 28;
            label21.Text = "Tipo de Telefone";
            // 
            // cmbTipoTelefone
            // 
            cmbTipoTelefone.FormattingEnabled = true;
            cmbTipoTelefone.Location = new Point(269, 210);
            cmbTipoTelefone.Name = "cmbTipoTelefone";
            cmbTipoTelefone.Size = new Size(211, 23);
            cmbTipoTelefone.TabIndex = 27;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label20.ForeColor = Color.ForestGreen;
            label20.Location = new Point(183, 185);
            label20.Name = "label20";
            label20.Size = new Size(59, 15);
            label20.TabIndex = 26;
            label20.Text = "NÙMERO";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label19.ForeColor = Color.ForestGreen;
            label19.Location = new Point(209, 156);
            label19.Name = "label19";
            label19.Size = new Size(34, 15);
            label19.TabIndex = 25;
            label19.Text = "DDD";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label18.ForeColor = Color.ForestGreen;
            label18.Location = new Point(214, 127);
            label18.Name = "label18";
            label18.Size = new Size(29, 15);
            label18.TabIndex = 24;
            label18.Text = "DDI";
            // 
            // mskNumeroTelefone
            // 
            mskNumeroTelefone.Location = new Point(269, 181);
            mskNumeroTelefone.Mask = "00000-0000";
            mskNumeroTelefone.Name = "mskNumeroTelefone";
            mskNumeroTelefone.Size = new Size(211, 23);
            mskNumeroTelefone.TabIndex = 23;
            // 
            // mskDdd
            // 
            mskDdd.Location = new Point(269, 152);
            mskDdd.Mask = "(00)";
            mskDdd.Name = "mskDdd";
            mskDdd.Size = new Size(211, 23);
            mskDdd.TabIndex = 22;
            // 
            // mskDdi
            // 
            mskDdi.Location = new Point(269, 123);
            mskDdi.Mask = "+00";
            mskDdi.Name = "mskDdi";
            mskDdi.Size = new Size(211, 23);
            mskDdi.TabIndex = 21;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.ForestGreen;
            label17.Location = new Point(82, 28);
            label17.Name = "label17";
            label17.Size = new Size(524, 37);
            label17.TabIndex = 13;
            label17.Text = "Cadastro de Telefones do Cliente";
            // 
            // txtConfSenha
            // 
            txtConfSenha.Location = new Point(157, 210);
            txtConfSenha.Name = "txtConfSenha";
            txtConfSenha.Size = new Size(250, 23);
            txtConfSenha.TabIndex = 25;
            txtConfSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(97, 214);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 31;
            label3.Text = "Senha";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 677);
            Controls.Add(grbCliente);
            Controls.Add(label1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            grbCliente.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tdpUsuario.ResumeLayout(false);
            tdpUsuario.PerformLayout();
            tbpEnderecosCliente.ResumeLayout(false);
            tbpEnderecosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
            tbpTelefonesCliente.ResumeLayout(false);
            tbpTelefonesCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTelefones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grbCliente;
        private ComboBox cbmCategoria;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private DataGridView dgvEnderecos;
        private TextBox txtUsuarioId;
        private TabControl tabControl1;
        private TabPage tdpUsuario;
        private Label label5;
        private Label label4;
        private TextBox txtClienteId;
        private DateTimePicker dtpDatanasc;
        private MaskedTextBox mskCpf;
        private TextBox txtIdUsuario;
        private TextBox txtEmailUsuario;
        private TextBox txtNomeUsuario;
        private TextBox txtIdUser;
        private Label label7;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private TextBox txtSenhaUsuario;
        private TabPage tbpEnderecosCliente;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private TextBox txtLogradouro;
        private MaskedTextBox mskCep;
        private Label label16;
        private Button btnEditarEndereco;
        private Button btnSalvarEndereco;
        private MaskedTextBox mskUf;
        private Label label15;
        private Label label14;
        private Label label13;
        private ComboBox cmbTipoEndereco;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label2;
        private TabPage tbpTelefonesCliente;
        private Button btnEditarTelefone;
        private Button btnInserirTelefone;
        private Label label21;
        private ComboBox cmbTipoTelefone;
        private Label label20;
        private Label label19;
        private Label label18;
        private MaskedTextBox mskNumeroTelefone;
        private MaskedTextBox mskDdd;
        private MaskedTextBox mskDdi;
        private Label label17;
        private TextBox txtNivelId;
        private Button btnObterUsuarioPorId;
        private Button btnEditarUsuario;
        private Button btnInserirUsuario;
        private DataGridView dgvTelefones;
        private TextBox txtEnderecoId;
        private TextBox txtTelefoneId;
        private DataGridViewTextBoxColumn IdEndereco;
        private DataGridViewTextBoxColumn clnCep;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumeroCasa;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnUf;
        private DataGridViewTextBoxColumn clnTipoEnd;
        private DataGridViewTextBoxColumn IdTelefone;
        private DataGridViewTextBoxColumn clnDdi;
        private DataGridViewTextBoxColumn clnDdd;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnTipoTelefone;
        private TextBox txtSenhaBack;
        private TextBox txtIdBackUser;
        private Label label3;
        private TextBox txtConfSenha;
    }
}