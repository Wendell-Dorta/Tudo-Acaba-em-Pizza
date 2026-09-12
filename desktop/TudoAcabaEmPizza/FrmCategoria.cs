using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAEPClass;

namespace TudoAcabaEmPizza
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            var lista = Categoria.ObterLista();
            dgvCategoria.Rows.Clear();
            int count = 0;
            btnEditar.Enabled = false;
            foreach (var categoria in lista)
            {
                dgvCategoria.Rows.Add();
                dgvCategoria.Rows[count].Cells[0].Value = categoria.Id;
                dgvCategoria.Rows[count].Cells[1].Value = categoria.Descricao;
                dgvCategoria.Rows[count].Cells[2].Value = categoria.Sigla;


                count++;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Categoria categoria = new(txtNome.Text, txtSigla.Text);
            categoria.Inserir();
            FrmCategoria_Load(sender, e);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new(
                    int.Parse(txtId.Text)
                    , txtNome.Text
                    , txtSigla.Text
                    );
            if (categoria.Editar(categoria.Id))
            {
                FrmCategoria_Load(sender, e);
                MessageBox.Show($"A categoria \" {categoria.Descricao} \" foi alterado com sucesso!");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar a categoria \" {categoria.Descricao} \" !");
            }
        }

        private void btnObterPorId_Click(object sender, EventArgs e)
        {
            if (btnObterPorId.Text == "&Consultar")
            {
                txtNome.Clear();
                txtSigla.Clear();
                txtId.ReadOnly = false;
                txtId.Focus();
                btnObterPorId.Text = "&Obter por ID";
            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Categoria categoria = Categoria.ObterPorId(int.Parse(txtId.Text));
                    txtNome.Text = categoria.Descricao;
                    txtSigla.Text = categoria.Sigla;
                    txtId.ReadOnly = true;
                    btnObterPorId.Text = "&Consultar";
                    btnEditar.Enabled = true;

                }
            }
        }
    }
}
