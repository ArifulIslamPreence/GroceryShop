using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace grocery_shop
{
    public partial class F : MetroForm
    {
        List<Category> CatList;
        public F()
        {
            //Database.ClearTable();
            InitializeComponent();
            CatList = Database.GetAllCategory();
            comboBox1.Items.AddRange(CatList.Select(c=>c.Name).ToArray());
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            /*if (comboBox1.SelectedIndex==0) {
                this.Visible = false;
                cosmeticf a1 = new cosmeticf(0);
                a1.ShowDialog();
                this.Close();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                this.Visible = false;
                rawitemsf a2 = new rawitemsf(1);
                a2.ShowDialog();
                this.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                this.Visible = false;
                toyf a3 = new toyf(2);
                a3.ShowDialog();
                this.Close();
            }*/
            if (comboBox1.SelectedIndex >= 0)
            {
                this.Visible = false;
                rawitemsf a2 = new rawitemsf(CatList[comboBox1.SelectedIndex].Id, comboBox1.SelectedItem.ToString());
                a2.ShowDialog();
                this.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbraw_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
