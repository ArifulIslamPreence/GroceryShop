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
    public partial class changecat : MetroForm
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\csharp\\db\\pos.mdf; Integrated Security = True; Connect Timeout = 30");

        public changecat()
        {
            InitializeComponent();
        }

        private void btndelcat_Click(object sender, EventArgs e)
        {
            var catId = Database.GetCategoryByName(tbchangecat.Text);
            if(catId!=null)
            {
                Database.DeleteFromItemByCategory(catId.Id);
                string insertQuery = "DELETE  FROM Category WHERE Name='" + tbchangecat.Text + "'";
                conn.Open();
                SqlCommand command = new SqlCommand(insertQuery, conn);
                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {

                        MessageBox.Show("Deleted successfully");
                    }
                    else
                    {

                        MessageBox.Show("Data not inserted");

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }

        private void btninsertcat_Click(object sender, EventArgs e)
        {
            {
                if (tbchangecat.Text.Length > 0 )
                {
                    string insertQuery = "INSERT into Category(Name) VALUES('" + tbchangecat.Text +  "')";
                    conn.Open();
                    SqlCommand command = new SqlCommand(insertQuery, conn);
                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {

                            MessageBox.Show("inserted successfully");
                        }


                        else
                        {

                            MessageBox.Show("Data not inserted");

                        }
                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {

                    MessageBox.Show("ALL fields are not satisfied");

                }
                conn.Close();



            }
        }

        private void btncatback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminf k = new adminf();
            k.ShowDialog();
            this.Close();
        }
    }
}
