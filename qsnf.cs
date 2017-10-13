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
    public partial class qsnf : MetroForm
    {
        public qsnf()
        {
            InitializeComponent();
        }

        private void btnqsna_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            alogin a = new alogin();
            a.ShowDialog();
            this.Close();
        }

        private void btnqsnc_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            clogin b = new clogin();
            b.ShowDialog();
             this.Close();

        }
    }
}
