using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace rocketpowers.View
{
    public partial class Form3 : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection(" Server = localhost; Database = estoque; Uid = root; Pwd = ;");

                strSQL = "INSERT INTO produtos(Nome, Categoria, Estoque, Marca, Preco) values (@Nome,@Categoria,@Estoque, @Marca, @Preco)";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@Nome", txtname.Text);
                comando.Parameters.AddWithValue("@Categoria", txtcategory.Text);
                comando.Parameters.AddWithValue("@Estoque", txtstock.Text);
                comando.Parameters.AddWithValue("@Marca", txtbrand.Text);
                comando.Parameters.AddWithValue("@Preco", txtprice.Text);


                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);

                MessageBox.Show("register cadaster sucess", "waiting loading", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            try
            {
                //Server = myServerAddress; Database = myDataBase; Uid = myUsername; Pwd = myPassword
                conexao = new MySqlConnection(" Server = localhost; Database = estoque; Uid = root; Pwd = ;");

                strSQL = "SELECT * FROM produtos WHERE ID =@id";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@id", txtid.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtname.Text = Convert.ToString(dr["Nome"]);
                    txtcategory.Text = Convert.ToString(dr["Categoria"]);
                    txtstock.Text = Convert.ToString(dr["Estoque"]);
                    txtbrand.Text = Convert.ToString(dr["Marca"]);
                    txtprice.Text = Convert.ToString(dr["Preco"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Server = myServerAddress; Database = myDataBase; Uid = myUsername; Pwd = myPassword
                conexao = new MySqlConnection(" Server = localhost; Database = estoque; Uid = root; Pwd = ;");

                strSQL = "DELETE FROM produtos WHERE ID =@id";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@id", txtid.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {

            try
            {
                //Server = myServerAddress; Database = myDataBase; Uid = myUsername; Pwd = myPassword
                conexao = new MySqlConnection(" Server = localhost; Database = estoque; Uid = root; Pwd = ;");

                strSQL = "SELECT * FROM produtos";
                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                datagrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

       

        private void txtclear_Click(object sender, EventArgs e)
        {
            txtid.Text = string.Empty;
            txtname.Text =string.Empty;
            txtcategory.Text =string.Empty;
            txtstock.Text =string.Empty;
            txtbrand.Text = string.Empty;
            txtprice.Text = string.Empty;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Server = myServerAddress; Database = myDataBase; Uid = myUsername; Pwd = myPassword
                conexao = new MySqlConnection(" Server = localhost; Database = estoque; Uid = root; Pwd = ;");

                strSQL = "UPDATE  produtos SET Nome=@Nome, Categoria=@Categoria, Estoque=@Estoque, Marca=@Marca, Preco=@Preco WHERE ID=@id";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@id", txtid.Text);
                comando.Parameters.AddWithValue("@Nome", txtname.Text);
                comando.Parameters.AddWithValue("@Categoria", txtcategory.Text);
                comando.Parameters.AddWithValue("@Estoque", txtstock.Text);
                comando.Parameters.AddWithValue("@Marca", txtbrand.Text);
                comando.Parameters.AddWithValue("@Preco", txtprice.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

         
        }
    }
}
