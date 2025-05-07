using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFrancisco
{
    public partial class frmGerenciarUsuarios : Form
    {
        public frmGerenciarUsuarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtConfirmaSenha.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        public void habiitarCampos()
        {
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtConfirmaSenha.Enabled = true;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
            txtNome.Focus();
        }

        public void desabilitarCamposCadastrar()
        {
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtConfirmaSenha.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = true;
            txtNome.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();
        }

        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();
            txtNome.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abir = new frmMenuPrincipal();
            abir.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habiitarCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtSenha.Text.Equals("") || txtConfirmaSenha.Text.Equals("")) 
            {
                MessageBox.Show("Favor inserir valores!",
                    "Mensagem do sistema", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, 
                    MessageBoxDefaultButton.Button1);
                limparCampos();
            }
            else
            {
                if (txtSenha.Text.Length < 8 || txtConfirmaSenha.Text.Length < 8)
                {
                    MessageBox.Show("A senha deve ter entre 8 e 12 caracteres!",
                        "Mensagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (txtSenha.Text.Equals(txtConfirmaSenha.Text))
                    {
                        MessageBox.Show("Usuário cadastrado com sucesso!",
                            "Mensagem do sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                        desabilitarCamposCadastrar();
                    }
                    else
                    {
                        MessageBox.Show("As senhas não correspondem!",
                            "Mensagem do sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
                        txtSenha.Clear();
                        txtConfirmaSenha.Clear();
                        txtSenha.Focus();
                    }
                }
            }
        }


    }
}
