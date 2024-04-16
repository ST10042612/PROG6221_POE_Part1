using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTracker
{
    internal class Printer
    {

        public void PrintOut(string recipe, string[] ingredients, double[] quantity, string[] UOM, string[] steps) //prints out the recipe
        {


            Console.WriteLine("Here is the recipe for " + recipe);
            Console.WriteLine("===================================");

            Console.WriteLine("");

            int iLength = ingredients.Length;

            Console.WriteLine("You will need the following ingredients");
            Console.WriteLine("");

            for (int i = 0; i < iLength; i++)
            {

                Console.WriteLine(quantity[i] + " " + UOM[i] + " of " + ingredients[i]);

            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Here are the steps taken to prepare the recipe");
            Console.WriteLine("=================================================");

            int sLength = steps.Length;

            for (int x = 0; x < sLength; x++)
            {

                Console.WriteLine(steps[x]);

            }


        }

        public int question() //asks the user weather they want to create a new recipe, scale the current recipe or exit the program
        {
            int answer = 0;
            Boolean exitLoop = false;

            Console.WriteLine("Would you like to create another recipe or scale the current one differently?\n1:New Recipe  2:Scale  3:Exit");

            //loops untill user enters a correct number
            while (!exitLoop)
            {

                int input = Int16.Parse(Console.ReadLine()); //takes in user input and converts it into an int

                //makes sure the user inputs the correct number
                if (input == 1 || input == 2 || input == 3)
                {
                    exitLoop = true;

                    switch (input)
                    {

                        case 1:
                            answer = 1;
                            break;
                        case 2:
                            answer = 2;
                            break;
                        case 3:
                            answer = 3;
                            break;


                    }

                }
                else
                {

                    Console.WriteLine("Would you like to create another recipe or scale the current one differently?\n1:New Recipe  2:Scale  3:Exit");

                }

            }


            return answer;
        }



    }
}
