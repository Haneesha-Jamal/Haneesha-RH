using OOPsExam.Manager;
using OOPsExam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsExam.Interface
{
    public interface IStudentCollection 
    {
        void AddStudent(Student student);
        void RemoveStudent(int studentId);
        List<Student> GetStudent(int studentId);
        void ListAllStudents();

    }
}
