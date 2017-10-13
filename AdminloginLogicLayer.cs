/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grocery_shop
{
    class AdminloginLogicLayer
    {
        loginDBlayer aldb = new loginDBlayer();

        private string username;
        private string PPassword;

        public string UUsername
        {
            set { this.username = value; }
            get { return this.username; }
        }
        public string ppAssword
        {
            set { this.PPassword = value; }
            get { return this.PPassword; }
        }
        public void Alogin
        {

            string u = UUsername;
        string p = ppAssword;
        aldb.AdminLogin(u,p);
		}
}
}
*/