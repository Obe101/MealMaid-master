﻿using System;
using System.Collections.Generic;
using System.Text;
using MealMaid.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MealMaid1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Ingredients> Ingredients { get; set; }
    }
}
