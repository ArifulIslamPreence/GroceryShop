using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grocery_shop
{
    public class CurrentUser
    {
        private static CurrentUser user;

        public string userName { get; set; }
        public int userId { get; set; }
        public int totalPurchase { get; set; }
        
        public static CurrentUser GetInstance()
        {
            if (user == null)
            {
                user = new CurrentUser();
            }
            return user;
        }
        private CurrentUser()
        {

        }

    }
}
