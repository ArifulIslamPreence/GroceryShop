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
    public partial class toyedit : MetroForm
    {
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\csharp\\db\\pos.mdf; Integrated Security = True; Connect Timeout = 30");
        static string name, price, pc = "Piece", id = "3";
        public toyedit()
        {
            InitializeComponent();
        }

        private void btntoyeditback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            editionf a = new editionf();
            a.ShowDialog();
            this.Close();
        }

        private void btntoydelete_Click(object sender, EventArgs e)
        {
            string insertQuery = "DELETE  FROM Item WHERE Name='" + tbtoyedit.Text + "' and Price= '" + tbtoyprice.Text + "'and Unit='" + pc + "'and Category_Id='" + id + "'";
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

        private void btntoyinsert_Click(object sender, EventArgs e)
        {
            {
                if (tbtoyedit.Text.Length > 0 && tbtoyprice.Text.Length > 0)
                {
                    
                    string insertQuery = "INSERT into Item(Name,Price,Unit,Category_Id) VALUES('" + tbtoyedit.Text + "','" + tbtoyprice.Text + "','" + pc + "','" + id + "')";
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
    }
}
