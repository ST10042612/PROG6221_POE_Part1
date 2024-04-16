using RecipeTracker;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //Variable declaration
        Printer printer = new Printer();
        RecipeManager rm = new RecipeManager();
        Boolean exitLoop = false;

        Console.WriteLine("WELCOME TO THE RECIPE CREATOR\n=================================");

        //loops untill user wishes to exit 
        while (!exitLoop)
        {
            //creates a recipe
            rm.CreateRecipe();

            //Variable declaration for arrays
            string[] ingredientName = (string[])rm.ingredientName.ToArray(typeof(string));
            double[] ingredientQuantity = (double[])rm.ingredientQuantity.ToArray(typeof(double));
            string[] ingredientUOM = (string[])rm.ingredientUOM.ToArray(typeof(string));
            string[] steps = (string[])rm.steps.ToArray(typeof(string));

            Console.Clear();//clears the CLI for a cleaner look

            printer.PrintOut(rm.recipe, ingredientName, ingredientQuantity, ingredientUOM, steps);

            //loops untill user wishes to exit
            while (!exitLoop)
            {
                Console.WriteLine();
                int q = printer.question(); //uses user imput to decide on an action

                if (q == 1) //for more recipies
                {
                    rm.Clear(); //clears the CLI for a cleaner look
                    rm.CreateRecipe();

                    //Variable declaration for arrays
                    ingredientName = (string[])rm.ingredientName.ToArray(typeof(string));
                    ingredientQuantity = (double[])rm.ingredientQuantity.ToArray(typeof(double));
                    ingredientUOM = (string[])rm.ingredientUOM.ToArray(typeof(string));
                    steps = (string[])rm.steps.ToArray(typeof(string));

                    Console.Clear(); //clears the CLI for a cleaner look

                    printer.PrintOut(rm.recipe, ingredientName, ingredientQuantity, ingredientUOM, steps);

                }
                if (q == 2) //recipe manipulation
                {

                    rm.ScaleRecipe();

                    //Variable declaration for arrays
                    ingredientName = (string[])rm.ingredientName.ToArray(typeof(string));
                    ingredientQuantity = (double[])rm.ingredientQuantity.ToArray(typeof(double));
                    ingredientUOM = (string[])rm.ingredientUOM.ToArray(typeof(string));
                    steps = (string[])rm.steps.ToArray(typeof(string));

                    Console.Clear(); //clears the CLI for a cleaner look

                    printer.PrintOut(rm.recipe, ingredientName, ingredientQuantity, ingredientUOM, steps);

                }

                if (q == 3) //exits the program
                {

                    exitLoop = true;

                }

            }
                

        }

    }
}
