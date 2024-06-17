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
    public partial class frmItemEstoque : Form
    {
        public frmItemEstoque()
        {
            InitializeComponent();
        }
        string stringConexao = MDITelas.stringConexao;

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
        private void frmItemEstoque_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarItemEstoque();
        }

        private void CarregarItemEstoque()
        {
            string sql = "select id_produto, nome_produto from produto";

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;

            DataTable tabela = new DataTable();

            conexao.Open();

            try
            {
                leitura = cmd.ExecuteReader();

                tabela.Load(leitura);

                cboIDproduto.DisplayMember = "id_produto";
                cboIDproduto.DataSource = tabela;

                cbolocalestoque.DisplayMember = "id_LocalEstoque";
                cbolocalestoque.DataSource = tabela;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }

        }     

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from itemestoque where id_itemestoque =" + txtCodigo.Text;

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

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            cboIDproduto.Text = "";
            cbolocalestoque.Text = "";
            txtCodigo.Text = "";
            txtObs.Text = "";
            txtDATA.Text = "";
            cboStatus.SelectedIndex = -1;
        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update itemestoque set" +
             "ID_Produto_ItemEstoque='" + cboIDproduto.Text + "'," +
             "id_localEstoque_ItemEstoque='" + cbolocalestoque.Text + "'," +
             "obs_ItemEstoque='" + txtObs.Text + "'," +
             "status_ItemEstoque='" + cboStatus.Text + "' " +
             "where id_ItemEstoque='" + txtCodigo.Text;

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

        private void btopesquisar_Click(object sender, EventArgs e)
        {
            string sql = "Select from * itemestoque where id_itemestoque " + txtCodigo.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader leitura;


            conexao.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    txtCodigo.Text = leitura[0].ToString();
                    cboIDproduto.Text = leitura[1].ToString();
                    cbolocalestoque.Text = leitura[2].ToString();
                    txtDATA.Text = leitura[3].ToString();
                    txtObs.Text = leitura[4].ToString();
                    cboStatus.Text = leitura[5].ToString();
                }
                else
                {
                    MessageBox.Show("Codigo de usuario inexistente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            if (cboIDproduto.Text == "" || cbolocalestoque.Text == "")
            {
                MessageBox.Show("Erro, os dados precisam ser inseridos corretamente!");
            }
            string sql = "insert into itemestoque " +
                "(ID_Produto_ItemEstoque,id_localEstoque_ItemEstoque,obs_ItemEstoque,status_ItemEstoque)" +
                "values" +
                "(" + "'" + cboIDproduto.Text + "'" + "," + "'" + cbolocalestoque.Text + "'" + ","
                + "'" + txtObs.Text + "'" + "," + "'" + cboStatus.Text + "'" + ")" +
                " select SCOPE_IDENTITY()";

            //('xxx','yyy','zzz')   "(" + "'" + xxx.text + "'" ","+ "'" + yyy.text + "'" ","+ zzz.text + "'" + ")"


            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;


            conexao.Open();

            try
            {
                //int i = cmd.ExecuteNonQuery();
                //if (i == 1)
                //{
                // MessageBox.Show("Cadastro realizado com sucesso!");
                // }

                leitura = cmd.ExecuteReader();

                if (leitura.Read())
                {
                    btoLimpar.PerformClick();

                    txtCodigo.Text = leitura[0].ToString();
                    MessageBox.Show("Cadastro realizado com sucesso");

                    btopesquisar.PerformClick();
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
    }
}
