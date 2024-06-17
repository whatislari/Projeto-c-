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
    public partial class frmmovi : Form
    {
        public frmmovi()
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
        private void frmmovi_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarProduto();
            CarregarFuncionario();
        }
        private void CarregarProduto()
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
        private void CarregarFuncionario()
        {
            string sql = "select ID_Funcionario, nome_Funcionario from Funcionario";

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

                cboIDfuncionario.DisplayMember = "ID_Funcionario";
                cboIDfuncionario.DataSource = tabela;

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
            string sql = "delete from movimentação where id_mov = " + txtCodigo.Text;

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
            cboIDfuncionario.Text = "";
            cboqtde.Text = "";
            cbotipo.Text = "";
            txtCodigo.Text = "";
            txtObs.Text = "";
            txtDATA.Text = "";
            cboStatus.SelectedIndex = -1;
        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update movimentação set" +
                     "ID_Produto_mov='" + cboIDproduto.Text + "'," +
                     "id_funcionario_mov='" + cboIDfuncionario.Text + "'," +
                     "qtde_mov='" + cboqtde.Text + "'," +
                     "obs_mov='" + txtObs.Text + "'," +
                     "status_mov='" + cboStatus.Text + "' " +
                     "where id_mov='" + txtCodigo.Text;

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
            string sql = "Select * from movimentação where id_mov " + txtCodigo.Text;

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
                    cboIDfuncionario.Text = leitura[2].ToString();
                    cboqtde.Text = leitura[3].ToString();
                    txtDATA.Text = leitura[4].ToString();
                    cbotipo.Text = leitura[5].ToString();
                    txtObs.Text = leitura[6].ToString();
                    cboStatus.Text = leitura[7].ToString();
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
            if (cboIDproduto.Text == "" || cboIDfuncionario.Text == "" || cbotipo.Text == ""||cboqtde.Text == "" )
            {
                MessageBox.Show("Erro, os dados precisam ser inseridos corretamente!");
            }
            string sql = "insert into movimentação " +
                "(ID_Produto_mov,id_funcionario_mov,tipo_mov,qtde_mov,obs_mov,status_mov)" +
                "values" +
                "(" + "'" + cboIDproduto.Text + "'" + "," + "'" + cboIDfuncionario.Text + "'" + 
                "," + "'" + cbotipo.Text + "'" + "," + "'" + cboqtde.Text + "'" + "," + "'" + txtObs.Text + "'" +
                "," + "'" + cboStatus.Text + "'" + ")" +
                " select SCOPE_IDENTITY()";

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
