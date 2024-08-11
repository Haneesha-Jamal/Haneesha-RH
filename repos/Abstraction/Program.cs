using Abstraction;
using System.Net.Cache;
using System.Xml.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using abstraction to work with different types of students
            Student UnderGraduate = new UnderGraduate()
            {
                Name = "Haneesha",
                Age = 20,
                Major = "Cs"
            };

            Student PostGraduate = new PostGraduate()
            {
                Name = "Jamal",
                Age = 25,
                ResearchArea = "AI"
            };

            // Common interface to display student information
            UnderGraduate.DisplayInfo();
            PostGraduate.DisplayInfo();
        }
    }
}
