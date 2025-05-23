﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GPSFrancisco
{
    public partial class frmGerenciarUsuarios : Form
    {
        public frmGerenciarUsuarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        // método construtor com parametro para busca de usuario
        public frmGerenciarUsuarios(string nome)
        {
            InitializeComponent();
            desabilitarCampos();
            txtNome.Text = nome;

            buscarUsuarioExistente(nome);
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

        // Habilita os campos para cadastro de usuarios
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

        // habilita os campos para alterar dados do usuario
        public void habiitarCamposAlteracao()
        {
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtConfirmaSenha.Enabled = true;
            btnNovo.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = false;
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
                    txtSenha.Focus();
                }
                else
                {
                    if (txtSenha.Text.Equals(txtConfirmaSenha.Text))
                    {
                        if (cadastrarUsuario(txtNome.Text, txtSenha.Text) == 1)
                        {
                            MessageBox.Show("Usuário cadastrado com sucesso!",
                                "Mensagem do sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1);
                            desabilitarCamposCadastrar();
                            buscarUsuariosCadastrados();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar!",
                                "Mensagem do sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                            limparCampos();
                        }
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

        private void txtConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmaSenha.Text.Equals(txtSenha.Text) && !txtConfirmaSenha.Text.Equals(""))
            {
                btnChecked.Visible = true;
                btnInvalid.Visible = false;
            }
            else
            {
                btnChecked.Visible = false;
                btnInvalid.Visible = true;
            }
        }

        // método de criação de usuário
        public int cadastrarUsuario(string nome, string senha)
        {
            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "insert into tbUsuarios(nome,senha) value(@nome,@senha);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = nome;

            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 12).Value = senha;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        // Busca todos os usuarios que estão cadastrados no banco
        public void buscarUsuariosCadastrados()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbusuarios order by nome asc;";

            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            
            while (DR.Read())
            {
                cmbUsuariosCadastrados.Items.Add(DR.GetString(0));
            }


            Conexao.fecharConexao();
        }

        private void cmbUsuariosCadastrados_Click(object sender, EventArgs e)
        {
            cmbUsuariosCadastrados.Items.Clear();
            buscarUsuariosCadastrados();
        }

        // busca usuario por meio do código
        //public void buscarUsuarioCod()
        //{
        //    MySqlCommand comm = new MySqlCommand();
        //    comm.CommandText = "select * from tbusuarios where codUsr = @codUsr";
        //    comm.CommandType = CommandType.Text;

        //    comm.Connection = Conexao.obterConexao();

        //    MySqlDataReader DR;
        //    DR = comm.ExecuteReader();
        //    DR.Read();

        //    txtCodigo.Text = DR.GetString(0);
        //    txtNome.Text = DR.GetString(1);
        //    txtSenha.Text = DR.GetString(2);

        //    Conexao.fecharConexao();
        //}

        // busca usuario pesquisado e existente
        public void buscarUsuarioExistente(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbusuarios where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = nome;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            txtNome.Text = DR.GetString(1);
            txtSenha.Text = DR.GetString(2);

            Conexao.fecharConexao();

            habiitarCamposAlteracao();
        }

        // Alterar os dados do usuario do usuario
        public int alterarDadosDoUsuario(string nome, string senha, int codUsr)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbusuarios set nome = @nome, senha = @senha where codUsr = " + codUsr + ";";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = nome;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 12).Value = senha;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        // excluir usuario
        public int excluirUsuario(int codUsr)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbusuarios where codUsr = @codUsr";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codUsr", MySqlDbType.Int32).Value = codUsr;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();
            desabilitarCampos();
            limparCampos();

            return resp;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarUsuarios abrir = new frmPesquisarUsuarios();
            abrir.Show();
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja excluir o usuário?",
                "Mensagem do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (resp == DialogResult.Yes)
            {
                if (excluirUsuario(Convert.ToInt32(txtCodigo.Text)) == 1)
                {
                    MessageBox.Show("Usuário excluído do sistema!",
                        "Mensagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Erro ao excluir usuário!",
                        "Mensagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (alterarDadosDoUsuario(txtNome.Text, txtSenha.Text, Convert.ToInt32(txtCodigo.Text)) == 1)
            {
                MessageBox.Show("Dados do usuário alterados com sucesso!",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                desabilitarCampos();
                limparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao alterar os dados do usuário!",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
            }
        }
    }
}
