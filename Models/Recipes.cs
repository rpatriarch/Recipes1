using System;
using System.ComponentModel.DataAnnotations;

namespace Recipes.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public string Complexity { get; set; }
        public double PreparationTime { get; set; }
    }
}
