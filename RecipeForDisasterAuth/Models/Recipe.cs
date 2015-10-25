using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecipeForDisasterAuth.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //a shared table between Recipe and Ingredients should hold a column "amount"
        public virtual ICollection<RecipeIngredients> Ingredients { get; set; }

        /*public Recipe(int recipeId, string name, string description)
        {
            this.RecipeId = recipeId;
            this.Name = name;
            this.Description = description;
        }*/

        public void AddIngredient(Ingredient ingredient)
        {
            //Ingredients.Add(ingredient);
        }
    }
}