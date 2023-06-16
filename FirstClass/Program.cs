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


            //Console.WriteLine("Enter student id: ");
            //Console.WriteLine("Enter student name: ");
            //Console.WriteLine("Enter percentage: ");
            //Student obj = new Student();
            //obj.StudentData(111, "Arsh Chaus", 98);
            //string data = obj.PrintData();
            //Console.WriteLine(data);
            //Console.WriteLine(obj.GetStudentid());
            //Console.WriteLine(obj.GetStudentName());
            //Console.WriteLine(obj.GetPercentage());


            //Employee obj = new Employee();
            //obj.EmployeeData(102, "Pallavi Kinge", 75000);
            //string data = obj.PrintData();
            //Console.WriteLine(data);
            //Console.WriteLine(obj.GetEmployeeid());
            //Console.WriteLine(obj.GetEmployeeName());
            //Console.WriteLine(obj.GetEmployeeSalary());


            Product obj = new Product();
            obj.ProductData(568794, "Luminous Battery", 15000);
            string data = obj.PrintData();
            Console.WriteLine(data);
            Console.WriteLine(obj.GetProductcode());
            Console.WriteLine(obj.GetProductNmae());
            Console.WriteLine(obj.GetProductPrice());

        }
    }
}
