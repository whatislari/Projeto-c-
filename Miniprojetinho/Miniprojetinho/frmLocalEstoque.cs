﻿using System;
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
    public partial class frmLocalEstoque : Form
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
        private void btoSair_Click(object sender, EventArgs e)
        {
           this.Close();
        }

         public frmLocalEstoque()
         {
            InitializeComponent();

         }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtnomeloc.Text = "";
            cboStatus.SelectedIndex = -1;
            txtobsloc.Text = "";
        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from LocalEstoque where id_LocalEstoque =" + txtCodigo.Text;

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
            string sql = "update LocalEstoque set" +
             "nome_LocalEstoque='" + txtnomeloc.Text + "'," +
             "obs_LocalEstoque='" + txtobsloc.Text + "'," +
             "status_LocalEstoque='" + cboStatus.Text + "' " +
             "where id_LocalEstoque='" + txtCodigo.Text;

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
            if (txtnomeloc.Text == "")
            {
                MessageBox.Show("Erro, os dados precisam ser inseridos corretamente!");
            }

            string sql = "insert into LocalEstoque " +
                "(nome_LocalEstoque,obs_LocalEstoque,status_LocalEstoque)" +
                "values" +
                "(" + "'" + txtnomeloc.Text + "'" + "," + "'" + txtobsloc.Text + "'" + ","
                +"'" + cboStatus.Text + "'" + ")" +
                " select SCOPE_IDENTITY()";

            //('xxx','yyy','zzz')   "(" + "'" + xxx.text + "'" ","+ "'" + yyy.text + "'" ","+ zzz.text + "'" + ")"


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
            string sql = "select * from LocalEstoque where id_LocalEstoque =" + txtCodigo.Text;

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
                    txtnomeloc.Text = leitura[0].ToString();
                    txtobsloc.Text = leitura[1].ToString();
                    cboStatus.Text = leitura[2].ToString();
                    txtCodigo.Text = leitura[3].ToString();
                }
                else
                {
                    MessageBox.Show("Codigo de Estoque inexistente!");
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
