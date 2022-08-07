using MyFridge.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFridge.Data.Services
{
    /// <summary>
    /// Make sure to inherit from DbContext here
    /// </summary>
    public class MyFrideDataDbContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Recipe_Ingredient> Recipe_Ingredients { get; set; }

        /// <summary>
        /// Because we inherited from DbContext, we can override this to configure our
        /// database model (the datase itself)
        /// </summary>
        /// <param name="modelBuilder">This is what we apply our settings to</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Custom configuration for ingredients
            var ingredientConfig = modelBuilder.Entity<Ingredient>();

            // This is the magic, we are telling our model builder that "Ingredient"
            // has many "RecipieIngredients", and those RecipieIngredients have
            // one (required) Ingredient.  (Entity framework is smart enough to figure
            // out and use the IngredientId and RecipieId fields on the Recipie_Ingredient
            // entity)
            ingredientConfig.HasMany(ingredient => ingredient.Recipes)
                .WithRequired(recipe => recipe.Ingredient);

            // Custom configuation for Recipies
            var recipieConfig = modelBuilder.Entity<Recipe>();
            recipieConfig.HasMany(recipe => recipe.Ingredients)
                .WithRequired(recipeIngredient => recipeIngredient.Recipe);

            // Could configure Recipe_Ingredients here if you want, but not needed
        }
    }
}
