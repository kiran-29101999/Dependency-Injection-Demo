using System.Collections.Generic;

namespace DependecyInjectionDemo.Models
{
    public interface IStudentRepository
    {
        Student GetStudentById(int StudentId);
        List<Student> GetAllStudent();
    }
}
