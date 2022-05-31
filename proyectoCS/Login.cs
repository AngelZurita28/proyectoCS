using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyectoCS
{
    public partial class Login : Form
    {
        Connection con = new Connection();
        string username, password;
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text != "" && txtPassword.Text != "")
                {
                    con.Open();
                    string query = "insert into usuarios(user_name, password) values ('" + txtUserName.Text + "','" + txtPassword.Text + "');";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                }
                txtPassword.Text = string.Empty;
                txtUserName.Text = string.Empty;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                //MySqlConnection con = new MySqlConnection("datasource= localhost; database=sampledb;port=3306; username = root; password= db1234"); //open connection
                //con.Open();
                //MySqlCommand cmd = new MySqlCommand("select * from login where username = '" + txtUserName.Text + "' AND password = '" + txtPassword.Text + "'", con);
                //MySqlDataReader reader = cmd.ExecuteReader();
                //if (reader.Read())
                //{
                //    MessageBox.Show("Haz iniciado sesion" + txtUserName);
                //}
                //else
                //{
                //    MessageBox.Show("Usuario o contrasena incorrectos");
                //}
                //txtPassword.Text = string.Empty;
                //txtUserName.Text = string.Empty;
                //reader.Close();
                //cmd.Dispose();
                //con.Close(); // always close connection 
            }
            try
            {
                if (txtUserName.Text != "" && txtPassword.Text != "")
                {

                    con.Open();
                    string query = "select user_name,password FROM usuarios WHERE user_name ='" + txtUserName.Text + "' AND password ='" + txtPassword.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            username = row["user_name"].ToString();
                            password = row["password"].ToString();
                        }
                        MessageBox.Show("Bienvenido " + txtUserName.Text);
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contrasena incorrectos");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password vacios");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error");
            }
        }

    }

}
