using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an Object

            //Date obj = new Date();
            //obj.AcceptDate(16, "June", 2023);
            //string data = obj.PrintDate();
            //Console.WriteLine(data);
            //Console.WriteLine(obj.PrintDay());
            //Console.WriteLine(obj.PrintMonth());
            //Console.WriteLine(obj.PrintYear());



            //Student obj = new Student();
            //Console.WriteLine(obj.PrintData());
            ////Constructor
            //Student obj2 = new Student(12, "Pragati", 89.8);
            //Console.WriteLine(obj2.PrintData());





            //obj.StudentData(111, "Arsh Chaus", 98);
            //string data = obj.PrintData();
            //Console.WriteLine(data);
            //Console.WriteLine(obj.GetStudentid());
            //Console.WriteLine(obj.GetStudentName());
            //Console.WriteLine(obj.GetPercentage());


            //Employee obj = new Employee();
            //Console.WriteLine(obj.PrintData());
            //Constructor
            //Employee obj2 = new Employee(201, "Sonal Sharma", 55000);
            //Console.WriteLine(obj2.PrintData());


            ////obj.EmployeeData(102, "Pallavi Kinge", 75000);
            //string data = obj.PrintData();
            //Console.WriteLine(data);
            //Console.WriteLine(obj.GetEmployeeid());
            //Console.WriteLine(obj.GetEmployeeName());
            //Console.WriteLine(obj.GetEmployeeSalary());


            //Product obj = new Product();
            //obj.ProductData(568794, "Luminous Battery", 15000);
            //string data = obj.PrintData();
            //Console.WriteLine(data);
            //Console.WriteLine(obj.GetProductcode());
            //Console.WriteLine(obj.GetProductNmae());
            //Console.WriteLine(obj.GetProductPrice());


            //Product obj = new Product();             //Constructor
            //Console.WriteLine(obj.PrintData());

            //Product obj2 = new Product(64987, "TV",69000);
            //Console.WriteLine(obj2.PrintData());


            //Book obj = new Book();
            //Console.WriteLine(obj.PrintBook());

            //Book obj2 = new Book(789,214,"Atomic Habits","James Clear");
            //Console.WriteLine(obj2.PrintBook());

            //Bank obj = new Bank();
            //Console.WriteLine(obj.PrintBank());

            //Bank obj2 = new Bank(54621588,850000,"Ishanvi Chavan","Salary Account");
            //Console.WriteLine(obj2.PrintBank());

            User obj = new User();
            Console.WriteLine(obj.PrintUser());

            User obj2 = new User(9871,"Priyanka Patil","priya24@gmail.com","phisjh#6753");
            Console.WriteLine(obj2.PrintUser());
        }
    }
}
