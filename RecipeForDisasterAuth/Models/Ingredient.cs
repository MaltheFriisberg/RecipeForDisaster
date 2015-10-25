using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecipeForDisasterAuth.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }
        [Required]
        public string Name { get; set; }
        public bool Organic { get; set; }
        public bool Vegan { get; set; }
        public virtual ICollection<RecipeIngredients> Recipes { get; set; } 

    }
}