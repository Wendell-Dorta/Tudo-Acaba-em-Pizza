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
    public partial class FrmTipoPag : Form
    {
        public FrmTipoPag()
        {
            InitializeComponent();
        }

        private void FrmTipoPag_Load(object sender, EventArgs e)
        {
            var lista = TipoPagamento.ObterLista();
            dgvTipoPagamento.Rows.Clear();
            int count = 0;
            btnEditar.Enabled = false;
            foreach (var tipoPagamento in lista)
            {
                dgvTipoPagamento.Rows.Add();
                dgvTipoPagamento.Rows[count].Cells[0].Value = tipoPagamento.Id;
                dgvTipoPagamento.Rows[count].Cells[1].Value = tipoPagamento.Sigla;
                dgvTipoPagamento.Rows[count].Cells[2].Value = tipoPagamento.Descricão;


                count++;

            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            TipoPagamento tipoPagamento = new(txtSigla.Text, txtDescricao.Text);
            tipoPagamento.Inserir();
            FrmTipoPag_Load(sender, e);
        }

        private void btnObterPorId_Click(object sender, EventArgs e)
        {
            if (btnObterPorId.Text == "&Consultar")
            {
                txtSigla.Clear();
                txtDescricao.Clear();
                txtId.ReadOnly = false;
                txtId.Focus();
                btnObterPorId.Text = "&Obter por ID";
            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    TipoPagamento tipoPagamento = TipoPagamento.ObterPorId(int.Parse(txtId.Text));
                    txtSigla.Text = tipoPagamento.Sigla;
                    txtDescricao.Text = tipoPagamento.Descricão;
                    txtId.ReadOnly = true;
                    btnObterPorId.Text = "&Consultar";
                    btnEditar.Enabled = true;

                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TipoPagamento tipoPagamento = new(
                 int.Parse(txtId.Text)
                 , txtSigla.Text
                 , txtDescricao.Text
                 );
            if (tipoPagamento.Editar(tipoPagamento.Id))
            {
                FrmTipoPag_Load(sender, e);
                MessageBox.Show($"O tipo: \" {tipoPagamento.Descricão} \" foi alterada com sucesso!");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar o tipo de pagamento \" {tipoPagamento.Descricão} \" !");
            }
        }
    }
}
