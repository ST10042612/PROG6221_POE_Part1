using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



internal class RecipeManager
    {

    //variable declaration
    int ingredientSize, stepSize;
    public string recipe;
    public ArrayList ingredientName = new ArrayList();
    public ArrayList ingredientQuantity = new ArrayList();
    public ArrayList ingredientUOM = new ArrayList();
    public ArrayList steps = new ArrayList();

    public void CreateRecipe()//Creates a new recipe based off of user input
    {
        //asks user for the name of the recipe then adds that input into a string named recipe
        Console.WriteLine("Please enter the name of the recipe you would like to create.");
        recipe = Console.ReadLine();

        //asks the user to input how many ingredients are in the recipe, then adds that number into an int named ingredientAmount
        Console.WriteLine("How many ingredients are there in this recipe?");
        ingredientSize = Int16.Parse(Console.ReadLine());

        //the user will enter each ingredients name, quantity and its Unit of mesurement, this will then be input into the respective arraylist.
        for (int i = 0; i < ingredientSize; i++)
        {

            Console.WriteLine("Enter an ingredients name:");
            ingredientName.Add(Console.ReadLine());

            Console.WriteLine("Enter the quantity of the ingredient:");
            ingredientQuantity.Add(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Enter the ingredients unit of mesurement:");
            ingredientUOM.Add(Console.ReadLine());

            Console.WriteLine("");
        }

        //asks the user to input how many steps the recipe has, then adds that number into an int named stepAmount
        Console.WriteLine("How many steps are there in this recipe?");
        stepSize = Int16.Parse(Console.ReadLine());

        //the user will enter each step, this will then be input into the respective arraylist.
        for (int x = 0; x < stepSize; x++)
        {

            Console.WriteLine("Please enter a step");
            steps.Add(Console.ReadLine());

        }

    }

    
    public void ScaleRecipe() //This function will determine by what factor the user would like to scale the recipe by and then it will apply the users choice to the ingredientQuantity Array
    {

        //variable declaration
        Boolean exitLoop = false;
        double multiplier = 0;

        Console.WriteLine("How would you like to scale your recipe?\n1:Half 2:Double 3:Triple\nPlease enter a number");

        while (!exitLoop)
        {
            
            int input = Int16.Parse(Console.ReadLine()); //takes in user input and converts it into an int

            //makes sure the user inputs the correct number
            if (input == 1 || input == 2 || input == 3)
            {
                exitLoop = true;

                //switch statement to decide what has to be done to the ingredientQuantity array based off of user input
                switch (input)
                {

                    case 1: 
                        multiplier = 0.5;
                        break;
                    case 2:
                        multiplier = 2;
                        break;
                    case 3:
                        multiplier = 3;
                        break;

                }

            }
            else
            {

                Console.WriteLine("please input one of the following numbers\n1:Half 2:Double 3:Triple");

            }

        }

        double[] ingredientQ = (double[])ingredientQuantity.ToArray(typeof(double)); //arraylist converted into double array so that information can be manipulated and re entered into the array

        for (int i = 0; i < ingredientQuantity.Count; i++)
        {
            
            ingredientQuantity[i] = ingredientQ[i] * multiplier;

        }




    }
    

    public void Clear() //clears all the arrays and the recipe value
    {

        recipe = "";
        ingredientName.Clear();
        ingredientQuantity.Clear();
        ingredientUOM.Clear();
        steps.Clear();

    }

}
;