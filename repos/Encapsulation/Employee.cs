using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Employee
    {
        //fields
        private string name;
        private int empId;
        private double salary;
        //properties to access and modify private fields

        //Constructor
        public Employee(string name, int empId, double salary)
        {
            this.name = name;
            this.empId = empId;
            this.salary = salary;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
        public double Salary
        {
            get { return salary; }      
            set { if (value >= 0) salary = value;
                else
                    Console.WriteLine("salary cannot be negative");
            }
        }

        public void displayInfo()
        {
            Console.WriteLine($"Employee ID : {empId}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Salary : {salary}");
        }
    }
}

