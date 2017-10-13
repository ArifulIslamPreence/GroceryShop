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
    public partial class cosmeticf : MetroForm
    {
        //public List<string> ItemPrice;
        //List<int> ItemId;
        private int id;
        List<Item> Items;
        private readonly SqlConnection _conn;
        public cosmeticf(int id)
        {
            /*ItemPrice = new List<string>();
            ItemId = new List<int>();
            */
            Items = new List<Item>();
            this.id = id+1;
            InitializeComponent();
        }
        private void cosmeticf_Load(object sender, EventArgs e)
        {
           
            Items=Database.GetItems(id);
            foreach(var i in Items)
            {
                string data = i.Name + " " + i.Price + "/" + i.Unit;
                cbcosmetic.Items.Add(data); 
            }
        }

        private void btncosmeticdone_Click(object sender, EventArgs e)
        {
            
            if(Convert.ToInt32(udcosmetic.Value)>0 && cbcosmetic.SelectedIndex!=-1)
            {
                var s = cbcosmetic.SelectedIndex;
                var id = Items[s].Id;
                var q = Convert.ToInt32(udcosmetic.Value);

                if (Database.FindItem(id))
                {
                    Database.UpateItem(id, q);
                }
                else Database.AddItem(id, q);
            }
            dataGridView1.DataSource=(Database.GenerateGrid(id));
        }

        private void btncosmeticback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F f = new grocery_shop.F();
            f.ShowDialog();
            this.Close();
        }

        private void btncosmeticnext_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            additionf g = new additionf();
            g.ShowDialog();
            this.Close();
        }

        private void btncosmeticclear_Click(object sender, EventArgs e)
        {
            Database.ClearTable();
            dataGridView1.DataSource = null;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(udcosmetic.Value) > 0 && cbcosmetic.SelectedIndex != -1)
            {
                var s = cbcosmetic.SelectedIndex;
                var id = Items[s].Id;
                var q = Convert.ToInt32(udcosmetic.Value);

                if (Database.FindItem(id))
                {
                    Database.DeleteItem(id, q);
                }
                
            }
            dataGridView1.DataSource = (Database.GenerateGrid(id));
        }
    }
    }

