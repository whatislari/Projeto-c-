using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Miniprojetinho
{
    public partial class frmfuncio : Form
    {
        string stringConexao = "" +
        "Data Source = localhost ;" +
        "Initial Catalog=T14_Estoque;" +
        "User ID=sa;" +
        "Password=123456";

        private void TestarConexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
                Application.Exit();
            }

        }
        public frmfuncio()
        {
            InitializeComponent();
        }

        private void btoLimparfun_Click(object sender, EventArgs e)
        {
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtComplemento.Text = "";
            txtcpf.Text = "";
            txtDatanasc.Text = "";
            txtLogradouro.Text = "";
            txtN.Text = "";
            cboUF.Text = "";
            txtNomefun.Text = "";
            txtObs.Text = "";
            txtDatafun.Text = "";
            txtcep.Text = "";
            txttel1.Text = "";
            txttel2.Text = "";
            txttel3.Text = "";
            txtpesquisafun.Focus();

        }
        private void frmfuncio_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private void btoSairfun_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoExcluirfun_Click(object sender, EventArgs e)
        {
            string sql = "delete from Funcionario where id_Funcionario =" + txtpesquisafun.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = System.Data.CommandType.Text;


            conexao.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Dados excuidos com sucesso!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro," + ex.ToString());
            }

            finally
            {
                conexao.Close();
            }
        }

        private void btoAlterarfun_Click(object sender, EventArgs e)
        {
            string sql = "update Funcionario set" +
            "nome_Funcionario='" + txtNomefun.Text + "'," +
            "nasc_Funcionario='" + txtDatanasc.Text + "'," +
            "cpf_Funcionario='" + txtcpf.Text + "'," +
            "logradouro_Funcionario='" + txtLogradouro.Text + "'," +
            "numero_Funcionario='" + txtN.Text + "'," +
            "comp_funcionario='" + txtComplemento.Text + "'," +
            "cep_Funcionario='" + txtcep.Text + "'," +
            "bairro_Funcionario='" + txtBairro.Text + "'," +
            "cidade_Funcionario='" + txtCidade.Text +
            "uf_Funcionario='" + cboUF.Text + "'," +
            "telefone1_Funcionario='" + txttel1.Text + "'," +
            "telefone2_Funcionario='" + txttel2.Text + "'," +
            "telefone3_Funcionario='" + txttel3.Text + "'," +
            "obs_Funcionario='" + txtObs.Text + "'," +
            "status_Funcionario='" + cboStatusfun.Text + "' " +
            "where ID_Funcionario=" + txtpesquisafun.Text;


            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = System.Data.CommandType.Text;

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Cadastro excluido com sucesso!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro," + ex.ToString());
            }

            finally
            {
                conexao.Close();
            }
        }

        private void btoCadastrarfun_Click(object sender, EventArgs e)
        {
            if (txtBairro.Text == "" || txtcep.Text == "" || txtCidade.Text == "" || txtComplemento.Text == ""
                || txtcpf.Text == "" || txtDatanasc.Text == "" || txtLogradouro.Text == "" || txtN.Text == ""
                || txtNomefun.Text == "" || txtObs.Text == "" || txttel1.Text == "" ) 
            {
                MessageBox.Show("Erro, os dados precisam ser inseridos corretamente!");
            }
            string sql = "insert into Funcionario (nome_funcionario,nasc_funcionario,cpf_funcionario,logradouro_funcionario," +
                "numero_funcionario,comp_funcionario, cep_funcionario, bairro_funcionario,cidade_funcionario, uf_funcionario," +
                "telefone1_funcionario, telefone2_funcionario,telefone3_funcionario,obs_funcionario, status_funcionario)" +
                "values" +
                "('" + txtNomefun.Text + "','" + txtDatanasc.Text + "','" + txtcpf.Text + "','" + txtLogradouro.Text + "'," +
                "'" + txtN.Text + "','" + txtComplemento.Text + "','" + txtcep.Text + "','" + txtBairro.Text + "','" + txtCidade.Text + "'," +
                "'" + cboUF.Text + "','" + txttel1.Text + "','" + txttel2.Text + "'" + "','" + txttel3.Text + "'," +
                "'" + txtObs.Text + "','" + cboStatusfun.Text + "'" + ")" +
                "select SCOPE_IDENTITY()";


            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;

            conexao.Open();

            try
            {
                leitura = cmd.ExecuteReader();

                if (leitura.Read())
                {
                    btoLimparfun.PerformClick();

                    txtpesquisafun.Text = leitura[0].ToString();
                    MessageBox.Show("Cadastro realizado com sucesso");

                    btopesquisa.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro," + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }

        }

        private void btopesquisa_Click(object sender, EventArgs e)
        {
            string sql = "select * from Funcionario where ID_Funcionario=" + txtpesquisafun.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conexao.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    txtpesquisafun.Text = leitura[0].ToString();
                    txtNomefun.Text = leitura[1].ToString();
                    txtDatanasc.Text = leitura[2].ToString();
                    txtcpf.Text = leitura[3].ToString();
                    txtLogradouro.Text = leitura[4].ToString();
                    txtN.Text = leitura[5].ToString();
                    txtComplemento.Text = leitura[6].ToString();
                    txtcep.Text = leitura[7].ToString();
                    txtBairro.Text = leitura[8].ToString();
                    txtCidade.Text = leitura[9].ToString();
                    cboUF.Text = leitura[10].ToString();
                    txttel1.Text = leitura[11].ToString();
                    txttel2.Text = leitura[12].ToString();
                    txtObs.Text = leitura[13].ToString();
                    cboStatusfun.Text = leitura[14].ToString();                                      
                }
                else
                {
                    MessageBox.Show("Erro, código não encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

 
    }
}
