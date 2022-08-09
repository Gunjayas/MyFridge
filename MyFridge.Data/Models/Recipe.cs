using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFridge.Data.Models
{
    public class Recipe
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// This is a "Navigational property". We will configure this so that you can load
        /// the list of RECIPE_INGREDIENT's for this recipie easily
        /// </summary>
        public virtual ICollection<Recipe_Ingredient> Ingredients { get; set; }
    }
}
