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
    public partial class rawitemsf : MetroForm
    {
        private string name;
        private int id;
        List<Item> Items;
        private readonly SqlConnection _conn;
        public rawitemsf(int id,string name)
        {
            this.name = name;
            Items = new List<Item>();
            this.id = id;
            InitializeComponent();
        }

        private void rawitemsf_Load(object sender, EventArgs e)
        {
            lblraw.Text = name + " Items";
            Items = Database.GetItems(id);
            foreach (var i in Items)
            {
                string data = i.Name + " " + i.Price + "/" + i.Unit;
                cbraw.Items.Add(data);
            }

        }

        private void btnrawdone_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(udraw.Value) > 0 && cbraw.SelectedIndex != -1)
            {
                var s = cbraw.SelectedIndex;
                var id = Items[s].Id;
                var q = Convert.ToInt32(udraw.Value);

                if (Database.FindItem(id))
                {
                    Database.UpateItem(id, q);
                }
                else Database.AddItem(id, q);
            }
            dgraw.DataSource = (Database.GenerateGrid(id));
        }

        private void dgraw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       


    
  

       

        private void udraw_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbraw_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnrawclear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnrawclear_Click_1(object sender, EventArgs e)
        {
            //Database.ClearTable();
            //dgraw.DataSource = null;
            if (Convert.ToInt32(udraw.Value) > 0 && cbraw.SelectedIndex != -1)
            {
                var s = cbraw.SelectedIndex;
                var id = Items[s].Id;
                var q = Convert.ToInt32(udraw.Value);

                if (Database.FindItem(id))
                {
                    Database.DeleteItem(id, q);
                }

            }
            dgraw.DataSource = (Database.GenerateGrid(id));
        }

        private void btnrawback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F t = new F();
            t.ShowDialog();
            this.Close();
        }

        private void btnrawnext_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            additionf g = new additionf();
            g.ShowDialog();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
