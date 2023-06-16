using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Date
    {
        private int date, year;
        private string month;

        public void AcceptDate(int dd, string mm, int yy)
        {
            date = dd;
            year = yy;
            month = mm;
        }

        public string  PrintDate()
        {
            return $"Date is: {date}- {month}- {year}";
        }

        public int PrintYear()
        {
            return year;
        }
        public string PrintMonth()
        {
            return month;
        }
        public int PrintDay()
        {
            return date;
        }


         }

}

   

    

