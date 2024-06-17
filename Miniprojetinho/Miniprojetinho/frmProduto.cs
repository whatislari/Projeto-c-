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
    public partial class frmProduto : Form
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
        public frmProduto()
        {
            InitializeComponent();
        }

        private void btoSairpro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoLimparpro_Click(object sender, EventArgs e)
        {
            txtCodigopro.Text = "";
            txtNomepro.Text = "";
            txtVcusto.Text = "";
            txtVvenda.Text = "";
            txtObs.Text = "";
            cboStatuspro.SelectedIndex = -1;
        }
        private void btoCadastrarpro_Click(object sender, EventArgs e)
        {
            string Vcusto = txtVcusto.Text;
            Vcusto = Vcusto.Replace("R$", "");
            Vcusto = Vcusto.Replace(",", ".");
            string Vvenda = txtVvenda.Text;
            Vvenda = Vvenda.Replace("R$", "");
            Vvenda = Vvenda.Replace(",", ".");

            string sql = "insert into Produto" +
             "(nome_Produto,qtde_Produto,Vcusto_Produto,Vvenda_Produto,obs_Produto)" +
             "values" +
              "('" + txtNomepro.Text + "'," + txtqtde.Text + "," + Vcusto + "," + Vvenda + ",'" + txtObs.Text + "')" +
              "Select Scope_identity()";

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

                    txtCodigopro.Text = leitura[0].ToString();

                    MessageBox.Show("Cadastro realizado com sucesso");

                    btopesquisa.PerformClick();
                    btoLimparpro.PerformClick();
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
                txtCodigopro.Text = "";
                txtNomepro.Text = "";
                txtVcusto.Text = "";
                txtVvenda.Text = "";
                txtObs.Text = "";
                txtDATApro.Text = "";
                cboStatuspro.SelectedIndex = -1;
        }
        private void btoAlterarpro_Click(object sender, EventArgs e)
        {
            string sql = "update Produto set" +
                 "nome_Produto ='" + txtNomepro.Text + "'," +
                 "qtde_Produto =" + txtqtde.Text + "," +
                 "Vcusto_Produto =" +txtVcusto.Text + "," +
                 "Vvenda_Produto =" + txtVvenda.Text + "," +
                 "obs_Produto ='" + txtObs.Text + "' " +
                 "status_Produto ='" + cboStatuspro + "' " +
                 "where ID_Produto =" + txtCodigopro.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = System.Data.CommandType.Text;
            conexao.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i == 1)

                MessageBox.Show("Dados alterados com sucesso!");
                btopesquisa.PerformClick();
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

        private void btoExcluirpro_Click(object sender, EventArgs e)
        {
            string sql = "delete from Produto where ID_Produto =" +txtCodigopro.Text ;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = System.Data.CommandType.Text;
            conexao.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Dados excluidos com sucesso");
                    btoLimparpro.PerformClick();
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

        private void btopesquisa_Click(object sender, EventArgs e)
        {
            string sql = "select * from Produto where ID_Produto =" + txtCodigopro.Text;

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
                    txtCodigopro.Text = leitura[0].ToString();
                    txtNomepro.Text = leitura[1].ToString();
                    txtDATApro.Text = leitura[2].ToString();
                    txtObs.Text = leitura[3].ToString();
                    txtVcusto.Text =(decimal.Parse(leitura[4].ToString())).ToString("C");
                    txtVvenda.Text =(decimal.Parse(leitura[5].ToString())).ToString("C");
                    txtqtde.Text= leitura[6].ToString();
                }
                else
                {
                    MessageBox.Show("Codigo de produto inexistente!");
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

        private void txtVcusto_Leave(object sender, EventArgs e)
        {
            float valor;

            if (float.TryParse(txtVcusto.Text, out valor))
            {
                txtVcusto.Text = valor.ToString("C");
            }
            else
            {
                txtVcusto.Text = "";
            }
            txtVcusto.Text = txtVcusto.Text.Replace("R$", "");
        

        }

        private void txtVvenda_Enter(object sender, EventArgs e)
        {
            float valor;

            if (float.TryParse(txtVvenda.Text, out valor))
            {
                txtVvenda.Text = valor.ToString("C");
            }
            else
            {
                txtVvenda.Text = "";
            }
            txtVvenda.Text = txtVvenda.Text.Replace("R$", "");
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
