using APICRUDwithVenkat.Model;
using APICRUDwithVenkat.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace APICRUDwithVenkat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentRepo _repo;

        public StudentsController(StudentRepo repo)
        {
            _repo = repo;
        }

        // GET: api/students
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            var students = _repo.GetAll();
            return Ok(students);
        }


        // GET: api/students/{id}
        [HttpGet("{id:int}")]
        public ActionResult<Student> GetStudentById(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid student ID.");
            }

            var student = _repo.GetById(id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student); 
        }

        [HttpGet("{name:alpha}")]

        public ActionResult<Student> GetStudnetByName(string name)
        {
            if (name == null)
            {
                return BadRequest("there is no name is matching");
            }

            var student = _repo.GeyByName(name);
            if(student == null)
            {
                return NotFound();      
            }

            return Ok(student);
        }

        [HttpPost]
        [Route("Create")]
        public ActionResult<Student> CreateStudent([FromBody] Student studentmodel)
        {
            if (studentmodel == null)
                return BadRequest("Student model cannot be null");

            int newId = _repo._students.Any() ? _repo._students.Last().Id + 1 : 1;

            Student student = new Student
            {
                Id = newId,
                Name = studentmodel.Name,
                Age = studentmodel.Age,
            };

            _repo._students.Add(student);
            return Ok(student);
           // return CreatedAtAction(nameof(_repo.GetAll), new { id = student.Id }, student);

        }


    }

}
