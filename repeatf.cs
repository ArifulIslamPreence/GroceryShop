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
    public partial class repeatf : MetroForm
    {
        public repeatf()
        {
            InitializeComponent();
        }

        private void btnrepeatyes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            action2f a = new action2f();
            a.ShowDialog();
            this.Close();
        }

        private void btnrepeatno_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminf b = new adminf();
            b.ShowDialog();
            this.Close();
        }
    }
}
