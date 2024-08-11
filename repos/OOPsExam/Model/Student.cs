using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsExam.Model
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set;}

        public Student(int studentId,string name,int age,double gpa) 
        {
            StudentID = studentId;
            Name = name;
            Age = age;
            GPA = gpa;
        }

        

    }
}
