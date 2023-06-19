using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class User
    {
        //Create class User with user id, user name, email & password.
        //Assign value using parametric constructor & display the details

        public int userid;
        public string username, useremail, userpassword;

        public User() 
        {
            userid = 6014;
            username = "Pradeep Shinde";
            useremail = "pradeep.s92@gamil.com";
            userpassword = "shin@1956";
        }

        public User(int id, string name, string email, string password)
        {
            userid = id;
            username = name;
            useremail = email;
            userpassword = password;
        }
        public string PrintUser()
        {
            return $"\nUser Id:{userid}\nUser Name:{username}\nUser Email:{useremail}\nUser Password:{userpassword}";
        }

    }
}
