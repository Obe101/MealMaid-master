using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MealMaid.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Search()
        {
            return View();
        }
    }
}
