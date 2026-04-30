using studentManagement.Service;

namespace studentmanagementtest
{
    public class StudentServicestest
    {
        [Fact]
        public void GetAllStudent()
        {
            // Arrange
            var service = new StudentService();
            // Act
            var student = service.GetAllStudents();
            // Assert
            Assert.NotNull(student);
            Assert.NotEmpty(student);
            Assert.True(student.Count >= 2);
        }
    }
}
