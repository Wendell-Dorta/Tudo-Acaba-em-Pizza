namespace TudoAcabaEmPizza
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tiposDeBordaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoBorda frmTipoBorda = new();
            frmTipoBorda.MdiParent = this;
            frmTipoBorda.Show();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin login = new();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.ShowDialog();
            tslUsuario.Text = $"{Program.Usuario.Nome}  -  {Program.Usuario.Nivel.Descricao}";
        }

        private void tipoDeBordaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoBorda frmTipoBorda = new();
            frmTipoBorda.MdiParent = this;
            frmTipoBorda.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();

        }

        private void cadastroEConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new();
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tipoTelefoneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tipoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoPag frmTipoPag = new();
            frmTipoPag.MdiParent = this;
            frmTipoPag.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void cadastroUsuárioEClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void nOVOPEDIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedido frmPedido = new();
            frmPedido.MdiParent = this;
            frmPedido.Show();
        }
    }
}
