using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grocery_shop
{
    public class Database
    {
        private readonly static SqlConnection _conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\csharp\\db\\pos.mdf;"
                + "Integrated Security = True; Connect Timeout = 30");
        public Database()
        {
            /*_conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\csharp\\db\\pos.mdf;"
                + "Integrated Security = True; Connect Timeout = 30");*/
        }
        public static List<Category> GetAllCategory()
        {
            List<Category> CatList = new List<Category>();
            try
            {
                string query = "SELECT * FROM Category";
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                SqlDataReader readar = cmd.ExecuteReader();
                while (readar.Read())
                {
                    var newCat = new Category();
                    newCat.Id= (Convert.ToInt32(readar["Id"]));
                    newCat.Name=(readar["Name"].ToString());
                    CatList.Add(newCat);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally { _conn.Close(); }
            return CatList;
        }

        public static List<Item> GetItems(int catID)
        {
            List<Item> itemList = new List<Item>();
            try
            {
                string query = "SELECT * FROM Item WHERE category_id=" + catID;
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                SqlDataReader readar = cmd.ExecuteReader();
                while (readar.Read())
                {
                    var newItem = new Item();
                    newItem.Id = (Convert.ToInt32(readar["Id"]));
                    newItem.Name = (readar["Name"].ToString());
                    newItem.Price = (readar["Price"].ToString());
                    newItem.Unit = (readar["Unit"].ToString());
                    itemList.Add(newItem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally { _conn.Close(); }
            return itemList;
        }

        public static void SetPurchase()
        {
            try
            {
                var d = DateTime.Now.ToShortDateString();
                CurrentUser user = CurrentUser.GetInstance();
                string query = "INSERT INTO Purchase(C_id,Date,totalPurchase)VALUES(" + user.userId + ",'" + d + "'," + user.totalPurchase + ")";
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally { _conn.Close(); }
        }

        public static List<PurchaseGrid> GetPurchase()
        {
            List<PurchaseGrid> purchaseGrid=new List<PurchaseGrid>();
            try
            {
                string query = "SELECT * FROM Purchase";
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                SqlDataReader readar = cmd.ExecuteReader();
                while (readar.Read())
                {
                    var purchase = new PurchaseGrid();
                    purchase.C_Id= (Convert.ToInt32(readar[0]));
                    var date = Convert.ToDateTime(readar[1]);
                    purchase.date=date.ToShortDateString();
                    purchase.total = (Convert.ToInt32(readar[3]));
                    purchaseGrid.Add(purchase);
                }
                return purchaseGrid;
            }
            catch (Exception ex) { return null; }
            finally { _conn.Close();  }
        }

        public static void AddItem(int id, int quantity)
        {
            try
            {

                string query = "INSERT INTO Cart(Item_Id,Quantity)VALUES(" + id + "," + quantity + ")";
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally { _conn.Close(); }
        }
        public static void DeleteItem(int id, int quantity)
        {
            try
            {
                string query = "DELETE FROM Cart WHERE Item_Id='"+id+"'";
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally { _conn.Close(); }
        }

        public static int GetPurchaseMonth(int month, int year)
        {
            try
            {
                int tot = 0;
                string query = "SELECT totalPurchase FROM Purchase WHERE MONTH(Date) = "+month+" AND YEAR(Date) = "+year;
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                SqlDataReader readar = cmd.ExecuteReader();
                while(readar.Read())
                {
                    tot += Convert.ToInt32(readar[0]);
                }
                return tot;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0 - 1;
            }
            finally { _conn.Close(); }
        }


        public static void UpateItem(int id, int q)
        {
            try
            {
                string query = "SELECT Quantity FROM Cart WHERE Item_Id=" + id;
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                SqlDataReader readar = cmd.ExecuteReader();
                readar.Read();
                q += Convert.ToInt32(readar["Quantity"]);
                _conn.Close();
                _conn.Open();
                string query2 = "UPDATE Cart SET Quantity=" + q + " WHERE Item_id=" + id;
                SqlCommand cmd2 = new SqlCommand(query2, _conn);
                //_conn.Open();
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally { _conn.Close(); }
        }

        public static bool FindItem(int id)
        {
            try
            {
                string query = "SELECT * FROM Cart WHERE Item_Id=" + id;
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                SqlDataReader readar = cmd.ExecuteReader();
                return readar.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally { _conn.Close(); }
            return false;
        }

        public static List<Grid> GenerateGrid(int cat)
        {
            List<int> itemId = new List<int>();
            List<int> quantity = new List<int>();
            List<Grid> gridList = new List<Grid>();
            try
            {
                string query = "SELECT Item_Id,Quantity FROM Cart";
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                SqlDataReader readar = cmd.ExecuteReader();
                while (readar.Read())
                {
                    itemId.Add(Convert.ToInt32(readar[0]));
                    quantity.Add(Convert.ToInt32(readar[1]));
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            try
            {

                for (int i = 0; i < itemId.Count; i++)
                {
                    var item_id = itemId[i];
                    _conn.Open();
                    string query2;
                    
                    query2 = "SELECT Name,Price FROM Item WHERE Id=" + item_id + " AND Category_id=" + cat;
                    SqlCommand cmd2 = new SqlCommand(query2, _conn);
                    SqlDataReader readar2 = cmd2.ExecuteReader();
                    while (readar2.Read())
                    {
                        Grid grid = new Grid();
                        grid.Quantity = quantity[i];
                        grid.Name = readar2[0].ToString();
                        grid.Price = readar2[1].ToString();
                        gridList.Add(grid);
                    }
                    _conn.Close();
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {// _conn.Close();
            }
            return gridList;
        }

        public static List<Grid> GenerateGrid(out double tot)
        {
            tot = 0;
            List<int> itemId = new List<int>();
            List<int> quantity = new List<int>();
            List<Grid> gridList = new List<Grid>();
            try
            {
                string query = "SELECT Item_Id,Quantity FROM Cart";
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                SqlDataReader readar = cmd.ExecuteReader();
                while (readar.Read())
                {
                    itemId.Add(Convert.ToInt32(readar[0]));
                    quantity.Add(Convert.ToInt32(readar[1]));
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            try
            {

                for (int i = 0; i < itemId.Count; i++)
                {
                    var item_id = itemId[i];
                    _conn.Open();
                    string query2 = "SELECT Name,Price FROM Item WHERE Id=" + item_id;
                    SqlCommand cmd2 = new SqlCommand(query2, _conn);
                    SqlDataReader readar2 = cmd2.ExecuteReader();
                    while (readar2.Read())
                    {
                        
                        Grid grid = new Grid();
                        grid.Quantity = quantity[i];
                        grid.Name = readar2[0].ToString();
                        grid.Price = readar2[1].ToString();
                        gridList.Add(grid);
                        tot += grid.Quantity * Convert.ToInt32(grid.Price);
                    }
                    _conn.Close();
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {// _conn.Close();
            }
            return gridList;
        }

        public static void ClearTable()
        {
            try
            {
                string query = "TRUNCATE TABLE cart";
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
        }

        /*public static List<Grid> GetCartGrid()
        {
            List<Grid> itemList = new List<Grid>();
            try
            {
                string query = "SELECT * FROM Cart";
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                SqlDataReader readar = cmd.ExecuteReader();
                while (readar.Read())
                {
                    var newItem = new Grid();
                    //newItem.Id = (Convert.ToInt32(readar["Id"]));
                    newItem.Name = (readar["Name"].ToString());
                    newItem.Price = (readar["Price"].ToString());
                    //newItem.Unit = (readar["Unit"].ToString());
                    newItem.Quantity= (Convert.ToInt32(readar[""]));
                    itemList.Add(newItem);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally { _conn.Close(); }
            return itemList;
        }*/

        public static bool DeleteFromItem(int id)
        {
            try
            {
                string query = "DELETE FROM Item WHERE Id='" + id + "'";
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                return cmd.ExecuteNonQuery() > 0;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            finally { _conn.Close(); }
        }

        public static bool InsertIntoItems(Item item)
        {
            try
            {
                string query = "INSERT INTO Item(Name,Price,Unit,Category_Id)VALUES('" + item.Name + "','"
                    + item.Price + "','"+item.Unit+"',"+item.CategoryId+")";
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            finally { _conn.Close(); }
        }

        public static bool DeleteFromItemByCategory(int id)
        {
            try
            {
                string query = "DELETE FROM Item WHERE Category_Id=" + id;
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                return cmd.ExecuteNonQuery() > 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            finally { _conn.Close(); }
        }

        public static Category GetCategoryByName(string name)
        {
            //List<Category> CatList = new List<Category>();
            try
            {
                string query = "SELECT * FROM Category WHERE Name = '"+name+"'";
                SqlCommand cmd = new SqlCommand(query, _conn);
                _conn.Open();
                SqlDataReader readar = cmd.ExecuteReader();
                if (readar.Read())
                {
                    var newCat = new Category();
                    newCat.Id = (Convert.ToInt32(readar["Id"]));
                    newCat.Name = (readar["Name"].ToString());
                    return newCat;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally { _conn.Close(); }
            return null;
        }
    }



    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Unit { get; set; }
        public int CategoryId { get; set; }
    }

    public class Grid
    {
        public string Name { get; set; }
        public string Price { get; set; }

        public int Quantity { get; set; }
    }

    public class PurchaseGrid
    {
        public string date { get; set; }
        public int C_Id { get; set; }
        public int total { get; set; }
    }
   
}
