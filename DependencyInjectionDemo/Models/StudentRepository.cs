using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependecyInjectionDemo.Models
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> DataSource()
        {
            return new List<Student>()
            {
                new Student() { StudentId = 101, Name = "Falgun", Branch = "Computer", Section = "A", Gender = "Male" },
                new Student() { StudentId = 102, Name = "Devarsh", Branch = "Mechanical", Section = "B", Gender = "Male" },
                new Student() { StudentId = 103, Name = "Sandip", Branch = "Civil", Section = "A", Gender = "Male" },
                new Student() { StudentId = 104, Name = "Shivangi", Branch = "Computer", Section = "A", Gender = "Female" },
                new Student() { StudentId = 105, Name = "Saloni", Branch = "HR", Section = "B", Gender = "Female" }
            };
        }
        public Student GetStudentById(int StudentId)
        {
            return DataSource().FirstOrDefault(e => e.StudentId == StudentId);
        }
        public List<Student> GetAllStudent()
        {
            return DataSource();
        }
    }
}
