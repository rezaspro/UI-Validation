using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorePractice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CorePractice.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            List<Duration> list = new List<Duration>()
            {
                new Duration(){Id =1, Dura= 2.00M, Amount= 500},
                new Duration(){Id =2, Dura= 3.00M, Amount= 600}
            };
            ViewBag.Data = list;
            return View();
        }

        [HttpPost]
        public JsonResult Save([FromBody]List<ClassEntryDetails> ClassEntryDetails)
        {

            return Json(new { });
        }
    }

    public class Duration
    {
        public virtual long Id { get; set; }
        public virtual decimal Dura { get; set; }
        public virtual decimal Amount { get; set; }
    }
}