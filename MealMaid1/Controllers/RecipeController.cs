using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealMaid.Models;
using MealMaid1.Data;
using Microsoft.AspNetCore.Mvc;

namespace MealMaid.Controllers
{
    public class RecipeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecipeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Recipes()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Recipe r)
        {
            if (ModelState.IsValid)
            {
                await RecipeDb.AddRecipeAsync(_context, r);

                return RedirectToAction("Recipes");
            }
            return View();
        }
        
    }
}
