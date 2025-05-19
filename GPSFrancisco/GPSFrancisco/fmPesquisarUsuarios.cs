using System;
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
    public partial class frmPesquisarUsuarios : Form
    {
        public frmPesquisarUsuarios()
        {
            InitializeComponent();
        }
        
        public void limparCampos()
        {
            txtDescricao.Clear();
            ltbPesquisar.Items.Clear();
            rdCodigo.Checked = false;
            rdNome.Checked = false;
            txtDescricao.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        // Pesquisa por Código
        public int pesquisarPorCodigo(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where codUsr = @codUsr;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@codUsr", MySqlDbType.Int32).Value = codigo;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();  
            DR.Read();

            ltbPesquisar.Items.Add(DR.GetString(1));

            Conexao.fecharConexao();

            return codigo;
        }

        // Pesquisa por Nome
        public string pesquisarPorNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where nome like '%" + nome + "%';";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            while (DR.Read())
            {
                ltbPesquisar.Items.Add(DR.GetString(1));
            }

            Conexao.fecharConexao();

            return nome;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmGerenciarUsuarios abir = new frmGerenciarUsuarios();
            abir.Show();
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdCodigo.Checked || rdNome.Checked)
            {
                if (rdCodigo.Checked && !txtDescricao.Text.Equals(""))
                {
                    try
                    {
                        txtDescricao.Focus();
                        pesquisarPorCodigo(Convert.ToInt32(txtDescricao.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Favor inserir somente valores inteiros",
                        "Mensagem do sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                        txtDescricao.Clear();
                        txtDescricao.Focus();
                    }
                }
                else if (rdNome.Checked && !txtDescricao.Text.Equals(""))
                {
                    try
                    {
                        txtDescricao.Focus();
                        pesquisarPorNome(txtDescricao.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Favor inserir um nome válido!",
                        "Mensagem do sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                        txtDescricao.Clear();
                        txtDescricao.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("O campo Descrição não pode estar vazio!",
                        "Mensagem do sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    txtDescricao.Focus();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma opção de busca!",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void rdCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Focus();
        }

        private void rdNome_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Focus();
        }

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = ltbPesquisar.SelectedItem.ToString();

            frmGerenciarUsuarios abrir = new frmGerenciarUsuarios(nome);
            abrir.Show();
            this.Hide();
        }
    }
}
