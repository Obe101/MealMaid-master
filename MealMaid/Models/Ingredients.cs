using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MealMaid.Models
{
    /// <summary>
    /// The items used to create a recipe
    /// </summary>
    public class Ingredients
    {
        [Key] // Make a primary key for database
        public int IngredientId { get; set; }

        /// <summary>
        /// The name of the ingredient
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The category the ingredient falls under
        /// Ex. vegetable, fruit, spic, ect
        /// </summary>
        public string Category { get; set; }
    }
}
