using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;

namespace grocery_shop
{
    public partial class purchasef : MetroForm
    {
        public purchasef()
        {
            InitializeComponent();
        }

        private void btnpurchaseback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminf a = new adminf();
            a.ShowDialog();
            this.Close();
        }

        private void btnpurchasenext_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            action2f b= new action2f();
            b.ShowDialog();
            this.Close();
        }

        private void purchasef_Load(object sender, EventArgs e)
        {


            double total;
            dataGridView1.DataSource = Database.GetPurchase();
        }

        private void purchasef_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Database.GetPurchase();
            metroComboBox1.Items.AddRange(new[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            metroComboBox2.Items.AddRange(new[] { "2016", "2017" });
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var month = metroComboBox1.SelectedIndex + 1;
            var year = Convert.ToInt32(metroComboBox2.SelectedItem);
            var data = Database.GetPurchaseMonth(month, year);
            metroLabel1.Text = data.ToString();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
