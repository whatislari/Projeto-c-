using System.Data;
using System.Data.SqlClient;

namespace Miniprojetinho
{
    public partial class frmusuario : Form
    {
        string stringConexao = ""+
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
        public frmusuario()
        {
            InitializeComponent();
        }
            
        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtLogin.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            txtObs.Text = "";
            cboStatus.SelectedIndex = -1;           
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Erro, os dados precisam ser inseridos corretamente!");
            }
            string sql = "insert into usuario " +
                "(nome_usuario,login_usuario,senha_usuario,obs_usuario)" +
                "values" +
                "(" + "'" + txtNome.Text + "'" + "," + "'" + txtLogin.Text + "'" + ","
                + "'" + txtSenha.Text + "'" + "," + "'" + txtObs.Text + "'" + ")" +
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

                    btoCodigo.PerformClick();
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

            txtCodigo.Text = "";
            txtLogin.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            txtObs.Text = "";
            cboStatus.SelectedIndex = -1;
        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from usuario where id_usuario =" + txtCodigo.Text;

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

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update usuario set" +
                 "nome_usuario='" + txtNome.Text + "',"+
                 "login_usuario='" + txtLogin.Text + "'," +
                 "senha_usuario='" + txtSenha.Text + "'," +
                 "obs_usuario='" + txtObs.Text +"'," +
                 "status_usuario='" + cboStatus.Text +"' " +
                 "where id_usuario='" + txtCodigo.Text;

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

        private void btoCodigo_Click(object sender, EventArgs e)
        {
            string sql = "Select from * usuario where id_usuario " + txtCodigo.Text;

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
                    txtNome.Text = leitura[1].ToString();
                    txtLogin.Text = leitura[2].ToString();
                    txtSenha.Text = leitura[3].ToString();
                    txtDATA.Text = leitura[4].ToString();
                    txtObs.Text=leitura[5].ToString();
                    cboStatus.Text = leitura[6].ToString();
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
    }
}