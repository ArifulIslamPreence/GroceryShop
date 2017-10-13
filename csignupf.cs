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
    public partial class csignupf : MetroForm
    {
        public csignupf()
        {
            InitializeComponent();
        }
        static void usersignup(string username, string email, string mobile, string password)
        {
            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\csharp\\db\\pos.mdf; Integrated Security = True; Connect Timeout = 30");
            
            try
            {

                string insertqry = "INSERT INTO UserSignUp(Username,Email,Mobile,Password) VALUES ('" + username + "','" + email + "','" + mobile + "','" + password + "')";
                
                SqlCommand cmd = new SqlCommand(insertqry, conn);
                conn.Open();
                SqlDataReader readar = cmd.ExecuteReader();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnsignup_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbsignupnm.Text)|| String.IsNullOrEmpty(tbsignupeml.Text)|| String.IsNullOrEmpty(tbsignupnmbr.Text)|| String.IsNullOrEmpty(tbsignuppass.Text))
            {
                MessageBox.Show("All fields are not filled");
            }
            else
            {
                usersignup(tbsignupnm.Text, tbsignupeml.Text, tbsignupnmbr.Text, tbsignuppass.Text);
                this.Visible = false;
                noticef a = new noticef();
                a.ShowDialog();
                this.Close();

            }



        }

        private void tbsignupnm_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbsignupeml_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbsignupnmbr_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbsignuppass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            clogin k = new clogin();
            k.ShowDialog();
            this.Close();
        }
    }
}
