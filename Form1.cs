using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Conexao com o banco de dados + variaveis

        SqlConnection sqlConexao = new SqlConnection("Data Source=DESKTOP-3B4GN67\\SQLEXPRESS;Initial Catalog=Atividade;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;


        //desabilitar os campos para pesquisar
        public void desabilitaCampos()
        {
            Cid.Enabled = true;
            Est.Enabled = true;
            Reg.Enabled = true;
            Uf.Enabled = true;
            Pes.Enabled = true;
            Lim.Enabled = true;
            Cad.Enabled = false;
            Nov.Enabled = true;
        }

        //habilitar os campos para cadastrar
        public void habilitaCampos()
        {
            Cid.Enabled = true;
            Est.Enabled = true;
            Reg.Enabled = true;
            Uf.Enabled = true;
            Pes.Enabled = false;
            Nov.Enabled = false;
            Lim.Enabled = true;
            Cad.Enabled = true;
        }

        //limpar os campos
        public void limparCampos()
        {
            Cid.Text = "";
            Est.Text = "";
            Reg.Text = "";
            Uf.Text = "";
        }

        //chamando os metodos de habilitar e desabilitar
        public void Form1_Load(object sender, EventArgs e)
        {
            desabilitaCampos(); //desabilitar quando abrir
        }

        public void Nov_Click(object sender, EventArgs e)
        {
            habilitaCampos(); //habilita para cadastrar
        }

        private void Lim_Click(object sender, EventArgs e)
        {
            limparCampos(); //limpa os textbox
            desabilitaCampos();
        }

        private void Cad_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConexao.Open();
                string strSQL = "Select Cidade from Brasil where Cidade = '+Cid.Text+'";
                cmd.Connection = sqlConexao;
                cmd.CommandText = strSQL;
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Cidade já cadastrada");
                }

                else
                {
                    if (!dr.IsClosed) { dr.Close(); }
                    strSQL = "insert into Brasil (Cidade,Estado,UF,Regiao) values(@Cidade,@Estado,@UF,@Regiao)";
                    cmd.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = Cid.Text;
                    cmd.Parameters.Add("@Estado", SqlDbType.VarChar).Value = Est.Text;
                    cmd.Parameters.Add("@UF", SqlDbType.VarChar).Value = Uf.Text;
                    cmd.Parameters.Add("@Regiao", SqlDbType.VarChar).Value = Reg.Text;
                    cmd.Connection = sqlConexao;
                    cmd.CommandText = strSQL;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cidade cadastrada com sucesso");

                    limparCampos();
                    desabilitaCampos();
                    cmd.Parameters.Clear();
                    sqlConexao.Close();
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                sqlConexao.Close();

            }

        }
        //Pesquisar no banco de dados e trazer a informação
        private void Pes_Click(object sender, EventArgs e)
        {

            sqlConexao.Open();
            string strSQL = "Select Cidade from Brasil where Cidade = '+Cid.Text+'";
            cmd.Connection = sqlConexao;
            cmd.CommandText = strSQL;
            dr = cmd.ExecuteReader();

            try
            {

                if (!dr.HasRows)
                {
                    while (dr.Read())
                    {

                        MessageBox.Show("Cidade não encontrada");
                        Cid.Text = "";

                    }
                }

                else
                {
                    dr.Read();
                    Cid.Text = Convert.ToString(dr["Cidade"]);
                    Est.Text = Convert.ToString(dr["Estado"]);
                    Reg.Text = Convert.ToString(dr["UF"]);
                    Uf.Text = Convert.ToString(dr["Regiao"]);

                    if (!dr.IsClosed) { dr.Close(); }
                    sqlConexao.Close();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                sqlConexao.Close();

            }
        }

            private void Cid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}