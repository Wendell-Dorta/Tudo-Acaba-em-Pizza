using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAEPClass;

namespace TudoAcabaEmPizza
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            var nivel = Nivel.ObterLista();
            cbmNivel.DataSource = nivel;
            cbmNivel.DisplayMember = "descricao";
            cbmNivel.ValueMember = "id";

            var listaUsuarios = Usuario.ObterLista();
            int count = 0;
            // Preenche o DataGridView com todos os endereços
            dgvUsuario.Rows.Clear();
            foreach (var usaurio in listaUsuarios)
            {
                int rowIndex = dgvUsuario.Rows.Add();
                dgvUsuario.Rows[count].Cells[0].Value = usaurio.Id;
                dgvUsuario.Rows[count].Cells[1].Value = usaurio.Nome;
                dgvUsuario.Rows[count].Cells[2].Value = usaurio.Email;
                dgvUsuario.Rows[count].Cells[3].Value = usaurio.Nivel.Descricao;
                dgvUsuario.Rows[count].Cells[4].Value = usaurio.Ativo;
                count++;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(
                txtNome.Text,
                txtEmail.Text,
                txtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(cbmNivel.SelectedValue))
            );
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                txtNome.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
                MessageBox.Show($"Usuario {usuario.GetHashCode()} cadastrado com sucesso");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                txtNome.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
                txtId.ReadOnly = false;
                txtId.Focus();
                btnConsultar.Text = "&Buscar";
            }
            else
            {
                // realizando a busca de cliente
                if (txtId.Text.Length > 0)
                {
                    Usuario usuario = Usuario.ObterPorId(int.Parse(txtId.Text));
                    txtNome.Text = usuario.Nome;
                    txtEmail.Text = usuario.Email;
                    txtGuardaSenha.Text = usuario.Senha;
                    btnConsultar.Text = "&Consultar";
                    txtId.ReadOnly = true;
                    txtSenha.PlaceholderText = "[Digite uma senha caso queira mudar-la]";
                    cbmNivel.SelectedValue = usuario.Nivel.Id;
                    btnAlterar.Enabled = true;
                }
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new();
            string senha = null;
            string confirmarSenha = usuario.CriptografarSenha(txtConfirmarSenha.Text);
            if (txtSenha.Text != null)
            {
                senha = usuario.CriptografarSenha(txtSenha.Text);
            }
            else
            {
                senha = txtGuardaSenha.Text;
            }
            usuario = new(
                    int.Parse(txtId.Text),
                    txtNome.Text,
                    txtEmail.Text,
                    Nivel.ObterPorId(Convert.ToInt32(cbmNivel.SelectedValue))
                );
            if (usuario.Editar(usuario.Id,confirmarSenha, senha))
            {
                FrmUsuario_Load(sender, e);
                MessageBox.Show($"O usuário {usuario.Nome} foi alterado com sucesso");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar o usuário \" {usuario.Nome} \" !");
            }
        }
    }
}