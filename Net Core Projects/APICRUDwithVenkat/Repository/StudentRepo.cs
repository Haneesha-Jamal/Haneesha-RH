using APICRUDwithVenkat.Model;
using System;

namespace APICRUDwithVenkat.Repository
{
    public class StudentRepo
    {
        public readonly List<Student> _students = new List<Student>

            {
            new Student { Id = 1, Name = "John", Age = 20 },
            new Student { Id = 2, Name = "Jane", Age = 22 },
            new Student { Id = 3, Name = "Alice", Age = 19 },
            new Student { Id = 4, Name = "Bob", Age = 23 }
            };

        private int _nextId = 1;

        public void Add(Student student)
        {
            student.Id = _nextId++;
            _students.Add(student);
        }

        public Student GetById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public Student GeyByName(string name) 
        { 
            return _students.FirstOrDefault(student => student.Name == name);
        }
        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        //public void Update(Student student)
        //{
        //    var existingStudent = GetById(student.Id);
        //    if (existingStudent != null)
        //    {
        //        existingStudent.Name = student.Name;
        //        existingStudent.Age = student.Age;
        //    }
        //}

        //public void Delete(int id)
        //{
        //    var student = GetById(id);
        //    if (student != null)
        //    {
        //        _students.Remove(student);
        //    }
        //}
    }
}
