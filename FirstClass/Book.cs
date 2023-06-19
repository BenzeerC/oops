using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Book
    {
        //Create a class Book with book id , name, price & author name. Assign value using
        //non parametric & parametric constructor & display the details
        public int bookid, bookprice;
        public string bookname, authorname;

        public Book()
        {
            bookid = 575;
            bookprice = 250;
            bookname = "Living a good life";
            authorname = "Helen and Scott Nearing";
        }
        public Book(int id, int price,string bname,string aname)
        {
            bookid = id;
            bookprice = price;
            bookname = bname;
            authorname = aname;
        }
        public string PrintBook()
        {
            return $"Book Id: {bookid}\nBook Price: {bookprice}\nBook Name: {bookname}\nAuthor Name: {authorname}\n";
        }

    }
}
