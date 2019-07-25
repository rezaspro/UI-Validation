using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CorePractice.Models;

namespace CorePractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student();
            return View(student);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpGet]
        public IActionResult Test(string roll, string examId)
        {
            ViewData["Message"] = "Your contact page.";
            Student student = new Student();
            student.Roll = roll;
            student.ExamId = examId;
            return View("Partial/_MyTestPartial", student);
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
