using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MealMaid.Models
{
    /// <summary>
    /// A consumable recipe thats either edible or drinkable
    /// </summary>
    public class Recipe
    {
        [Key] //Makes primary key in database
        public int RecipeId { get; set; }

        /// <summary>
        /// The name of the recipe
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Category the recipe falls under
        /// Ex. breakfast, dessert, cocktail, ect.
        /// </summary>
        public string Category { get; set; }


    }
}
