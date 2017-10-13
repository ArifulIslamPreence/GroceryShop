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
    public partial class additionf : MetroForm
    {
        public additionf()
        {
            InitializeComponent();
        }

        private void btnaddyes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F f = new grocery_shop.F();
            f.ShowDialog();
            this.Close();
        }

        private void btnaddno_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            assesment g =new assesment();
            g.ShowDialog();
            this.Close();
        }
    }
}
