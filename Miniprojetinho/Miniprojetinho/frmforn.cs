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
    public partial class frmforn : Form
    {
        public frmforn()
        {
            InitializeComponent();
        }

        private void btoSairforn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoLimparforn_Click(object sender, EventArgs e)
        {
            txtBairroforn.Text = "";
            txtCidadeforn.Text = "";

            txtCNPJforn.Text = "";
            txtEntradaforn.Text = "";
            txtendereçoforn.Text = "";
            txtNforn.Text = "";
            cboUFforn.Text = "";
            txtNomeforn.Text = "";
            txtObsforn.Text = "";
            txtcepforn.Text = "";
            txttel1forn.Text = "";
            txttel2forn.Text = "";
            txtcontatoforn.Text = "";
            txtpesquisaforn.Focus();
        }
        string stringConexao = "" +
        "Data Source=localhost;" +
        "Initial Catalog=t14_estoque;" +
        "User ID=sa;" +
        "Password=123456";

        private void TestarConexao()
        {
            SqlConnection conexao = new SqlConnection(stringConexao);

            try
            {
                conexao.Open();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
        }

        private void frmforn_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private void btoCadastrarforn_Click(object sender, EventArgs e)
        {
            if (txtBairroforn.Text == "" || txtcepforn.Text == "" || txtCidadeforn.Text == "" || 
                txtcontatoforn.Text == "" || txtCNPJforn.Text == "" || txtEntradaforn.Text == "" ||
                txtendereçoforn.Text == "" || txtNforn.Text == "" ||
                txtNomeforn.Text == "" || txttel1forn.Text == "" || txttel2forn.Text == "" || cboUFforn.Text == "")
            {
                MessageBox.Show("Erro, os dados precisam ser inseridos corretamente!");
                return;
            }
            string sql = "insert into fornecedor (nome_fornecedor,entrada_fornecedor,cnpj_fornecedor," +
              "logradouro_fornecedor,numero_fornecedor," +
              "cep_fornecedor,bairro_fornecedor,cidade_fornecedor,uf_fornecedor,telefone1_fornecedor," +
              "telefone2_fornecedor,contato_fornecedor,obs_fornecedor,status_fornecedor)" +

              "values" +

              "('" + txtNomeforn.Text + "','" + txtEntradaforn.Text + "','" + txtCNPJforn.Text + "','" + txtendereçoforn.Text + "'," +
              "'" + txtNforn.Text + "','" + txtcepforn.Text + "','" + txtBairroforn.Text + "','" + txtCidadeforn.Text + "'," +
              "'" + cboUFforn.Text + "','" + txttel1forn.Text + "','" + txttel2forn.Text + "','" + txtcontatoforn.Text + "'," +
              "'" + cboStatusforn.Text + "','" + txtObsforn.Text + "')" +
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
                    btoLimparforn.PerformClick();

                    txtpesquisaforn.Text = leitura[0].ToString();

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

        private void btoAlterarforn_Click(object sender, EventArgs e)
        {
            string sql = "update fornecedor set " +
                            "nome_fornecedor = '" + txtNomeforn.Text + "'," +
                            "entrada_fornecedor='" + txtEntradaforn.Text + "'," +
                            "cnpj_fornecedor='" + txtCNPJforn.Text + "'," +
                            "logradouro_fornecedor='" + txtendereçoforn.Text + "'," +
                            "numero_fornecedor='" + txtNforn.Text + "'," +
                            "cep_fornecedor='" + txtcepforn.Text + "'," +
                            "bairro_fornecedor='" + txtBairroforn.Text + "'," +
                            "cidade_fornecedor ='" + txtCidadeforn.Text + "'," +
                            "uf_fornecedor='" + cboUFforn.Text + "'," +
                            "telefone1_fornecedor='" + txttel1forn.Text + "'," +
                            "telefone2_fornecedor='" + txttel2forn.Text + "'," +
                            "contato_fornecedor='" + txtcontatoforn.Text + "'," +
                            "obs_fornecedor='" + txtObsforn.Text + "'," +
                            "status_fornecedor='" + cboStatusforn.Text + "'" +
                            "where ID_fornecedor =" + txtpesquisaforn.Text;


            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;

            conexao.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Dados alterados com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro, não foi possível alterar os dados");
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

        private void btopesquisa_Click(object sender, EventArgs e)
        {
            string sql = "select * from fornecedor where ID_fornecedor=" + txtpesquisaforn.Text;

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
                    txtpesquisaforn.Text = leitura[0].ToString();
                    txtNomeforn.Text = leitura[1].ToString();
                    txtEntradaforn.Text = leitura[2].ToString();
                    txtDataforn.Text = leitura[3].ToString();
                    txtCNPJforn.Text = leitura[4].ToString();
                    txtendereçoforn.Text = leitura[5].ToString();
                    txtNforn.Text = leitura[6].ToString();
                    txtcepforn.Text = leitura[7].ToString();
                    txtBairroforn.Text = leitura[8].ToString();
                    txtCidadeforn.Text = leitura[9].ToString();
                    cboUFforn.Text = leitura[10].ToString();
                    txttel1forn.Text = leitura[11].ToString();
                    txttel2forn.Text = leitura[12].ToString();
                    txtcontatoforn.Text = leitura[13].ToString();
                    txtObsforn.Text = leitura[14].ToString();
                    cboStatusforn.Text = leitura[15].ToString();
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

        private void btoExcluirforn_Click(object sender, EventArgs e)
        {
            string sql = "delete from fornecedor where ID_fornecedor = " + txtpesquisaforn.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;

            conexao.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Dados excluidos com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro, não foi possível excluir o dado");
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

    
