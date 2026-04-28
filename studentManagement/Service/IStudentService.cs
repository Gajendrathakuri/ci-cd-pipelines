using studentManagement.Model;

namespace studentManagement.Service
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        Student? getById(int Id);
        Student AddStudent(Student Student);
    }
}
