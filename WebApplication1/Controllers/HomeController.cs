using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello From our first web page";
        }
        public ViewResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            List<Person> persons = new List<Person>
            {
              new Person{Id=1,Name="John",Surname="Eliyev",CityId=1},
              new Person{Id=2,Name="Mike",Surname="Eliyev",CityId=2 },
              new Person{Id=3,Name="Leyla",Surname="Eliyeva",CityId=2},
              new Person{Id=4,Name="Arif",Surname="Eliyev",CityId=1}
            };

            List<string> cities = new List<string> { "Baku", "Istanbul" };

            var model = new PersonListViewModel { Persons = persons, Cities = cities };
            return View(model);
        }

        public IActionResult Index4()
        {
            return Ok();
        }
        public IActionResult Index5()
        {
            return BadRequest();
        }
        public RedirectResult Index6()
        {
            return Redirect("/home/index3");
        }
        public IActionResult Index7()
        {
            return Redirect("index2");
        }
         public IActionResult Index8()
        {
            return RedirectToRoute("Default", new { action = "Index3" });
        }
        public JsonResult Index9()
        {
            List<Person> persons = new List<Person>
            {
              new Person{Id=1,Name="John",Surname="Eliyev",CityId=1},
              new Person{Id=2,Name="Mike",Surname="Eliyev",CityId=2 },
              new Person{Id=3,Name="Leyla",Surname="Eliyeva",CityId=2},
              new Person{Id=4,Name="Arif",Surname="Eliyev",CityId=1}
            };

            return Json(persons);
        }
    }
}

//https://elvin.com/home/index
