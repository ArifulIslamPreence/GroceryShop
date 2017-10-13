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
    
   
    public partial class clogin : MetroForm
    {
        static string username,password;
        public clogin()
        {
            InitializeComponent();
        }
        static bool userlogin(string username, string password)
        {
            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\csharp\\db\\pos.mdf; Integrated Security = True; Connect Timeout = 30");
            try
            {
                             
                string query1 = "SELECT * FROM UserSignUp WHERE Username='" + username + "'and Password='" + password+"'";
                SqlCommand cmd = new SqlCommand(query1, conn);
                conn.Open();
                
                SqlDataReader readar = cmd.ExecuteReader();
                //var x = readar.Read();
                if(readar.Read())
                {
                    CurrentUser user = CurrentUser.GetInstance();
                    user.userId = Convert.ToInt32(readar[0]);
                    user.userName = username;
                    user.totalPurchase = 0;
                    return true;
                } 
                //readar.
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

        private void btnclogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbcloginnm.Text))
            {
                MessageBox.Show("Please enter UserName!");
            }

            else if (String.IsNullOrEmpty(tbcloginpass.Text))
            {
                MessageBox.Show("Please enter Password!");
            }

            else if (userlogin(tbcloginnm.Text, tbcloginpass.Text))
            {
                username = tbcloginnm.Text;
                password = tbcloginpass.Text;
                this.Visible = false;
                noticef c = new noticef();
                c.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Username or Password incorrect");
            }
            Database.ClearTable();


        }

        private void lblcloginsnup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            csignupf b = new csignupf();
            b.ShowDialog();
            this.Close();
        }

        private void btnabt_Click(object sender, EventArgs e)
        {


            this.Visible = false;
            aboutf a = new aboutf();
            a.ShowDialog();
            this.Close();
        }

        private void tbcloginnm_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            aboutf a = new aboutf();
            a.ShowDialog();
            this.Close();
        }

        private void tbcloginpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
