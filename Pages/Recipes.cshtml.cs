using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipes.Models;
using System;
using System.Collections.Generic;

namespace Recipes.Pages
{
    public class RecipesModel : PageModel
    {
        public List<Recipe> Recipes { get; set; }

        public void OnGet()
        {
            Recipes = GetBulgarianRecipes();
        }

        private List<Recipe> GetBulgarianRecipes()
        {
            return new List<Recipe>
            {
                new Recipe
                {
                    Id = 1,
                    Title = "Шопска салата",
                    Category = "Салати",
                    CreatedDate = new DateTime(2022, 1, 15),
                    Complexity = "Easy",
                    PreparationTime = 15
                },
                new Recipe
                {
                    Id = 2,
                    Title = "Мусака",
                    Category = "Основни ястия",
                    CreatedDate = new DateTime(2022, 3, 5),
                    Complexity = "Medium",
                    PreparationTime = 90
                },
                new Recipe
                {
                    Id = 3,
                    Title = "Баница",
                    Category = "Закуски",
                    CreatedDate = new DateTime(2022, 5, 10),
                    Complexity = "Hard",
                    PreparationTime = 120
                },
                new Recipe
                {
                    Id = 4,
                    Title = "Таратор",
                    Category = "Супи",
                    CreatedDate = new DateTime(2022, 7, 20),
                    Complexity = "Easy",
                    PreparationTime = 20
                }
            };
        }
    }
}
