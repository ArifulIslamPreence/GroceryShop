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
    public partial class adminf : MetroForm
    {
        public adminf()
        {
            InitializeComponent();
        }

        private void rbcheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbadmin_Enter(object sender, EventArgs e)
        {

        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            if (rbedition.Checked)
            {
                this.Visible = false;
                editionf f = new editionf();
                f.ShowDialog();
                this.Close();
            }
            else if (rbcheck.Checked)
            {
                this.Visible = false;
                purchasef g = new purchasef();
                g.ShowDialog();
                this.Close();
            }
            else if (rbchangecat.Checked)
            {
                this.Visible = false;
                changecat t = new changecat();
                t.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select one!");
            }
        }

        private void btnadminback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            qsnf a = new qsnf();
            a.ShowDialog();
            this.Close();
        }
    }
}
