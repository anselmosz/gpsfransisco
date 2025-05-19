namespace GPSFrancisco
{
    partial class frmGerenciarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarUsuarios));
            this.pnlCrud = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnChecked = new System.Windows.Forms.Button();
            this.btnInvalid = new System.Windows.Forms.Button();
            this.lblUsuariosCadastrados = new System.Windows.Forms.Label();
            this.cmbUsuariosCadastrados = new System.Windows.Forms.ComboBox();
            this.gpbUsrInfo = new System.Windows.Forms.GroupBox();
            this.pnlCrud.SuspendLayout();
            this.gpbUsrInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCrud
            // 
            this.pnlCrud.Controls.Add(this.btnVoltar);
            this.pnlCrud.Controls.Add(this.btnLimpar);
            this.pnlCrud.Controls.Add(this.btnPesquisar);
            this.pnlCrud.Controls.Add(this.btnExcluir);
            this.pnlCrud.Controls.Add(this.btnAlterar);
            this.pnlCrud.Controls.Add(this.btnCadastrar);
            this.pnlCrud.Controls.Add(this.btnNovo);
            this.pnlCrud.Location = new System.Drawing.Point(12, 583);
            this.pnlCrud.Name = "pnlCrud";
            this.pnlCrud.Size = new System.Drawing.Size(984, 46);
            this.pnlCrud.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(866, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(115, 40);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(487, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 40);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(608, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(115, 40);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(366, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 40);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(245, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(115, 40);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(124, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 40);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(3, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(115, 40);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(14, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 25);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(201, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(14, 65);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 20);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenha.Location = new System.Drawing.Point(18, 88);
            this.txtSenha.MaxLength = 12;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'l';
            this.txtSenha.Size = new System.Drawing.Size(186, 25);
            this.txtSenha.TabIndex = 3;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(206, 65);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(134, 20);
            this.lblConfirmarSenha.TabIndex = 4;
            this.lblConfirmarSenha.Text = "Confirme a senha";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtConfirmaSenha.Location = new System.Drawing.Point(210, 88);
            this.txtConfirmaSenha.MaxLength = 12;
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.PasswordChar = 'l';
            this.txtConfirmaSenha.Size = new System.Drawing.Size(186, 25);
            this.txtConfirmaSenha.TabIndex = 4;
            this.txtConfirmaSenha.TextChanged += new System.EventHandler(this.txtConfirmaSenha_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(284, 28);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(349, 25);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(47, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // btnChecked
            // 
            this.btnChecked.Enabled = false;
            this.btnChecked.FlatAppearance.BorderSize = 0;
            this.btnChecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChecked.Image = ((System.Drawing.Image)(resources.GetObject("btnChecked.Image")));
            this.btnChecked.Location = new System.Drawing.Point(402, 82);
            this.btnChecked.Name = "btnChecked";
            this.btnChecked.Size = new System.Drawing.Size(35, 35);
            this.btnChecked.TabIndex = 7;
            this.btnChecked.UseVisualStyleBackColor = true;
            this.btnChecked.Visible = false;
            // 
            // btnInvalid
            // 
            this.btnInvalid.Enabled = false;
            this.btnInvalid.FlatAppearance.BorderSize = 0;
            this.btnInvalid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvalid.Image = ((System.Drawing.Image)(resources.GetObject("btnInvalid.Image")));
            this.btnInvalid.Location = new System.Drawing.Point(402, 82);
            this.btnInvalid.Name = "btnInvalid";
            this.btnInvalid.Size = new System.Drawing.Size(35, 35);
            this.btnInvalid.TabIndex = 8;
            this.btnInvalid.UseVisualStyleBackColor = true;
            this.btnInvalid.Visible = false;
            // 
            // lblUsuariosCadastrados
            // 
            this.lblUsuariosCadastrados.AutoSize = true;
            this.lblUsuariosCadastrados.Location = new System.Drawing.Point(14, 138);
            this.lblUsuariosCadastrados.Name = "lblUsuariosCadastrados";
            this.lblUsuariosCadastrados.Size = new System.Drawing.Size(167, 20);
            this.lblUsuariosCadastrados.TabIndex = 9;
            this.lblUsuariosCadastrados.Text = "Usuarios Cadastrados";
            // 
            // cmbUsuariosCadastrados
            // 
            this.cmbUsuariosCadastrados.FormattingEnabled = true;
            this.cmbUsuariosCadastrados.Location = new System.Drawing.Point(18, 161);
            this.cmbUsuariosCadastrados.Name = "cmbUsuariosCadastrados";
            this.cmbUsuariosCadastrados.Size = new System.Drawing.Size(254, 28);
            this.cmbUsuariosCadastrados.TabIndex = 10;
            this.cmbUsuariosCadastrados.Click += new System.EventHandler(this.cmbUsuariosCadastrados_Click);
            // 
            // gpbUsrInfo
            // 
            this.gpbUsrInfo.Controls.Add(this.cmbUsuariosCadastrados);
            this.gpbUsrInfo.Controls.Add(this.lblUsuariosCadastrados);
            this.gpbUsrInfo.Controls.Add(this.btnInvalid);
            this.gpbUsrInfo.Controls.Add(this.btnChecked);
            this.gpbUsrInfo.Controls.Add(this.txtCodigo);
            this.gpbUsrInfo.Controls.Add(this.lblCodigo);
            this.gpbUsrInfo.Controls.Add(this.txtConfirmaSenha);
            this.gpbUsrInfo.Controls.Add(this.lblConfirmarSenha);
            this.gpbUsrInfo.Controls.Add(this.txtSenha);
            this.gpbUsrInfo.Controls.Add(this.lblSenha);
            this.gpbUsrInfo.Controls.Add(this.txtNome);
            this.gpbUsrInfo.Controls.Add(this.lblNome);
            this.gpbUsrInfo.Location = new System.Drawing.Point(12, 12);
            this.gpbUsrInfo.Name = "gpbUsrInfo";
            this.gpbUsrInfo.Size = new System.Drawing.Size(984, 557);
            this.gpbUsrInfo.TabIndex = 0;
            this.gpbUsrInfo.TabStop = false;
            this.gpbUsrInfo.Text = "Informações do Usuário";
            // 
            // frmGerenciarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 641);
            this.Controls.Add(this.pnlCrud);
            this.Controls.Add(this.gpbUsrInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerenciarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPSFrancisco - Gerenciar Usuarios";
            this.pnlCrud.ResumeLayout(false);
            this.gpbUsrInfo.ResumeLayout(false);
            this.gpbUsrInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCrud;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnChecked;
        private System.Windows.Forms.Button btnInvalid;
        private System.Windows.Forms.Label lblUsuariosCadastrados;
        private System.Windows.Forms.ComboBox cmbUsuariosCadastrados;
        private System.Windows.Forms.GroupBox gpbUsrInfo;
    }
}