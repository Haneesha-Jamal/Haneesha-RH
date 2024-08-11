using OOPsExam.Manager;
using OOPsExam.Model;
using System.Xml.Linq;

namespace OOPsExam
{
    class Program
    {
        public static int StudentID { get; private set; }
        public static int Age { get; private set; }
        public static double GPA { get; private set; }
        public static string Name { get; private set; }

        static void Main(string[] args)
        {
           
            StudentCollection studentCollection = new StudentCollection();
            
            studentCollection.AddStudent(new Student(StudentID = 5, Name = "Jamal", Age = 34, GPA = 8.5));
            studentCollection.RemoveStudent(2);
            List<Student> studentsWithID1 = studentCollection.GetStudent(3);
            studentsWithID1.ForEach(student => {});
            studentCollection.ListAllStudents();
        }

    }
}

