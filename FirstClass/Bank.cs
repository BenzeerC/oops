using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Bank
    {
        //Create a class Bank with acc no, name, account type, balance .
        //assign the value using non parametric & parametric constructor & display the details
        public long accno, accbalance;
        public string accountholdername, accounttype;


        public Bank()
        {
            accno = 56987456;
            accbalance = 700000;
            accountholdername = "Arvika Choudhary";
            accounttype = "Saving Account";

        }
        public Bank(long no, long balance, string name, string account)
        {
            accno = no;
            accbalance = balance;
            accountholdername = name;
            accounttype = account;

        }
        public string PrintBank()
        {
            return $"\nAccount No:{accno}\nAccount Balance:{accbalance}\nAccount Holder Name:{accountholdername}\nAccount Type{accounttype}\n"; 
        }
    
    }    

}

