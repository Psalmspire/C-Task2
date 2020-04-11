using System.Collections.Generic;
using System;
using System.Collections.Specialized;


namespace Bar
{
    class Program
    {
       public static void Main(string[] args)
        {
            int age = 0;

            /*string[] drinkType = new string [2];
            drinkType [0] = "Softdrinks";
            drinkType [1] = "Alcoholicdrinks";
            */
             StringCollection Softdrinks = new StringCollection(); //This is a string Array
             
             String[] myArr = new String[]{"Fanta","coke","7up","Pepsi","Smoov","La Casera","Schweppes","Sprite"}; 

             Softdrinks.AddRange(myArr); //Copying elements of a string array to the end of a StringCollection

              List<string> Alcoholicdrinks = new List<string>(); //This a String List
              Alcoholicdrinks.Add("Wine");
              Alcoholicdrinks.Add("Vodka");
              Alcoholicdrinks.Add("Mead");              
              Alcoholicdrinks.Add("Beer");
              Alcoholicdrinks.Add("Spirits");
              Alcoholicdrinks.Add("Rum");
              Alcoholicdrinks.Add("Liquor");
              Alcoholicdrinks.Add("Gin");
              Alcoholicdrinks.Add("Brandy");
              Alcoholicdrinks.Add("Whiskey");              


          //Console.WriteLine(drinkType[0]);    
         // Console.WriteLine(Softdrinks[5]);    

            Console.WriteLine("Welcome to Psalspire's Bar and Lounge.");

            Console.WriteLine("We would like to know your age in line with best practices around the world.");

            Console.Write("Kindly state your age to know if you are old enough to drink in this bar: ");

            age = int.Parse(Console.ReadLine());
            

            if (age >= 18)
            {
                Console.WriteLine("Welcome! You are old enough to drink in this bar.");
                Console.WriteLine("What type of drink would you like to have? We have a variety of drinks in stock");
                Console.WriteLine("This are the drinks we have in stock:");
                
                for (int i = 0; i < Softdrinks.Count; i++){
                    Console.WriteLine("Soft Drink: "+Softdrinks[i]);
                }
                for (int i = 0; i < Alcoholicdrinks.Count; i++)
                {
                    Console.WriteLine("Alchololic drink: "+Alcoholicdrinks[i]);
                } 
                
            }

            else if(age < 11)
	        {
                Console.WriteLine("You're too young to drink here. We would have to contact your parents!");
            }

            else
            {
                Console.WriteLine("Kindly be informed that you can only buy Soft drinks in this bar at your age .");
                Console.WriteLine("What type of drink would you like to have? We have a variety of drinks in stock");
                 for (int i = 0; i < Softdrinks.Count; i++){
                Console.WriteLine(Softdrinks[i]);
                }
                
            }
            
        }
    }
}
