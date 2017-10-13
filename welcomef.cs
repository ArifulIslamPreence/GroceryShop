using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocery_shop
{
    public partial class welcome : MetroForm
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblwelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnwelcome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            qsnf f = new qsnf();
            f.ShowDialog();
           this.Close();   
        }

        private void welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.ClearTable();

        }

        private void welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database.ClearTable();
        }
    }
}
