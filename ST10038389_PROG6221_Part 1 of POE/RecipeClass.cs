using System;

namespace ST10038389_PROG6221_Part_1_of_POE.RecipeApplication
{
    
    public class RecipeClass
    {
        // Added Arrays to store the Ingredients and steps of the Recipe.
        private Ingredient[] ingredients;
        private RecipeSteps[] steps;

        
        public void SetIngredients(int count)
            // Sets the ingredients of the recipe.
        {
            ingredients = new Ingredient[count];
            // Initializes the arrays with the given count.

           // For loop implemented.
           // Loop allows users to enter for each ingredient and its details to follow.
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter Name of Ingredient {i + 1}:"); // Allows you to enter the number of ingredient plus details.
                string name = Console.ReadLine();

                Console.WriteLine($"Enter the Quantity of {name}:"); // Allows the user to enter quantity of items from recipe.
                double quantity = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Enter the Unit of Measurement for {name}:"); // Unit of measurement for the items added.
                string unit = Console.ReadLine();

                // Introducing Object Orientating for storing ingreduents into an array.
                ingredients[i] = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
            }
        }

        
        public void SetSteps(int count)
        {
            
            steps = new RecipeSteps[count];
            // Steps Array with given count allocated to.

            // For Loop statement to allows the user  to follow each step of the process.
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter step {i + 1}:");
                string description = Console.ReadLine();

                steps[i] = new RecipeSteps { Description = description };
            }
        }

        
        public void DisplayRecipeClass()
            // Display the Recipe class.
        {
            Console.WriteLine("Recipe:");
            Console.WriteLine("Ingredients:");

            // For Loop statement to display each of the Ingredients.
            foreach (var ingredient in ingredients)
            {
            Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine("Steps:");

            
            for 
            (int i = 0; i < steps.Length; i++)
                // For Loop statement to display each step of the process.
            {
            Console.WriteLine($"{i + 1}. {steps[i].Description}");
            }
        }

        public void ScaleRecipeClass(double factor) // Scaling the factor.
        {
            
            foreach 
            (var ingredient in ingredients)
                // For Loop statement to modify the quantity of each ingredient.
            {
                ingredient.Quantity *= factor;
            }
        }

        
        public void ResetQuantities() 
        { 
        }
        // Clears all the information.

        public void ClearRecipe()
            // Clears the Recipe details.
        {
            ingredients = null;
            steps = null;
        }
    }
}
//----------------------------------------- END OF LINE ------------------------------------------------------//
