using DBtoRazor.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Identity.Client;

namespace DBtoRazor
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;

            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. List Item");
            Console.WriteLine();

           

            do
            {
                Console.WriteLine("Choose the option you want to perform: ");
                string choose = Console.ReadLine();
                Student st = new Student();
                Grade gd = new Grade();

                switch (choose)
                {
                    case "1":
                        SchooldbContext context = new SchooldbContext();
                        Console.WriteLine("Enter your ID:");
                        st.StudentId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter first name:");
                        st.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter last name:");
                        st.LastName = Console.ReadLine();
                        gd.GradeId= context.Grades.Count()+1;
                        Console.WriteLine("Enter Grade ID:");
                        st.GradeId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter grade:");
                        gd.Grade1 = Console.ReadLine();
                        AddGrade(gd);
                        AddStudent(st);
                       
                        break;

                    case "2":
                        ListStudents();
                        break;

                    default:
                        condition = false;
                        break;
                }
            }
            while (condition);
        }

        public static void AddStudent(Student st)
        {
            SchooldbContext context = new SchooldbContext();
            context.Students.Add(st);
            context.SaveChanges();
        }
        public static void AddGrade(Grade gd)
        {
            SchooldbContext context = new SchooldbContext();
            context.Grades.Add(gd);
            context.SaveChanges();
        }

        public static void ListStudents()
        {
            SchooldbContext context = new SchooldbContext();
            var list = context.Students.ToList();
            foreach (var student in list)
            {
                Console.WriteLine($"ID: {student.StudentId}");
                Console.WriteLine($"First Name: {student.FirstName}");
                Console.WriteLine($"Last Name: {student.LastName}");
                Console.WriteLine($"Grade ID: {student.GradeId}");
                Console.WriteLine();
            }
        }
    }
}

