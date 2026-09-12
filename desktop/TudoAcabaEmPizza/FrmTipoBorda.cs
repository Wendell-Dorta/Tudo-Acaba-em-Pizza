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
    public partial class FrmTipoBorda : Form
    {
        public FrmTipoBorda()
        {
            InitializeComponent();
        }

        private void FrmTipoBorda_Load(object sender, EventArgs e)
        {
            var lista = TipoBorda.ObterLista();
            dgvTipoBorda.Rows.Clear();
            int count = 0;
            btnEditar.Enabled = false;
            foreach (var tipoBorda in lista)
            {
                dgvTipoBorda.Rows.Add();
                dgvTipoBorda.Rows[count].Cells[0].Value = tipoBorda.Id;
                dgvTipoBorda.Rows[count].Cells[1].Value = tipoBorda.Descricao;
                dgvTipoBorda.Rows[count].Cells[2].Value = tipoBorda.Valor;


                count++;

            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            TipoBorda tipoBorda = new(double.Parse(txtPreco.Text), txtDescricao.Text );
            tipoBorda.Inserir();
            FrmTipoBorda_Load(sender,e);
           
        }

        private void btnObterPorId_Click(object sender, EventArgs e)
        {
            if (btnObterPorId.Text == "&Consultar")
            {
                txtDescricao.Clear();
                txtPreco.Clear();
                txtId.ReadOnly = false;
                txtId.Focus();
                btnObterPorId.Text = "&Obter por ID";
            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    TipoBorda tipoBorda = TipoBorda.ObterPorId(int.Parse(txtId.Text));
                    txtPreco.Text = Convert.ToString(tipoBorda.Valor);
                    txtDescricao.Text = tipoBorda.Descricao;
                    txtId.ReadOnly = true;
                    btnObterPorId.Text = "&Consultar";
                    btnEditar.Enabled = true;

                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TipoBorda tipoBorda = new(
                   int.Parse(txtId.Text)
                   , double.Parse(txtPreco.Text)
                   , txtDescricao.Text
                   
                   );
            if (tipoBorda.Editar(tipoBorda.Id))
            {
                FrmTipoBorda_Load(sender, e);
                MessageBox.Show($"A Borda: \" {tipoBorda.Descricao} \" foi alterada com sucesso!");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar a borda \" {tipoBorda.Descricao} \" !");
            }
        }
    }
}
