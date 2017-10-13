/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grocery_shop
{
    class UserloginLogicLayer
    {
        loginDBlayer uldb = new loginDBlayer();

        private string uusername;
        private string Password;

        public string USERname
        {
            set { this.uusername = value; }
            get { return this.uusername; }
        }
        public string pAssword
        {
            set { this.Password = value; }
            get { return this.Password; }
        }
        public void Ulogin
        {

            string u1 = USERname;
        string p1 = pAssword;
        uldb.UserLogin(u1,p1);
		}
}
}*/
