using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFridge.Data.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Navigational property to the recipies that this ingredient is used in
        /// </summary>
        public virtual ICollection<Recipe_Ingredient> Recipes { get; set; }

    }
}
