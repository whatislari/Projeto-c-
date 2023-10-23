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
            txtComplementoforn.Text = "";
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
            if (txtBairroforn.Text == "" || txtcepforn.Text == "" || txtCidadeforn.Text == "" || txtComplementoforn.Text == "" || txtcontatoforn.Text == ""
                || txtCNPJforn.Text == "" || txtEntradaforn.Text == "" || txtendereçoforn.Text == "" || txtNforn.Text == ""
                || txtNomeforn.Text == "" || txtObsforn.Text == "" || txttel1forn.Text == "" || txttel2forn.Text == "" || cboUFforn.Text == "")
            {
                MessageBox.Show("Erro, os dados precisam ser inseridos corretamente!");
            }
            string sql = "insert into fornecedor (nome_fornecedor,entrada_fornecedor,cnpj_fornecedor,logradouro_fornecedor,numero_fornecedor," +
                         "cep_fornecedor,bairro_fornecedor,cidade_fornecedor,uf_fornecedor,telefone1_fornecedor, " +
                         "telefone2_fornecedor,contato_fornecedor,obs_fornecedor)" +
                         "values" +
                         "(" + "'" + txtNomeforn.Text + "'" + "," + "" + txtEntradaforn.Text + "" + "," + "" + txtCNPJforn.Text + "" + "," + "'" + txtendereçoforn.Text + "'" + ","
                         + "" + txtNforn.Text + "" + "," + "'" + txtComplementoforn.Text + "'" + "," + "" + txtcepforn.Text + "" + "," + "'" + txtBairroforn.Text + "'" + "," + "'" + txtCidadeforn.Text +
                         "'" + "," + "'" + cboUFforn.Text + "'" + "," + "" + txttel1forn.Text + "" + "," + "" + txttel2forn.Text + "" + "," + "" + txtcontatoforn.Text + "" +
                         "," + "'" + txtObsforn.Text + "'" + ")" + "select SCOPE_IDENTITY()";

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

    }

}

    
