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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        /// <summary>
        /// Realiza o login do usuário com base nos dados informados nos campos de email e senha.
        /// </summary>
        private void Login()
        {
            if (txtEmail.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
                if (usuario == null)
                {
                    MessageBox.Show("Email e/ou senha inválidos ou acesso negado!");
                }
                else
                {
                    Program.Usuario = usuario;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Digite um Email e Senha para prosseguir!");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}