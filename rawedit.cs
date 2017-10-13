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
using System.Diagnostics;
using MetroFramework.Controls;
using MetroFramework;

namespace grocery_shop
{
    public partial class rawedit : MetroForm

    {
        List<Item> itemList;
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\csharp\\db\\pos.mdf; Integrated Security = True; Connect Timeout = 30");
        static string name, price, kg = "kg", id="2";
        private int selectedIndex;
        private string selectedItem;

        public rawedit()
        {
            InitializeComponent();
        }

        public rawedit(int selectedIndex, string selectedItem)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
            this.selectedItem = selectedItem;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rawedit_Load(object sender, EventArgs e)
        {
            lblrawedit.Text = selectedItem;
            itemList= Database.GetItems(selectedIndex);
            comboBox1.Items.AddRange(itemList.Select(c=>c.Name).ToArray());
        }

        private void btnrawdelete_Click(object sender, EventArgs e)
        {
            /*string insertQuery = "DELETE  FROM Item WHERE Name='" + tbrawedit.Text +"' and Price= '"+ tbraweditprice.Text+"'and Unit='"+kg+"'and Category_Id='"+id+"'";
            SqlCommand command = new SqlCommand(insertQuery, conn);
            conn.Open();
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
            conn.Close();*/
            Debug.WriteLine(itemList.Count + " " + comboBox1.SelectedIndex);
            if (comboBox1.SelectedIndex >= 0) {
                if (Database.DeleteFromItem(itemList[comboBox1.SelectedIndex].Id))
                    MetroMessageBox.Show(this, "Delete Successful", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MetroMessageBox.Show(this, "Unable to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MetroMessageBox.Show(this, "Invalid Selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            itemList = Database.GetItems(selectedIndex);
            //comboBox1.DataSource = itemList.Select(c => c.Name);
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(itemList.Select(c => c.Name).ToArray());
        }

        private void btnraweditback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            editionf a = new editionf();
            a.ShowDialog();
            this.Close();
        }

        private void btnrawinsert_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Name = tbrawedit.Text;
            item.Price = tbraweditprice.Text;
            item.Unit = textBox1.Text;
            item.CategoryId = selectedIndex;
            
                if (Database.InsertIntoItems(item))
                    MetroMessageBox.Show(this, "Insert Successful", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MetroMessageBox.Show(this, "Unable to Insert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
       

            
            itemList = Database.GetItems(selectedIndex);
            comboBox1.Items.Clear();
            //comboBox1.DataSource = itemList.Select(c => c.Name);
            comboBox1.Items.AddRange(itemList.Select(c => c.Name).ToArray());
            /*{
                if (tbrawedit.Text.Length > 0 && tbraweditprice.Text.Length > 0)
                {
                    string insertQuery = "INSERT into Item(Name,Price,Unit,Category_Id) VALUES('" + tbrawedit.Text + "','" + tbraweditprice.Text + "','"+ kg +"','"+id+"')";
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



            }*/

        }

    }
}
