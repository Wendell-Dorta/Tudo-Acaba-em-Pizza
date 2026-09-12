using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAEPClass;

namespace TudoAcabaEmPizza
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void CarregarAdicionais()
        {
            var adicionais = Adicional.ObterLista();
            cmbAdicionais.DataSource = adicionais;
            cmbAdicionais.DisplayMember = "descricao";
            cmbAdicionais.ValueMember = "id";



        }


        private void CarregarTipoBorda()
        {
            var tipoBorda = TipoBorda.ObterLista();
            cmbTipoBorda.DataSource = tipoBorda;
            cmbTipoBorda.DisplayMember = "descricao";
            cmbTipoBorda.ValueMember = "id";



        }


        private void FrmPedido_Load(object sender, EventArgs e)
        {
            var dataAtual = DateTime.Now;
            txtVendedor.Text = $"{Program.Usuario.Id} - {Program.Usuario.Nome}";
            CarregarStatus();
            CarregarTipoDesconto();
            CarregaGridProduto();
            TamanhoDePizza();
            CarregarAdicionais();
            CarregarTipoBorda();


        }
        private void CarregaGridProduto()
        {
            var produto = Produto.ObterLista();
            int count = 0;
            // Preenche o DataGridView com todos os endereços
            dgvProdutos.Rows.Clear();
            foreach (var produtos in produto)
            {
                int rowIndex = dgvProdutos.Rows.Add();
                dgvProdutos.Rows[count].Cells[0].Value = produtos.Id;
                dgvProdutos.Rows[count].Cells[1].Value = produtos.Rotulo;
                dgvProdutos.Rows[count].Cells[2].Value = produtos.Descricao;
                dgvProdutos.Rows[count].Cells[3].Value = produtos.ValorUnit;
                dgvProdutos.Rows[count].Cells[4].Value = produtos.CodBarras;
                dgvProdutos.Rows[count].Cells[5].Value = produtos.NomeImagem;
                dgvProdutos.Rows[count].Cells[6].Value = produtos.CategoriaId.Sigla;
                count++;
            }
        }

        private void CarregarStatus()
        {
            var status = Status.ObterLista();
            cmbStatus.DataSource = status;
            cmbStatus.DisplayMember = "descricao";
            cmbStatus.ValueMember = "id";
        }

        public void TamanhoDePizza()
        {
            var tamanhoPizza = TamanhoPizza.ObterLista();
            cmbTamanhoPizza.DataSource = tamanhoPizza;
            cmbTamanhoPizza.DisplayMember = "descricao";
            cmbTamanhoPizza.ValueMember = "id";
        }

        private void CarregarTipoDesconto()
        {
            var classeDesconto = ClasseDesconto.ObterLista();
            cmbDesconto.DataSource = classeDesconto;
            cmbDesconto.DisplayMember = "descricao";
            cmbDesconto.ValueMember = "id";
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbItemAdicional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void AtualizarValorTotal()
        {
            try
            {
                // Convertendo os valores das TextBox para double
                double valorUnitario = Convert.ToDouble(txtValorUnit.Text);
                double quantidade = Convert.ToDouble(txtQuantidade.Text);
                double valorAdicional = Convert.ToDouble(txtValorAdicional.Text);
                double valorTipoBorda = Convert.ToDouble(txtValorTipoBorda.Text);
                double desconto = Convert.ToDouble(txtDesconto.Text);

                // Calculando o valor total
                double valorTotal = (valorUnitario * quantidade) + valorAdicional + valorTipoBorda - desconto;

                // Exibindo o valor total no txtTotalValor
                txtTotalValor.Text = valorTotal.ToString("F2"); // "F2" formata o número com 2 casas decimais
            }
            catch (FormatException)
            {
                // Trate a exceção aqui, por exemplo, mostrar uma mensagem que não tem valor ainda
                txtTotalValor.Text = "Sem Valor";
            }
        }


        private void btnAbrirPedido_Click(object sender, EventArgs e)
        {
            TAEPClass.Pedido pedido = new();
            pedido.Cliente = Cliente.ObterPorId(int.Parse(txtClienteId.Text));
            pedido.Usuario = Program.Usuario;
            pedido.StatusId = Status.ObterPorId(Convert.ToInt32(cmbStatus.SelectedValue));
            pedido.ClasseDesconto = ClasseDesconto.ObterPorId(Convert.ToInt32(cmbDesconto.SelectedValue));
            pedido.Inserir();
            txtNumeroPedido.Text = pedido.Id.ToString();
            gbProduto.Enabled = true;
            gbBuscaProduto.Enabled = true;
            btnAbrirPedido.Enabled = false;
        }


        private void txtClienteId_TextChanged(object sender, EventArgs e)
        {
            if (txtClienteId.Text.Length > 0)
            {
                Cliente cliente = Cliente.ObterPorId(Convert.ToInt32(txtClienteId.Text));
                if (cliente.Id > 0)
                {
                    txtClienteCPF.Text = cliente.Cpf;
                }
            }
        }



        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnInserirProduto_Click(object sender, EventArgs e)
        {

            ItemPedido itempedido = new(Pedido.ObterPorId(int.Parse(txtNumeroPedido.Text))
             , Produto.ObterPorId(int.Parse(txtCodProduto.Text))
             , double.Parse(txtQuantidade.Text)
             , double.Parse(txtValorUnit.Text)
             , TamanhoPizza.ObterPorId(Convert.ToInt32(cmbTamanhoPizza.SelectedValue))
             , radioButtonMeia.Checked
             , txtDescricaoSaborDois.Text
             );
            itempedido.Inserir();
            MessageBox.Show($"O produto: {txtRotulo.Text} foi inserido no Pedido de Número: {txtNumeroPedido.Text}");
            txtNumeroItemPedido.Text = itempedido.Id.ToString();
            gbAdicionais.Enabled = true;
            gbTipoBorda.Enabled = true;

        }

        private void CarregarTamanhosPizza()
        {
            var tamanhoPizzas = TamanhoPizza.ObterLista();
            cmbTamanhoPizza.DataSource = tamanhoPizzas;
            cmbTamanhoPizza.DisplayMember = "descricao";
            cmbTamanhoPizza.ValueMember = "id";
        }

        private void txtBuscaProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaProduto.Text.Length > 0)
            {
                var produto = Produto.ObterLista(txtBuscaProduto.Text);
                dgvProdutos.Rows.Clear();
                int count = 0;
                foreach (var produtos in produto)
                {
                    dgvProdutos.Rows.Add();
                    dgvProdutos.Rows[count].Cells[0].Value = produtos.Id;
                    dgvProdutos.Rows[count].Cells[1].Value = produtos.Rotulo;
                    dgvProdutos.Rows[count].Cells[2].Value = produtos.Descricao;
                    dgvProdutos.Rows[count].Cells[3].Value = produtos.ValorUnit;
                    dgvProdutos.Rows[count].Cells[4].Value = produtos.CodBarras;
                    dgvProdutos.Rows[count].Cells[5].Value = produtos.NomeImagem;
                    dgvProdutos.Rows[count].Cells[6].Value = produtos.CategoriaId.Descricao;
                    count++;
                }
            }
            else
            {
                FrmPedido_Load(sender, e);
            }
        }
        Produto produto = new();
        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtCodProduto.Text.Length > 0)
            {
                produto = Produto.ObterPorId(int.Parse(txtCodProduto.Text));
                if (produto.Id > 0)
                {
                    txtRotulo.Text = produto.Rotulo;
                    txtValorUnit.Text = produto.ValorUnit.ToString();


                }
            }
        }

        private void radioButtonPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPizza.Checked)
            {
                cmbTamanhoPizza.Enabled = true;
                TamanhoDePizza();
                cmbTipoBorda.Enabled = true;
                cmbAdicionais.Enabled = true;
            }
            else
            {
                cmbTamanhoPizza.Enabled = false;
                cmbTipoBorda.Enabled = false;
                cmbAdicionais.Enabled = false;
            }
        }

        private void cmbTamanhoPizza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMeia_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMeia.Checked)
            {
                txtCodSaborDois.Enabled = true;
                txtDescricaoSaborDois.Enabled = true;


            }
            else
            {
                txtCodSaborDois.Enabled = false;
                txtDescricaoSaborDois.Enabled = false;
            }
        }

        private void txtCodSaborDois_TextChanged(object sender, EventArgs e)
        {
            if (txtCodSaborDois.Text.Length > 0)
            {
                produto = Produto.ObterPorId(int.Parse(txtCodSaborDois.Text));
                if (produto.Id > 0)
                {
                    txtDescricaoSaborDois.Text = produto.Rotulo;



                }
            }
        }

        private void txtNumeroPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbAdicionais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAdicionais.SelectedItem != null)
            {

                var selecionado = (Adicional)cmbAdicionais.SelectedItem;
                txtValorAdicional.Text = selecionado.Preco.ToString("F2"); // Formata como double com 2 casas decimais
            }
        }

        private void cmbTipoBorda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoBorda.SelectedItem != null)
            {

                var escolhido = (TipoBorda)cmbTipoBorda.SelectedItem;
                txtValorTipoBorda.Text = escolhido.Valor.ToString("F2"); // Formata como double com 2 casas decimais
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ItemPedidoAdicional itemPedidoAdicional = new ItemPedidoAdicional(
                Convert.ToInt32(cmbAdicionais.SelectedValue),
                int.Parse(txtNumeroItemPedido.Text)
            );
            itemPedidoAdicional.Inserir();
            if (itemPedidoAdicional.Id > 0)
            {
                MessageBox.Show($"O Adicional foi adicionado ao pedido");
            }
        }

        private void btnInserirTipoBorda_Click(object sender, EventArgs e)
        {

            ItemPedidoTipoBorda itemPedidoTipoBorda = new ItemPedidoTipoBorda(
                  Convert.ToInt32(cmbTipoBorda.SelectedValue),
                  int.Parse(txtNumeroItemPedido.Text)

                );
            itemPedidoTipoBorda.Inserir();
            if (itemPedidoTipoBorda.Id > 0)
            {
                MessageBox.Show($"O tipo de borda foi adicionado ao pedido");
            }
        }

        private void txtResumo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDesconto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDesconto.SelectedItem != null)
            {

                var descontoEscolhido = (ClasseDesconto)cmbDesconto.SelectedItem;
                txtDesconto.Text = descontoEscolhido.Desconto.ToString("F2"); // Formata como double com 2 casas decimais
            }
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            AtualizarValorTotal();
        }

        private void txtTotalValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorUnit_TextChanged(object sender, EventArgs e)
        {
            AtualizarValorTotal();
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            AtualizarValorTotal();
        }

        private void txtValorAdicional_TextChanged(object sender, EventArgs e)
        {
            AtualizarValorTotal();
        }

        private void txtValorTipoBorda_TextChanged(object sender, EventArgs e)
        {
            AtualizarValorTotal();
        }

        private void gbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido finalizado com sucesso!");
            txtCodProduto.Clear();
            txtRotulo.Clear();
            txtValorTipoBorda.Clear();
            txtQuantidade.Clear();  
            txtValorUnit.Clear();
            txtValorAdicional.Clear();
            txtDesconto.Clear();
            
        }
    }
}