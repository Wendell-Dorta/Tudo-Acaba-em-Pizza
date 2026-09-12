using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using TAEPClass;

namespace TudoAcabaEmPizza
{
    // Classe principal do formulário de gerenciamento de produtos
    public partial class FrmProduto : Form
    {
        private string origemCompleto = ""; // Caminho completo do arquivo de imagem selecionado
        private string destinoCompleto = ""; // Caminho completo do arquivo de imagem no destino
        private string pastaDestino = Banco.caminhoFotos; // Caminho da pasta onde as fotos serão armazenadas

        // Construtor do formulário
        public FrmProduto()
        {
            InitializeComponent(); // Inicializa os componentes do formulário
        }

        // Evento disparado quando o formulário é carregado
        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // Carrega categorias e produtos na inicialização do formulário
            CarregarCategorias();
            CarregarProdutos();
        }

        // Carrega a lista de categorias no ComboBox
        private void CarregarCategorias()
        {
            var categorias = Categoria.ObterLista(); // Obtém a lista de categorias
            cbmCategoria.DataSource = categorias; // Define a fonte de dados do ComboBox
            cbmCategoria.DisplayMember = "descricao"; // Define o texto a ser exibido no ComboBox
            cbmCategoria.ValueMember = "id"; // Define o valor associado ao texto no ComboBox
        }

