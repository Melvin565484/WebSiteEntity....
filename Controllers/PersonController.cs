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
            person.Name="Santiago";
            person.Lastname="Mendoza";
            person.Age=17;
            person.Direction="Cant. Pasaquinita";

            return View(person);
        }
    }
}