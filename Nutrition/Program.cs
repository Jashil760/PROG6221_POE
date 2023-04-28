using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition
{
    internal class Program
    {
        //Declarations 
        public static double numIngredient { get; set; }
        public static double rSteps { get; set; }
        public static string iName { get; set; }
        public static string iQuantity { get; set; }
        public static string iMeasure { get; set; }
        public static string stepDescrip { get; set; }      
        
        //Storage class to store the recipe information                
        public static void Storage() 
        {
            //Storage declarations
            string[] ingredients;
            int i = 0;
            int s = 0;

            Console.WriteLine("Enter the number of ingredients");
            double numIngredient = Convert.ToInt32(Console.ReadLine());

            try
            {
                //do while loop to store multiple items 
                do
                {
                    Console.WriteLine("Enter the name of the ingredient");
                    string iName = Console.ReadLine();
                    Console.WriteLine("Enter the quantity of the ingredient");
                    string iQuantity = Console.ReadLine();
                    Console.WriteLine("Enter the unit of measurement for the ingredient");
                    string iMeasure = Console.ReadLine();
                    ingredients = new string[] { iName };
                    i++;
                }
                //while loop for the numbe rof ingredients
                while (i < numIngredient);
            }
            catch (Exception input)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter the correct type of value");
            }

            Console.WriteLine("Enter the number of steps");
            double rSteps = Convert.ToInt32(Console.ReadLine());
            
            //do while loop for step description
            do
            {                
                Console.WriteLine("Enter the description of the steps");
                string stepDescrip = Console.ReadLine();
                s++;
            }
            while (s < rSteps);
        }

        //Recipe class to display the recipe weather it is scaled or not 
        public static void Recipe() 
        {
            try
            {
                Console.WriteLine("Would you like to scale the recipe by? " +
                                  "/n" + "(1) Half: 0.5" +
                                  "/n" + "(2) Double: 2" +
                                  "/n" + "(3) Triple: 3");
                int scale = Convert.ToInt32(Console.ReadLine());

                //if statements to capture the users desired scale up value
                if (scale == 1)
                {
                    for (int i = 0; i < iQuantity.Length; i++)
                    {
                        iQuantity[i] * 0.5;
                    }
                    foreach (int quant in iQuantity)
                    {
                        Console.WriteLine("iQuantity: " + quant);
                    }
                }
                else if (scale == 2)
                {
                    for (int i = 0; i < iQuantity.Length; i++)
                    {
                        iQuantity[i] * 2;
                    }
                    foreach (int quant in iQuantity)
                    {
                        Console.WriteLine("iQuantity: " + quant);
                    }
                }
                else if (scale == 3)
                {
                    for (int i = 0; i < iQuantity.Length; i++)
                    {
                        iQuantity[i] * 3;
                    }
                    foreach (int quant in iQuantity)
                    {
                        Console.WriteLine("iQuantity: " + quant);
                    }
                }

                Console.WriteLine("************************RECIPE*******************************");
                Console.WriteLine("The ingreients and quantities are: " + iName + iQuantity);
                Console.WriteLine("The steps are: " + stepDescrip);
            }
            catch (Exception input)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter the correct type of value");
            }
        }

        //Rest class to reset the values affected by the scale up 
        public static void Reset()
        {
            try
            {
                Console.WriteLine("Would you like to reset the recipe?: " + "/n" + "(1) Yes" + "/n" + "(2) No");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the option you scaled the recipe by: " + "/n" + "(1) 0.5" + "/n" + "(2) 2" + "/n" + "(3) 3");
                int scaled = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {

                    iQuantity = int.TryParse(iQuantity) / scaled;
                    iMeasure = " ";

                    Console.WriteLine("Recipe has been cleared, New recipe incoming");
                    Storage();
                }
                else if (option == 2)
                {
                    Console.WriteLine("The recipe is still here");
                }
            }
            catch (Exception input)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter the correct type of value");
            }
        }

        //Clear class to clear all the information from the recipe
        public static void Clear()
        {
            try
            {
                Console.WriteLine("Would you like to clear all the information?: " + "/n" + "(1) Yes" + "/n" + "(2) No");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    iName = " ";
                    iQuantity = " ";
                    iMeasure = " ";
                    rSteps = 0;
                    stepDescrip = " ";
                    numIngredient = 0;
                    Console.WriteLine("All cleared");
                }
                else if (option == 2)
                {
                    Console.WriteLine("The information is still here");
                }
            }
            catch (Exception input)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter the correct type of value");
            }
        }

        //Main class to print out all the classes 
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            
            Storage();
            Recipe();
            Reset();
            Clear();
            
        }
    }
}
