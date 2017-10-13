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
    public partial class toyf : MetroForm
    {
        private int id;
        List<Item> Items;
        private readonly SqlConnection _conn;
        public toyf(int id)
        {
            Items = new List<Item>();
            this.id = id + 1;
            InitializeComponent();

        }
        private void toyf_Load(object sender, EventArgs e)
        {

            Items = Database.GetItems(id);
            foreach (var i in Items)
            {
                string data = i.Name + " " + i.Price + "/" + i.Unit;
                comboBox1.Items.Add(data);
            }
        }

        private void btntoyback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F f = new grocery_shop.F();
            f.ShowDialog();
            this.Close();
        }

        private void btntoynext_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            additionf g = new additionf();
            g.ShowDialog();
            this.Close();
        }

        /* private void toyf_Load(object sender, EventArgs e)
         {

         }*/

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btntoydone_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(udtoy.Value) > 0 && comboBox1.SelectedIndex != -1)
            {
                var s = comboBox1.SelectedIndex;
                var id = Items[s].Id;
                var q = Convert.ToInt32(udtoy.Value);

                if (Database.FindItem(id))
                {
                    Database.UpateItem(id, q);
                }
                else Database.AddItem(id, q);
            }
            dataGridView1.DataSource = (Database.GenerateGrid(id));
        }

        private void udtoy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void btntoyclear_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(udtoy.Value) > 0 && comboBox1.SelectedIndex != -1)
            {
                var s = comboBox1.SelectedIndex;
                var id = Items[s].Id;
                var q = Convert.ToInt32(udtoy.Value);

                if (Database.FindItem(id))
                {
                    Database.DeleteItem(id, q);
                }

            }
            dataGridView1.DataSource = (Database.GenerateGrid(id));
        }
    }



}

        

       

      

