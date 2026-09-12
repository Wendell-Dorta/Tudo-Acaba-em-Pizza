namespace TudoAcabaEmPizza
{
    partial class FrmLogin
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
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            gbLogin = new GroupBox();
            btnEntrar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(68, 26);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(68, 44);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(254, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(68, 98);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(254, 23);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(68, 83);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(btnEntrar);
            gbLogin.Controls.Add(btnCancelar);
            gbLogin.Controls.Add(txtSenha);
            gbLogin.Controls.Add(label1);
            gbLogin.Controls.Add(label2);
            gbLogin.Controls.Add(txtEmail);
            gbLogin.ForeColor = Color.ForestGreen;
            gbLogin.Location = new Point(81, 109);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(377, 188);
            gbLogin.TabIndex = 4;
            gbLogin.TabStop = false;
            gbLogin.Text = "Login";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.ForestGreen;
            btnEntrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.ControlLightLight;
            btnEntrar.Location = new Point(241, 145);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(81, 27);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "&Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.ForestGreen;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(68, 145);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 27);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(234, 50);
            label3.Name = "label3";
            label3.Size = new Size(111, 33);
            label3.TabIndex = 5;
            label3.Text = "LOGIN";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 378);
            Controls.Add(label3);
            Controls.Add(gbLogin);
            Name = "FrmLogin";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            KeyDown += FrmLogin_KeyDown;
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label label2;
        private GroupBox gbLogin;
        private Button btnCancelar;
        private Button btnEntrar;
        private Label label3;
    }
}