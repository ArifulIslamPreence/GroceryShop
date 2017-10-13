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
    public partial class noticef : MetroForm
    {
        public noticef()
        {
            InitializeComponent();
        }

        private void btnnotice_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F f1 = new F();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = action2f.s;
        }
    }
}
