namespace TudoAcabaEmPizza
{
    partial class FrmPedido
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
            label4 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            gbTipoBorda = new GroupBox();
            btnInserirTipoBorda = new Button();
            txtValorTipoBorda = new TextBox();
            cmbTipoBorda = new ComboBox();
            gbAdicionais = new GroupBox();
            btnInserirAdicional = new Button();
            txtValorAdicional = new TextBox();
            cmbAdicionais = new ComboBox();
            cmbStatus = new ComboBox();
            label12 = new Label();
            label9 = new Label();
            label11 = new Label();
            cmbDesconto = new ComboBox();
            txtDesconto = new TextBox();
            txtTotalValor = new TextBox();
            btnFinalizarPedido = new Button();
            label5 = new Label();
            btnAbrirPedido = new Button();
            gbProduto = new GroupBox();
            txtDescricaoSaborDois = new TextBox();
            txtCodSaborDois = new TextBox();
            radioButtonMeia = new CheckBox();
            radioButtonPizza = new CheckBox();
            cmbTamanhoPizza = new ComboBox();
            btnInserirProduto = new Button();
            label8 = new Label();
            Quantidade = new Label();
            label7 = new Label();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            label17 = new Label();
            label6 = new Label();
            txtRotulo = new TextBox();
            label16 = new Label();
            label15 = new Label();
            txtCodProduto = new TextBox();
            gbCliente = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            txtClienteCPF = new TextBox();
            txtClienteId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtVendedor = new TextBox();
            txtNumeroItemPedido = new TextBox();
            txtNumeroPedido = new TextBox();
            gbBuscaProduto = new GroupBox();
            txtBuscaProduto = new TextBox();
            dgvProdutos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnDescricaoproduto = new DataGridViewTextBoxColumn();
            clnValorProduto = new DataGridViewTextBoxColumn();
            clnCodBarrasProduto = new DataGridViewTextBoxColumn();
            clnImagem = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            gbTipoBorda.SuspendLayout();
            gbAdicionais.SuspendLayout();
            gbProduto.SuspendLayout();
            gbCliente.SuspendLayout();
            gbBuscaProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 573);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(0, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(130, 33);
            label1.TabIndex = 0;
            label1.Text = "Pedido!";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gbTipoBorda);
            groupBox1.Controls.Add(gbAdicionais);
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cmbDesconto);
            groupBox1.Controls.Add(txtDesconto);
            groupBox1.Controls.Add(txtTotalValor);
            groupBox1.Controls.Add(btnFinalizarPedido);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnAbrirPedido);
            groupBox1.Controls.Add(gbProduto);
            groupBox1.Controls.Add(gbCliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtVendedor);
            groupBox1.Controls.Add(txtNumeroItemPedido);
            groupBox1.Controls.Add(txtNumeroPedido);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(gbBuscaProduto);
            groupBox1.ForeColor = Color.ForestGreen;
            groupBox1.Location = new Point(50, 1);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(1223, 738);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // gbTipoBorda
            // 
            gbTipoBorda.Controls.Add(btnInserirTipoBorda);
            gbTipoBorda.Controls.Add(txtValorTipoBorda);
            gbTipoBorda.Controls.Add(cmbTipoBorda);
            gbTipoBorda.Enabled = false;
            gbTipoBorda.Location = new Point(602, 557);
            gbTipoBorda.Name = "gbTipoBorda";
            gbTipoBorda.Size = new Size(570, 69);
            gbTipoBorda.TabIndex = 26;
            gbTipoBorda.TabStop = false;
            gbTipoBorda.Text = "Tipo de Borda";
            // 
            // btnInserirTipoBorda
            // 
            btnInserirTipoBorda.Location = new Point(463, 25);
            btnInserirTipoBorda.Name = "btnInserirTipoBorda";
            btnInserirTipoBorda.Size = new Size(87, 33);
            btnInserirTipoBorda.TabIndex = 2;
            btnInserirTipoBorda.Text = "&Inserir";
            btnInserirTipoBorda.UseVisualStyleBackColor = true;
            btnInserirTipoBorda.Click += btnInserirTipoBorda_Click;
            // 
            // txtValorTipoBorda
            // 
            txtValorTipoBorda.Location = new Point(260, 28);
            txtValorTipoBorda.Name = "txtValorTipoBorda";
            txtValorTipoBorda.Size = new Size(170, 29);
            txtValorTipoBorda.TabIndex = 1;
            txtValorTipoBorda.TextChanged += txtValorTipoBorda_TextChanged;
            // 
            // cmbTipoBorda
            // 
            cmbTipoBorda.FormattingEnabled = true;
            cmbTipoBorda.Location = new Point(0, 28);
            cmbTipoBorda.Name = "cmbTipoBorda";
            cmbTipoBorda.Size = new Size(200, 29);
            cmbTipoBorda.TabIndex = 0;
            cmbTipoBorda.SelectedIndexChanged += cmbTipoBorda_SelectedIndexChanged;
            // 
            // gbAdicionais
            // 
            gbAdicionais.Controls.Add(btnInserirAdicional);
            gbAdicionais.Controls.Add(txtValorAdicional);
            gbAdicionais.Controls.Add(cmbAdicionais);
            gbAdicionais.Enabled = false;
            gbAdicionais.Location = new Point(5, 557);
            gbAdicionais.Name = "gbAdicionais";
            gbAdicionais.Size = new Size(564, 69);
            gbAdicionais.TabIndex = 25;
            gbAdicionais.TabStop = false;
            gbAdicionais.Text = "Adicionais";
            // 
            // btnInserirAdicional
            // 
            btnInserirAdicional.Location = new Point(453, 28);
            btnInserirAdicional.Name = "btnInserirAdicional";
            btnInserirAdicional.Size = new Size(87, 33);
            btnInserirAdicional.TabIndex = 2;
            btnInserirAdicional.Text = "&Inserir";
            btnInserirAdicional.UseVisualStyleBackColor = true;
            btnInserirAdicional.Click += button1_Click_1;
            // 
            // txtValorAdicional
            // 
            txtValorAdicional.Location = new Point(248, 28);
            txtValorAdicional.Name = "txtValorAdicional";
            txtValorAdicional.Size = new Size(170, 29);
            txtValorAdicional.TabIndex = 1;
            txtValorAdicional.TextChanged += txtValorAdicional_TextChanged;
            // 
            // cmbAdicionais
            // 
            cmbAdicionais.FormattingEnabled = true;
            cmbAdicionais.Location = new Point(6, 28);
            cmbAdicionais.Name = "cmbAdicionais";
            cmbAdicionais.Size = new Size(200, 29);
            cmbAdicionais.TabIndex = 0;
            cmbAdicionais.SelectedIndexChanged += cmbAdicionais_SelectedIndexChanged;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(122, 632);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(160, 33);
            cmbStatus.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(899, 635);
            label12.Name = "label12";
            label12.Size = new Size(48, 21);
            label12.TabIndex = 18;
            label12.Text = "Total";
            label12.Click += label9_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(299, 640);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 18;
            label9.Text = "Tipo de Desconto";
            label9.Click += label9_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(648, 635);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 18;
            label11.Text = "Desconto";
            label11.Click += label9_Click;
            // 
            // cmbDesconto
            // 
            cmbDesconto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbDesconto.FormattingEnabled = true;
            cmbDesconto.Location = new Point(409, 632);
            cmbDesconto.Name = "cmbDesconto";
            cmbDesconto.Size = new Size(215, 33);
            cmbDesconto.TabIndex = 17;
            cmbDesconto.SelectedIndexChanged += cmbDesconto_SelectedIndexChanged;
            // 
            // txtDesconto
            // 
            txtDesconto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDesconto.Location = new Point(729, 632);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(151, 33);
            txtDesconto.TabIndex = 21;
            txtDesconto.TextChanged += txtDesconto_TextChanged;
            // 
            // txtTotalValor
            // 
            txtTotalValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalValor.Location = new Point(953, 633);
            txtTotalValor.Name = "txtTotalValor";
            txtTotalValor.Size = new Size(167, 33);
            txtTotalValor.TabIndex = 21;
            txtTotalValor.TextChanged += txtTotalValor_TextChanged;
            // 
            // btnFinalizarPedido
            // 
            btnFinalizarPedido.Location = new Point(577, 685);
            btnFinalizarPedido.Name = "btnFinalizarPedido";
            btnFinalizarPedido.Size = new Size(187, 43);
            btnFinalizarPedido.TabIndex = 19;
            btnFinalizarPedido.Text = "Finalizar &Pedido";
            btnFinalizarPedido.UseVisualStyleBackColor = true;
            btnFinalizarPedido.Click += btnFinalizarPedido_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(16, 640);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 9;
            label5.Text = "Status do Pedido";
            // 
            // btnAbrirPedido
            // 
            btnAbrirPedido.Location = new Point(1043, 129);
            btnAbrirPedido.Name = "btnAbrirPedido";
            btnAbrirPedido.Size = new Size(139, 44);
            btnAbrirPedido.TabIndex = 17;
            btnAbrirPedido.Text = "&Abrir Pedido";
            btnAbrirPedido.UseVisualStyleBackColor = true;
            btnAbrirPedido.Click += btnAbrirPedido_Click;
            // 
            // gbProduto
            // 
            gbProduto.Controls.Add(txtDescricaoSaborDois);
            gbProduto.Controls.Add(txtCodSaborDois);
            gbProduto.Controls.Add(radioButtonMeia);
            gbProduto.Controls.Add(radioButtonPizza);
            gbProduto.Controls.Add(cmbTamanhoPizza);
            gbProduto.Controls.Add(btnInserirProduto);
            gbProduto.Controls.Add(label8);
            gbProduto.Controls.Add(Quantidade);
            gbProduto.Controls.Add(label7);
            gbProduto.Controls.Add(txtQuantidade);
            gbProduto.Controls.Add(txtValorUnit);
            gbProduto.Controls.Add(label17);
            gbProduto.Controls.Add(label6);
            gbProduto.Controls.Add(txtRotulo);
            gbProduto.Controls.Add(label16);
            gbProduto.Controls.Add(label15);
            gbProduto.Controls.Add(txtCodProduto);
            gbProduto.Enabled = false;
            gbProduto.Location = new Point(5, 409);
            gbProduto.Name = "gbProduto";
            gbProduto.Size = new Size(1160, 142);
            gbProduto.TabIndex = 11;
            gbProduto.TabStop = false;
            gbProduto.Text = "Produto";
            // 
            // txtDescricaoSaborDois
            // 
            txtDescricaoSaborDois.Enabled = false;
            txtDescricaoSaborDois.Location = new Point(610, 100);
            txtDescricaoSaborDois.Name = "txtDescricaoSaborDois";
            txtDescricaoSaborDois.Size = new Size(390, 29);
            txtDescricaoSaborDois.TabIndex = 22;
            // 
            // txtCodSaborDois
            // 
            txtCodSaborDois.Enabled = false;
            txtCodSaborDois.Location = new Point(464, 100);
            txtCodSaborDois.Name = "txtCodSaborDois";
            txtCodSaborDois.Size = new Size(92, 29);
            txtCodSaborDois.TabIndex = 22;
            txtCodSaborDois.TextChanged += txtCodSaborDois_TextChanged;
            // 
            // radioButtonMeia
            // 
            radioButtonMeia.AutoSize = true;
            radioButtonMeia.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonMeia.Location = new Point(313, 99);
            radioButtonMeia.Name = "radioButtonMeia";
            radioButtonMeia.Size = new Size(105, 24);
            radioButtonMeia.TabIndex = 21;
            radioButtonMeia.Text = "Pizza  Meia";
            radioButtonMeia.UseVisualStyleBackColor = true;
            radioButtonMeia.CheckedChanged += radioButtonMeia_CheckedChanged;
            // 
            // radioButtonPizza
            // 
            radioButtonPizza.AutoSize = true;
            radioButtonPizza.Checked = true;
            radioButtonPizza.CheckState = CheckState.Checked;
            radioButtonPizza.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonPizza.Location = new Point(17, 29);
            radioButtonPizza.Name = "radioButtonPizza";
            radioButtonPizza.Size = new Size(63, 24);
            radioButtonPizza.TabIndex = 20;
            radioButtonPizza.Text = "Pizza";
            radioButtonPizza.UseVisualStyleBackColor = true;
            radioButtonPizza.CheckedChanged += radioButtonPizza_CheckedChanged;
            // 
            // cmbTamanhoPizza
            // 
            cmbTamanhoPizza.FormattingEnabled = true;
            cmbTamanhoPizza.Location = new Point(21, 100);
            cmbTamanhoPizza.Name = "cmbTamanhoPizza";
            cmbTamanhoPizza.Size = new Size(172, 29);
            cmbTamanhoPizza.TabIndex = 19;
            cmbTamanhoPizza.SelectedIndexChanged += cmbTamanhoPizza_SelectedIndexChanged;
            // 
            // btnInserirProduto
            // 
            btnInserirProduto.Location = new Point(1023, 62);
            btnInserirProduto.Name = "btnInserirProduto";
            btnInserirProduto.Size = new Size(114, 61);
            btnInserirProduto.TabIndex = 16;
            btnInserirProduto.Text = "&Inserir";
            btnInserirProduto.UseVisualStyleBackColor = true;
            btnInserirProduto.Click += btnInserirProduto_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(21, 77);
            label8.Name = "label8";
            label8.Size = new Size(104, 15);
            label8.TabIndex = 14;
            label8.Text = "Tamanho da pizza";
            // 
            // Quantidade
            // 
            Quantidade.AutoSize = true;
            Quantidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Quantidade.Location = new Point(798, 17);
            Quantidade.Name = "Quantidade";
            Quantidade.Size = new Size(71, 15);
            Quantidade.TabIndex = 13;
            Quantidade.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(610, 25);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 13;
            label7.Text = "Valor unitário";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(724, 45);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(233, 29);
            txtQuantidade.TabIndex = 12;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(597, 45);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(121, 29);
            txtValorUnit.TabIndex = 12;
            txtValorUnit.TextChanged += txtValorUnit_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.Location = new Point(702, 85);
            label17.Name = "label17";
            label17.Size = new Size(119, 15);
            label17.TabIndex = 11;
            label17.Text = "Rótulo do sabor dois";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(351, 25);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 11;
            label6.Text = "Rótulo";
            // 
            // txtRotulo
            // 
            txtRotulo.Location = new Point(348, 45);
            txtRotulo.Name = "txtRotulo";
            txtRotulo.Size = new Size(246, 29);
            txtRotulo.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(453, 79);
            label16.Name = "label16";
            label16.Size = new Size(103, 13);
            label16.TabIndex = 9;
            label16.Text = "Código Sabor dois";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.Location = new Point(167, 25);
            label15.Name = "label15";
            label15.Size = new Size(110, 15);
            label15.TabIndex = 9;
            label15.Text = "Código do produto";
            // 
            // txtCodProduto
            // 
            txtCodProduto.Location = new Point(96, 45);
            txtCodProduto.Name = "txtCodProduto";
            txtCodProduto.Size = new Size(246, 29);
            txtCodProduto.TabIndex = 0;
            txtCodProduto.TextChanged += txtCodProduto_TextChanged;
            // 
            // gbCliente
            // 
            gbCliente.Controls.Add(label14);
            gbCliente.Controls.Add(label13);
            gbCliente.Controls.Add(txtClienteCPF);
            gbCliente.Controls.Add(txtClienteId);
            gbCliente.Location = new Point(32, 79);
            gbCliente.Name = "gbCliente";
            gbCliente.Size = new Size(1000, 109);
            gbCliente.TabIndex = 10;
            gbCliente.TabStop = false;
            gbCliente.Text = "Dados do Cliente";
            gbCliente.Enter += gbCliente_Enter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label14.Location = new Point(28, 54);
            label14.Name = "label14";
            label14.Size = new Size(23, 19);
            label14.TabIndex = 2;
            label14.Text = "ID";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label13.Location = new Point(258, 50);
            label13.Name = "label13";
            label13.Size = new Size(50, 19);
            label13.TabIndex = 2;
            label13.Text = "Nome";
            // 
            // txtClienteCPF
            // 
            txtClienteCPF.Location = new Point(314, 44);
            txtClienteCPF.Name = "txtClienteCPF";
            txtClienteCPF.Size = new Size(638, 29);
            txtClienteCPF.TabIndex = 1;
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(62, 45);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(138, 29);
            txtClienteId.TabIndex = 0;
            txtClienteId.TextChanged += txtClienteId_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1094, 12);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 9;
            label3.Text = "Nº Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 31);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 8;
            label2.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(339, 28);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(480, 29);
            txtVendedor.TabIndex = 7;
            txtVendedor.TextChanged += txtVendedor_TextChanged;
            // 
            // txtNumeroItemPedido
            // 
            txtNumeroItemPedido.Enabled = false;
            txtNumeroItemPedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroItemPedido.ForeColor = Color.FromArgb(0, 192, 0);
            txtNumeroItemPedido.Location = new Point(907, 22);
            txtNumeroItemPedido.Name = "txtNumeroItemPedido";
            txtNumeroItemPedido.RightToLeft = RightToLeft.Yes;
            txtNumeroItemPedido.Size = new Size(94, 29);
            txtNumeroItemPedido.TabIndex = 6;
            txtNumeroItemPedido.Text = "0";
            txtNumeroItemPedido.Visible = false;
            txtNumeroItemPedido.TextChanged += txtNumeroPedido_TextChanged;
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.Font = new Font("Segoe UI", 24F);
            txtNumeroPedido.ForeColor = Color.FromArgb(0, 192, 0);
            txtNumeroPedido.Location = new Point(1047, 40);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.ReadOnly = true;
            txtNumeroPedido.RightToLeft = RightToLeft.Yes;
            txtNumeroPedido.Size = new Size(169, 50);
            txtNumeroPedido.TabIndex = 6;
            txtNumeroPedido.Text = "0";
            txtNumeroPedido.TextChanged += txtNumeroPedido_TextChanged;
            // 
            // gbBuscaProduto
            // 
            gbBuscaProduto.Controls.Add(txtBuscaProduto);
            gbBuscaProduto.Controls.Add(dgvProdutos);
            gbBuscaProduto.Enabled = false;
            gbBuscaProduto.Location = new Point(5, 194);
            gbBuscaProduto.Name = "gbBuscaProduto";
            gbBuscaProduto.Size = new Size(1162, 209);
            gbBuscaProduto.TabIndex = 24;
            gbBuscaProduto.TabStop = false;
            gbBuscaProduto.Text = "Busca de Produto";
            // 
            // txtBuscaProduto
            // 
            txtBuscaProduto.Location = new Point(6, 26);
            txtBuscaProduto.Name = "txtBuscaProduto";
            txtBuscaProduto.PlaceholderText = "Digite aqui para buscar os produtos";
            txtBuscaProduto.Size = new Size(1010, 29);
            txtBuscaProduto.TabIndex = 24;
            txtBuscaProduto.TextChanged += txtBuscaProduto_TextChanged;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnDescricaoproduto, clnValorProduto, clnCodBarrasProduto, clnImagem, clnCategoria });
            dgvProdutos.Location = new Point(6, 61);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.Size = new Size(1150, 135);
            dgvProdutos.TabIndex = 23;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome do Produto";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 180;
            // 
            // clnDescricaoproduto
            // 
            clnDescricaoproduto.Frozen = true;
            clnDescricaoproduto.HeaderText = "Descrição do Produto";
            clnDescricaoproduto.Name = "clnDescricaoproduto";
            clnDescricaoproduto.ReadOnly = true;
            clnDescricaoproduto.Width = 293;
            // 
            // clnValorProduto
            // 
            clnValorProduto.Frozen = true;
            clnValorProduto.HeaderText = "Valor Unit";
            clnValorProduto.Name = "clnValorProduto";
            clnValorProduto.ReadOnly = true;
            clnValorProduto.Width = 115;
            // 
            // clnCodBarrasProduto
            // 
            clnCodBarrasProduto.Frozen = true;
            clnCodBarrasProduto.HeaderText = "Código de Barras do Produto";
            clnCodBarrasProduto.Name = "clnCodBarrasProduto";
            clnCodBarrasProduto.ReadOnly = true;
            clnCodBarrasProduto.Width = 265;
            // 
            // clnImagem
            // 
            clnImagem.Frozen = true;
            clnImagem.HeaderText = "Imagem";
            clnImagem.Name = "clnImagem";
            clnImagem.ReadOnly = true;
            clnImagem.Width = 153;
            // 
            // clnCategoria
            // 
            clnCategoria.Frozen = true;
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1284, 739);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.HotTrack;
            Margin = new Padding(4);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbTipoBorda.ResumeLayout(false);
            gbTipoBorda.PerformLayout();
            gbAdicionais.ResumeLayout(false);
            gbAdicionais.PerformLayout();
            gbProduto.ResumeLayout(false);
            gbProduto.PerformLayout();
            gbCliente.ResumeLayout(false);
            gbCliente.PerformLayout();
            gbBuscaProduto.ResumeLayout(false);
            gbBuscaProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtDataPed;
        private Label label4;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtNumeroPedido;
        private GroupBox gbCliente;
        private Label label3;
        private Label label2;
        private TextBox txtVendedor;
        private GroupBox gbProduto;
        private TextBox txtValorUnit;
        private Label label6;
        private TextBox txtRotulo;
        private Label label5;
        private TextBox txtCodProduto;
        private TextBox txtClienteCPF;
        private TextBox txtClienteId;
        private Label label7;
        private Button btnAbrirPedido;
        private Button btnInserirProduto;
        private Label label8;
        private Button btnFinalizarPedido;
        private Label label9;
        private ComboBox cmbDesconto;
        private TextBox txtDesconto;
        private TextBox txtTotalValor;
        private Label label12;
        private Label label11;
        private Label label14;
        private Label label13;
        private ComboBox cmbStatus;
        private Label label15;
        private ComboBox cmbTamanhoPizza;
        private Label Quantidade;
        private TextBox txtQuantidade;
        private DataGridView dgvProdutos;
        private TextBox txtCodSaborDois;
        private CheckBox radioButtonMeia;
        private Label label16;
        private GroupBox gbBuscaProduto;
        private TextBox txtBuscaProduto;
        private CheckBox radioButtonPizza;
        private TextBox txtDescricaoSaborDois;
        private Label label17;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnDescricaoproduto;
        private DataGridViewTextBoxColumn clnValorProduto;
        private DataGridViewTextBoxColumn clnCodBarrasProduto;
        private DataGridViewTextBoxColumn clnImagem;
        private DataGridViewTextBoxColumn clnCategoria;
        private GroupBox gbAdicionais;
        private ComboBox cmbAdicionais;
        private TextBox txtValorAdicional;
        private GroupBox gbTipoBorda;
        private Button btnInserirTipoBorda;
        private TextBox txtValorTipoBorda;
        private ComboBox cmbTipoBorda;
        private Button btnInserirAdicional;
        private TextBox txtNumeroItemPedido;
    }
}