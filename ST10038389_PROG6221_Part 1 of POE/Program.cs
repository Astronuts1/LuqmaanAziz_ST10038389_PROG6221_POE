using ST10038389_PROG6221_Part_1_of_POE.RecipeApplication;
using System;

namespace ST10038389_PROG6221_Part_1_of_POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RecipeClass recipe = new RecipeClass();

            Console.WriteLine("Enter the Number of Ingredients:");
            int ingredientCount = Convert.ToInt32(Console.ReadLine());
            recipe.SetIngredients(ingredientCount);

            Console.WriteLine("Enter the Number of Steps:");
            int stepCount = Convert.ToInt32(Console.ReadLine());
            recipe.SetSteps(stepCount);

            recipe.DisplayRecipeClass();

            Console.WriteLine("Enter the Scaling Factor (0.5, 2, or 3):");
            double factor = Convert.ToDouble(Console.ReadLine());
            recipe.ScaleRecipeClass(factor);

            recipe.DisplayRecipeClass();
        }
        //<summary>
        //This Application allows users to insert ingredients and follow steps for a recipe, scale the recipe by a factor of (0.5, 2 or 3.)
        //I created a new instance of the RecipeClass to work with Recipes.
        //Line 12: Allows the user to enter the Number of Ingredients into the application.
        //Line 13: Reads the users inputed details and converts it to integer.
        //Line 14: Sets the Number of Ingredients for the recipe.
        //Line 16: Allows the user to enter the Number of steps  in the recipe.
        //Line 18: Sets the steps for a step counter for the recipe.
        //Line 20: Displays the overview of the recipe, viewing the entered details of the ingredients and steps taken.
        //Line 22: Allows the user to enter the scaling factors.
        //Line 23: Reads the users entered details and converts it to Double().
        //Line 24: Scales the Recipe to a factor.
        //Line 26: Displays the final scaled recipe of  what the user inserted into the application.
        //</summary>
    }
}
//---------------------------------------------- END OF LINE --------------------------------------------------------------//
