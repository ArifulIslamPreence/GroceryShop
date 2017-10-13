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
    public partial class action2f : MetroForm
    {
        public static string s;
        public action2f()
        {
            InitializeComponent();
        }

        private void btnaction2done_Click(object sender, EventArgs e)
        {
                this.Visible = false;
                repeatf a = new repeatf();
                a.ShowDialog();
                this.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaction2send_Click(object sender, EventArgs e)
        {
            s = textBox1.Text;
        }
    }
}
