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
using MetroFramework.Forms;

namespace grocery_shop
{
    public partial class alogin : MetroForm
    {
        static string username, password;
        public alogin()
        {
            InitializeComponent();
        }
        static bool adminlogin(string username, string password)
        {
            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\csharp\\db\\pos.mdf; Integrated Security = True; Connect Timeout = 30");
            try
            {


                string query1 = "SELECT * FROM AdminLogin WHERE Username='" + username + "'and Password='" + password + "'";
                SqlCommand cmd = new SqlCommand(query1, conn);
                conn.Open();
                SqlDataReader readar = cmd.ExecuteReader();
                //SqlDataAdapter readar = new SqlDataAdapter(cmd);
                return readar.Read();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            finally
            {

                conn.Close();

            }
            return false;
        }

        private void btnalogin_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(tbaloginnm.Text))
            {
                MessageBox.Show("Please enter UserName!");
            }

            else if (String.IsNullOrEmpty(tbaloginpass.Text))
            {
                MessageBox.Show("Please enter Password!");
            }

            else if (adminlogin(tbaloginnm.Text, tbaloginpass.Text))
            {
                username = tbaloginnm.Text;
                password = tbaloginpass.Text;
                this.Visible = false;
                adminf d = new adminf();
                d.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Username or Password incorrect");
            }
            //Database.ClearTable();
        }

        private void tbaloginnm_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbaloginpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
