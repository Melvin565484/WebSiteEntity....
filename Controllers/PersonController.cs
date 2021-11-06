using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using website.Models;

namespace website.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult index()
        {
            Person person = new Person();
            person.name="Santiago";
            person.lastname="Mendoza";
            person.age=17;
            person.direction="Cant. Pasaquinita";
            person.email="Melsmendoza17@gmail.com";
            person.phonenumber=7896-4521;

            return View(person);
        }
    }
}