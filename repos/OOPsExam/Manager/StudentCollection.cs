using OOPsExam.Interface;
using OOPsExam.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsExam.Manager
{
    public class StudentCollection : IStudentCollection
    {
        public static int StudentID { get; private set; }
        public static int Age { get; private set; }
        public static double GPA { get; private set; }
        public static string Name { get; private set; }

        List<Student> students = new List<Student>
        {
            new Student(StudentID = 1, Name = "Haneesha", Age = 24,GPA = 8.5),
            new Student(StudentID = 2, Name = "John", Age = 28,GPA = 4.5),
            new Student(StudentID = 3, Name = "Alexander", Age = 34,GPA = 9.5),
            new Student(StudentID = 4, Name = "Smith", Age = 24,GPA = 8.5)
        };
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(int studentId)
        {
            Student studentToRemove = students.FirstOrDefault(s => s.StudentID == studentId);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine("Removed successfully");
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }
        public List<Student> GetStudent(int studentId)
        {
            return students.Where(e => e.StudentID == studentId).ToList();
        }
        public void ListAllStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Student ID: {student.StudentID}, Name: {student.Name}, Age: {student.Age}, GPA: {student.GPA}");
            }
        }
    }
}




