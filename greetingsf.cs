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
    public partial class greetingsf : MetroForm
    {
        public greetingsf()
        {
            InitializeComponent();
        }

        private void btngreetings_Click(object sender, EventArgs e)
        {
            Database.ClearTable();
            this.Visible = false;
            qsnf f = new qsnf();
            f.ShowDialog();
            this.Close();
        }
    }
}
