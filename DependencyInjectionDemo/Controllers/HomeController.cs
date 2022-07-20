using DependecyInjectionDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DependencyInjectionDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _repository;
        public HomeController(IStudentRepository repository)
        {
            _repository = repository;
        }

        public JsonResult Index()
        {
            StudentRepository repository = new StudentRepository();
            List<Student> allStudentDetails = repository.GetAllStudent();
            return Json(allStudentDetails);
        }
        //public JsonResult Index()
        //{
        //    List<Student> allStudentDetails = _repository.GetAllStudent();
        //    return Json(allStudentDetails);
        //}

        public JsonResult GetStudentDetails(int Id)
        {
            StudentRepository repository = new StudentRepository();
            Student studentDetails = repository.GetStudentById(Id);
            return Json(studentDetails);
        }
        //public JsonResult GetStudentDetails(int Id)
        //{
        //    Student studentDetails = _repository.GetStudentById(Id);
        //    return Json(studentDetails);
        //}
    }
}
