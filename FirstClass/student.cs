using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Student
    {
        //Create class Student with rollno, name & percentage . Accept the data & print it

        public int studentid;
        public string studentname;
        public double percentage;


        public void StudentData(int id, string name, float per)
        { studentid = id;
          studentname = name;
          percentage = per;
        }

        public string PrintData()
        {
            return $"Student Id: {studentid},\nStudent Name: {studentname},\nPercentages: {percentage}\n";
        }

        public int GetStudentid()
        {
             return studentid;
        }

        public string GetStudentName()
        { 
            return studentname; 
        }

        public double GetPercentage()
        {
            return percentage;
        }

    }
}
