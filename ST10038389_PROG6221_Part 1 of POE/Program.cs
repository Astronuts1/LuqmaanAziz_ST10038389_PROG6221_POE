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
//references used for the PROG6221 - PART 1 OF POE AS FOLLOWS:
//Bruil, A., 2024. Learning Unit 2 Theme 1 to 4 - Lecture Slides_VC Learn , Cape Town: Amber Bruil.
//Bruil, A., 2024. Learning Unit 3 Theme 1 - Lecture Slides_VC Learn, Cape Town: Amber Bruil.
//overFlow, s., 2020. How to get scaling factor. [Online] Available at: https://stackoverflow.com/questions/60872044/how-to-get-scaling-factor-for-each-monitor-e-g-1-1-25-1-5[Accessed 3 April 2024].
//W3schools, 2024. C# Properties (Get and Set). [Online] Available at: https://www.w3schools.com/cs/cs_properties.php[Accessed 3 April 2024].
//overFlow, s., 2021. How to call a class from Main() method ?. [Online] Available at: https://stackoverflow.com/questions/55464556/how-to-call-a-class-from-main-method[Accessed 4 April 2024].
//W3schools, 2024. C# Arrays. [Online] Available at: https://www.w3schools.com/cs/cs_arrays.php[Accessed 4 April 2024].

//---------------------------------------------- END OF LINE --------------------------------------------------------------//
