using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Employee
    {
        //Create a class EMployee with empid, name, salary , accept the data & print it
        public int empid, empsalary;
        public string empname;

        public void EmployeeData(int id, string name, int salary)
        {
            empid = id;
            empname = name;
            empsalary = salary;
        }

        public string PrintData()
        {
            return $"Employee Id: {empid}\nEmployee Name: {empname}\nEmployee salary: {empsalary}\n";
        }

        public int GetEmployeeid()
        {
            return empid;
        }

        public string GetEmployeeName()
        {
            return empname;
        }

        public double GetEmployeeSalary()
        {
            return empsalary;
        }





    }


}
