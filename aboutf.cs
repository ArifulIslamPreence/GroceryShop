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
    public partial class aboutf : MetroForm
    {
        public aboutf()
        {
            InitializeComponent();
        }

        private void btnaboutok_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            clogin a = new clogin();
            a.ShowDialog();
            this.Close();
        }

        private void lbldescription_Click(object sender, EventArgs e)
        {

        }
    }
}
