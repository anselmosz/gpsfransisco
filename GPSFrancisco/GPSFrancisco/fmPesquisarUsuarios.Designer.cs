namespace GPSFrancisco
{
    partial class frmPesquisarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarUsuarios));
            this.gpbPesquisarPor = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.rdNome = new System.Windows.Forms.RadioButton();
            this.rdCodigo = new System.Windows.Forms.RadioButton();
            this.ltbPesquisar = new System.Windows.Forms.ListBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbPesquisarPor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPesquisarPor
            // 
            this.gpbPesquisarPor.Controls.Add(this.txtDescricao);
            this.gpbPesquisarPor.Controls.Add(this.lblDescricao);
            this.gpbPesquisarPor.Controls.Add(this.rdNome);
            this.gpbPesquisarPor.Controls.Add(this.rdCodigo);
            this.gpbPesquisarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarPor.Location = new System.Drawing.Point(13, 14);
            this.gpbPesquisarPor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbPesquisarPor.Name = "gpbPesquisarPor";
            this.gpbPesquisarPor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbPesquisarPor.Size = new System.Drawing.Size(551, 101);
            this.gpbPesquisarPor.TabIndex = 0;
            this.gpbPesquisarPor.TabStop = false;
            this.gpbPesquisarPor.Text = "Pesquisar por";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(112, 63);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(297, 26);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(24, 66);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // rdNome
            // 
            this.rdNome.AutoSize = true;
            this.rdNome.Location = new System.Drawing.Point(197, 29);
            this.rdNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdNome.Name = "rdNome";
            this.rdNome.Size = new System.Drawing.Size(69, 24);
            this.rdNome.TabIndex = 2;
            this.rdNome.Text = "Nome";
            this.rdNome.UseVisualStyleBackColor = true;
            this.rdNome.CheckedChanged += new System.EventHandler(this.rdNome_CheckedChanged);
            // 
            // rdCodigo
            // 
            this.rdCodigo.AutoSize = true;
            this.rdCodigo.Location = new System.Drawing.Point(112, 29);
            this.rdCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdCodigo.Name = "rdCodigo";
            this.rdCodigo.Size = new System.Drawing.Size(77, 24);
            this.rdCodigo.TabIndex = 1;
            this.rdCodigo.Text = "Código";
            this.rdCodigo.UseVisualStyleBackColor = true;
            this.rdCodigo.CheckedChanged += new System.EventHandler(this.rdCodigo_CheckedChanged);
            // 
            // ltbPesquisar
            // 
            this.ltbPesquisar.FormattingEnabled = true;
            this.ltbPesquisar.ItemHeight = 20;
            this.ltbPesquisar.Location = new System.Drawing.Point(13, 136);
            this.ltbPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltbPesquisar.Name = "ltbPesquisar";
            this.ltbPesquisar.Size = new System.Drawing.Size(407, 184);
            this.ltbPesquisar.TabIndex = 6;
            this.ltbPesquisar.SelectedIndexChanged += new System.EventHandler(this.ltbPesquisar_SelectedIndexChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(427, 136);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(137, 56);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(427, 200);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(137, 56);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(427, 264);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(137, 56);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPesquisarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 334);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.ltbPesquisar);
            this.Controls.Add(this.gpbPesquisarPor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPesquisarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPSFrancisco - Pesquiar Usuários";
            this.gpbPesquisarPor.ResumeLayout(false);
            this.gpbPesquisarPor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisarPor;
        private System.Windows.Forms.RadioButton rdNome;
        private System.Windows.Forms.RadioButton rdCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ListBox ltbPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}