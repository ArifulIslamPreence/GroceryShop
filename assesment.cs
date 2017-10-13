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
    public partial class assesment : MetroForm
    {
        //public List<string> ItemNamePrice;
        //List<int> ItemId;
        //List<int> Quantity;
        //private readonly SqlConnection _conn;
        private int id;
        List<Item> Items;

        public assesment()
        {
            //ItemNamePrice = new List<string>();
            //ItemId = new List<int>();
            //Quantity = new List<int>();
            InitializeComponent();
            /*_conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\csharp\\db\\pos.mdf;"
               + "Integrated Security = True; Connect Timeout = 30");*/
           
        }

        private void btnassesmentnext_Click(object sender, EventArgs e)
        {
            Database.SetPurchase();
            this.Visible = false;
            greetingsf f = new greetingsf();
            f.ShowDialog();
            this.Close();
        }

        private void btnassesmentback_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            F g = new grocery_shop.F();
            g.ShowDialog();
            this.Close();
        }

        private void dgassesment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblassesmentprice_Click(object sender, EventArgs e)
        {

        }

        private void assesment_Load(object sender, EventArgs e)
        {
   
            double total;
            dgassesment.DataSource = Database.GenerateGrid(out total);

            CurrentUser user = CurrentUser.GetInstance();
            user.totalPurchase =Convert.ToInt32(total);

            lblassesmentprice.Text += total.ToString();
        }
    }
}
