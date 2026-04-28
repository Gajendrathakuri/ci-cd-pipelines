using studentManagement.Model;

namespace studentManagement.Service
{
    public class StudentService:IStudentService
    {
        private static readonly List<Student> Students = new()
        {
            new Student{Id=1,Email="gaju76960@gmail.com",Course="Data Structure And Algorithms",Name="Gajendra Singh"},
            new Student{Id=2,Email="xyz@gmail.com",Course="Microsoft",Name="Binod Chaudhary" },
            new Student{Id=3,Email="aryan@gmail.com",Course="System Design",Name="Aryan Chaudhary"}
        };



        public List<Student> GetAllStudents()
        {
            return Students;
        }


        public Student getById(int id)
        {
            return Students.FirstOrDefault((e) => e.Id == id);
        }


        public Student AddStudent(Student student)
        {
            student.Id = Students.Max(x => x.Id) + 1;
            Students.Add(student);
            return student;
        }
    }
}
