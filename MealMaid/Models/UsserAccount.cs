using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MealMaid.Models
{
    public class UsserAccount
    {
        [Key] // Make a primary key
        public int UserId { get; set; }

        /// <summary>
        /// A name of the user's choice that's associated with the account 
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The user's email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A secret code of the user's choice to be user when logging in 
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The user's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The user's last name
        /// </summary>
        public string LatName { get; set; }

        /// <summary>
        /// The user's date of birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }

    }
}
