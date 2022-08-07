using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFridge.Data.Models
{
    public class Recipe_Ingredient
    {
        public int RecipeId { get; set; }

        /// <summary>
        /// This is also a navigational property.  It points to the Recipie
        /// </summary>
        public virtual Recipe Recipe { get; set; }

        public int IngredientId { get; set; }

        /// <summary>
        /// Navigational property that points to the Ingredient
        /// </summary>
        public virtual Ingredient Ingredient { get; set; }
    }
}
