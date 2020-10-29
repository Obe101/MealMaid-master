using MealMaid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealMaid1.Data
{
    public static class RecipeDb
    {
        public static async Task<Recipe> AddRecipeAsync (ApplicationDbContext _context, Recipe r)
        {
            _context.Recipes.Add(r);
            await _context.SaveChangesAsync();
            return r;
        }
    }
}
