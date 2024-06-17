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
    public partial class frmOS : Form
    {
        public frmOS()
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

        private void frmOS_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarOS();
        }
        private void CarregarOS()
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
            string sql = "delete from os where id_os =" + txtCodigo.Text;

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
            txtCodigo.Text = "";
            txtDATA.Text = "";
            txtObs.Text = "";
            txtqtde.Text = "";
            cboIDproduto.Text = "";
            cboStatus.SelectedIndex = -1;
        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update os set" +
             "ID_Produto_os='" + cboIDproduto.Text + "'," +
             "qtde_os'" + txtqtde.Text + "',"+
             "obs_os='" + txtObs.Text + "'," +
             "status_os='" + cboStatus.Text + "' " +
             "where id_os='" + txtCodigo.Text;

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

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            if (cboIDproduto.Text == "" || txtqtde.Text == "")
            {
                MessageBox.Show("Erro, os dados precisam ser inseridos corretamente!");
            }
            string sql = "insert into os " +
                "(ID_Produto_os,qtde_os,obs_os,status_os)" +
                "values" +
                "(" + "'" + cboIDproduto.Text + "'" + "," + "'" + txtqtde.Text + "'" + ","
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
