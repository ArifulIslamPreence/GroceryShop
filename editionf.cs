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
    public partial class editionf : MetroForm
    {
        List<Category> CatList;
        public editionf()
        {
            InitializeComponent();
        }

        private void btneditionback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminf a = new adminf();
            a.ShowDialog();
            this.Close();
        }

        private void btneditionnext_Click(object sender, EventArgs e)
        {
            /*if (rbrawedition.Checked)
            {
                this.Visible = false;
                rawedit b = new rawedit();
                b.ShowDialog();
                this.Close();
            }
            else if (rbcosmeticedition.Checked)
            {
                this.Visible = false;
                cosmeticeditf c = new cosmeticeditf();
                c.ShowDialog();
                this.Close();
            }
            else if (rbtoyedition.Checked)
            {
                this.Visible = false;
                toyedit d = new toyedit();
                d.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select one!");
            }*/
            this.Visible = false;
            rawedit b = new rawedit(CatList[comboBox1.SelectedIndex].Id,comboBox1.SelectedItem.ToString());
            b.ShowDialog();
            this.Close();

        }

        private void editionf_Load(object sender, EventArgs e)
        {
            CatList = Database.GetAllCategory();
            comboBox1.Items.AddRange(CatList.Select(c=>c.Name).ToArray());
        }
    }
}