        // Carrega a lista de produtos no DataGridView
        private void CarregarProdutos()
        {
            var lista = Produto.ObterLista(); // Obtém a lista de produtos
            dgvProdutos.Rows.Clear(); // Limpa as linhas existentes no DataGridView
            int count = 0;
            
            // Adiciona cada produto à DataGridView
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add(); // Adiciona uma nova linha ao DataGridView
                dgvProdutos.Rows[count].Cells[0].Value = produto.Id; // Define o valor da célula da coluna ID
                dgvProdutos.Rows[count].Cells[1].Value = produto.Rotulo; // Define o valor da célula da coluna Rótulo
                dgvProdutos.Rows[count].Cells[2].Value = produto.Descricao; // Define o valor da célula da coluna Descrição
                dgvProdutos.Rows[count].Cells[3].Value = produto.ValorUnit; // Define o valor da célula da coluna Valor Unitário
                dgvProdutos.Rows[count].Cells[4].Value = produto.CodBarras; // Define o valor da célula da coluna Código de Barras
                dgvProdutos.Rows[count].Cells[5].Value = produto.NomeImagem; // Define o valor da célula da coluna Nome da Imagem
                dgvProdutos.Rows[count].Cells[6].Value = produto.CategoriaId.Descricao; // Define o valor da célula da coluna Categoria
                count++;
                
            }
        }

        // Evento disparado quando o botão de consultar é clicado
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Alterna o comportamento entre modo de consulta e modo de obter produto por ID
            if (btnConsultar.Text == "&Consultar")
            {
                LimparCampos(); // Limpa os campos do formulário
                txtId.ReadOnly = false; // Torna o campo ID editável
                txtId.Focus(); // Define o foco para o campo ID
                btnConsultar.Text = "&Obter por ID"; // Altera o texto do botão
            }
            else
            {
                // Tenta obter o produto com base no ID informado
                if (int.TryParse(txtId.Text, out int id))
                {
                    CarregarProdutoPorId(id); // Carrega o produto correspondente ao ID
                }
            }
        }

        // Limpa todos os campos do formulário
        private void LimparCampos()
        {
            mskCodigo.Clear(); // Limpa o campo Código
            txtDescricao.Clear(); // Limpa o campo Descrição
            txtRotulo.Clear(); // Limpa o campo Rótulo
            txtValor.Clear(); // Limpa o campo Valor Unitário
            pb_foto.Image = null; // Limpa a imagem do PictureBox
        }

        // Carrega os detalhes de um produto específico com base no ID
        private void CarregarProdutoPorId(int id)
        {
            Produto produto = Produto.ObterPorId(id); // Obtém o produto com base no ID
            string caminhoCompleto = pastaDestino + produto.NomeImagem;
            txtRotulo.Text = produto.Rotulo; // Define o texto do campo Rótulo
            txtDescricao.Text = produto.Descricao; // Define o texto do campo Descrição
            txtValor.Text = produto.ValorUnit.ToString(); // Define o texto do campo Valor Unitário
            mskCodigo.Text = produto.CodBarras; // Define o texto do campo Código de Barras
            pb_foto.Image = Image.FromFile(caminhoCompleto); // Carrega a imagem do produto no PictureBox
            cbDestaque.Checked = produto.Destaque; // Define se o produto e destaque no checkbox
            cbmCategoria.SelectedIndex = cbmCategoria.FindString(produto.CategoriaId.Descricao); // Define a categoria selecionada
            btnEditar.Enabled = true; // Habilita o botão Editar
        }

        // Evento disparado quando o botão de inserir é clicado
        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Verifica se uma imagem foi selecionada e se o arquivo existe
            if (string.IsNullOrEmpty(origemCompleto) || !File.Exists(origemCompleto))
            {
                // Se não houver imagem, exibe uma mensagem e pergunta ao usuário se deseja continuar
                if (MessageBox.Show("Sem foto selecionada, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return; // Se o usuário escolher "Não", interrompe a operação
                }
            }
            else
            {
                // Se houver imagem, copia-a para a pasta de destino
                CopiarImagemParaDestino();
            }

            // Cria um novo objeto Produto com os dados fornecidos
            Produto produto = new Produto(
                txtRotulo.Text,
                txtDescricao.Text,
                Convert.ToDouble(txtValor.Text),
                mskCodigo.Text,
                destinoCompleto,
                cbDestaque.Checked,
                Categoria.ObterPorId(Convert.ToInt32(cbmCategoria.SelectedValue))
            );

            // Insere o novo produto e exibe uma mensagem de sucesso
            produto.Inserir();
            MessageBox.Show("Produto inserido com sucesso");
        }

        // Copia a imagem selecionada para a pasta de destino
        private void CopiarImagemParaDestino()
        {
            if (!string.IsNullOrEmpty(origemCompleto) && File.Exists(origemCompleto))
            {
                // Obtém o nome do arquivo original e a extensão
                string nomeArquivoOriginal = Path.GetFileName(origemCompleto);
                string extensaoArquivo = Path.GetExtension(origemCompleto);

                // Remove a extensão para obter o nome base do arquivo
                string nomeBase = Path.GetFileNameWithoutExtension(nomeArquivoOriginal).Replace(" ", "_");

                // Gera um novo nome para o arquivo com base nas propriedades fornecidas
                Random random = new Random();
                int numeroAleatorio = random.Next(100000, 999999); // Gera um número aleatório
                int usuarioId = Program.Usuario.Id; // Obtém o ID do usuário
                string usuarioNome = Program.Usuario.Nome.Replace(" ", "_"); // Obtém o nome do usuário
                string usuarioEmail = Program.Usuario.Email.Replace("@", "_"); // Obtém o e-mail do usuário
                string emailSemPonto = usuarioEmail.Replace(".", "_");
                DateTime dataAtual = DateTime.Now; // Obtém a data e hora atual
                string dataFormatada = dataAtual.ToString("yyyy_MM_dd__HH_mm_ss"); // Formata a data e hora
                string nivelUsuario = Program.Usuario.Nivel.Descricao; // Obtém o nível do usuário
                string enderecoIp = GetLocalIPAddress().Replace(".", "_"); // Obtém o IP local e substitui pontos por underlines

                // Monta o novo nome para o arquivo com a mesma extensão do arquivo original
                string novoNomeArquivo = $"{enderecoIp}-{usuarioId}-{usuarioNome}-{emailSemPonto}-{nivelUsuario}-{dataFormatada}-{numeroAleatorio}-{nomeBase}{extensaoArquivo}";

                // Define o novo caminho completo com o novo nome
                destinoCompleto = Path.Combine(pastaDestino, novoNomeArquivo);

                // Verifica se o arquivo já existe no destino e exibe uma mensagem se necessário
                if (File.Exists(destinoCompleto))
                {
                    MessageBox.Show("O arquivo já existe no destino, troque o nome dessa imagem");
                }
                else
                {
                    // Copia o arquivo para o destino com o novo nome
                    File.Copy(origemCompleto, destinoCompleto);
                }

                // Armazena apenas o nome do arquivo no destino
                destinoCompleto = novoNomeArquivo;
            }
        }

        // Evento disparado quando o botão de editar é clicado
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Cria um novo objeto Produto com os dados fornecidos e o ID do produto
            Produto produto = new Produto(
                int.Parse(txtId.Text),
                txtRotulo.Text,
                txtDescricao.Text,
                double.Parse(txtValor.Text),
                mskCodigo.Text,
                destinoCompleto,
                cbDestaque.Checked,
                Categoria.ObterPorId(Convert.ToInt32(cbmCategoria.SelectedValue))
            );

            // Tenta editar o produto e exibe uma mensagem de sucesso ou falha
            if (produto.Editar(produto.Id))
            {
                CarregarProdutos(); // Recarrega a lista de produtos
                MessageBox.Show($"O produto \"{produto.Rotulo}\" foi alterado com sucesso!");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar o produto \"{produto.Rotulo}\"!");
            }
        }

        // Evento disparado quando o botão de adicionar foto é clicado
        private void btnAddFoto_Click(object sender, EventArgs e)
        {
            // Define os filtros para o diálogo de abertura de arquivo
            openFileDialog1.Filter = "Image Files (*.BMP;*.JPG;*.JPEG;*.JFIF;*.GIF;*.PNG;*.TIFF;*.ICO;*.WEBP;*.RAW;*.HEIF;*.HEIC;*.SVG)|*.BMP;*.JPG;*.JPEG;*.JFIF;*.GIF;*.PNG;*.TIFF;*.ICO;*.WEBP;*.RAW;*.HEIF;*.HEIC;*.SVG|Common Image Files|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG;*.TIFF;*.ICO;*.WEBP|All Image Files (*.*)|*.BMP;*.JPG;*.JPEG;*.JFIF;*.GIF;*.PNG;*.TIFF;*.ICO;*.WEBP;*.RAW;*.HEIF;*.HEIC;*.SVG";
            openFileDialog1.Title = "Selecione uma imagem"; // Define o título do diálogo
            openFileDialog1.Multiselect = false; // Define que apenas um arquivo pode ser selecionado

            // Se o usuário selecionou um arquivo, exibe a imagem no PictureBox
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName; // Obtém o caminho completo do arquivo selecionado
                pb_foto.Image = Image.FromFile(origemCompleto); // Carrega a imagem no PictureBox
                pb_foto.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta o modo de exibição da imagem
            }
        }

        // Obtém o endereço IP local da máquina
        private string GetLocalIPAddress()
        {
            try
            {
                string hostName = Dns.GetHostName(); // Obtém o nome do host da máquina
                IPAddress[] addresses = Dns.GetHostAddresses(hostName); // Obtém os endereços IP associados ao host

                foreach (IPAddress address in addresses)
                {
                    if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        return address.ToString(); // Retorna o primeiro endereço IP de rede
                    }
                }

                return "IP não encontrado"; // Retorna uma mensagem caso não encontre um IP de rede
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter IP: {ex.Message}"); // Exibe uma mensagem de erro
                return "Erro ao obter IP"; // Retorna uma mensagem de erro
            }
        }

        // Evento disparado quando um arquivo é selecionado no diálogo (não utilizado atualmente)
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Se necessário, você pode adicionar algum código aqui para lidar com a seleção do arquivo
        }
    }
}