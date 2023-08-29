using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MVCPractice.Models;

namespace MVCPractice.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student{Id=101,Name="Rakesh",Marks=93},
                new Student{Id=102,Name="Shital",Marks=92},
                new Student{Id=103,Name="Seema",Marks=88},
                new Student{Id=104,Name="Sunita",Marks=87},
                new Student{Id=105,Name="Ronit",Marks=78},


            };
            ViewData["stu"]=students;
            return View();
        }
    }
}
