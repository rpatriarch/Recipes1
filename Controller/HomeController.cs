using Microsoft.AspNetCore.Mvc;
using Recipes.Models;
using System;
using System.Collections.Generic;

namespace Recipes.Controllers
{
    public class RecipesController : Controller
    {
        public IActionResult Index()
        {
            var recipes = GetSampleRecipes();
            return View(recipes);
        }

        private List<Recipe> GetSampleRecipes()
        {
            return new List<Recipe>
            {
                new Recipe
                {
                    Id = 1,
                    Title = "Recipe 1",
                    Category = "Category 1",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    Complexity = "Easy",
                    PreparationTime = 30
                },
                new Recipe
                {
                    Id = 2,
                    Title = "Recipe 2",
                    Category = "Category 2",
                    CreatedDate = DateTime.Now.AddDays(-2),
                    Complexity = "Medium",
                    PreparationTime = 45
                },
                new Recipe
                {
                    Id = 3,
                    Title = "Recipe 3",
                    Category = "Category 3",
                    CreatedDate = DateTime.Now.AddDays(-3),
                    Complexity = "Hard",
                    PreparationTime = 60
                },
                new Recipe
                {
                    Id = 4,
                    Title = "Recipe 4",
                    Category = "Category 4",
                    CreatedDate = DateTime.Now.AddDays(-4),
                    Complexity = "Easy",
                    PreparationTime = 30
                }
            };
        }
    }
}
