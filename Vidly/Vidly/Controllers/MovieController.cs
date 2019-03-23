using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models; 

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Harry Potter" }; // Vidly.Models 를 추가해줘야 함. 
            return View(movie); // Random 이라는 View 를 만든다.   
        }
    }
}