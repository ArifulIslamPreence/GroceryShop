/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grocery_shop
{
    class C_signUp
    {
        SignUpDb sdb = new SignUpDb();
        private string Username;
        private string E_mail;
        private string P_assword;
        private string mobile;

        public string u_sername
        {
            set { this.Username = value; }
            get { return this.Username; }

        }
        public string emAil
        {
            set { this.E_mail = value; }
            get { return this.E_mail; }

        }
        public string PaSSword
        {
            set { this.P_assword = value; }
            get { return this.P_assword; }

        }
        public string Mobile
        {
            set { this.mobile = value; }
            get { return this.mobile; }

        }

        public void Signup()
        {

            string U1 = u_sername;
            string E1 = emAil;
            string M1 = Mobile;
            string P1 = PaSSword;
            sdb.Signup_db(U1, E1, M1, P1);
        }
    }
}*/
