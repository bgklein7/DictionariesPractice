using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Syntax - Dictionary<key data type, value data type> dictionaryName
            //Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            //{
            //    //note comma between key data pairs
            //    { "Carrie", 90 }, //"Carrie" is the key and 90 is the value
            //    { "Barry", 85},
            //    { "Michelle", 100}
            //};

            //Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            //{
            //    {"A1", "Snickers" },
            //    {"A2", "Swedish Fish" },
            //    {"A3", "Sour Patch Kids" },
            //    {"A4", "Funyuns" }
            //};

            //Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            ////Using the Add method, let's add drinks to our drink machine.
            ////This machine uses just a number to vend an item instead of
            ////a letter-number combination.

            //drinkMachine.Add(10, "Ginger Ale");
            //drinkMachine.Add(11, "Glenlivet");
            //drinkMachine.Add(12, "Commodore Perry");
            //drinkMachine.Add(13, "Pappy Van Winkle");
            //drinkMachine.Add(14, "Four Roses");
            //drinkMachine.Add(15, "Palate Wrecker");

            ////.Count is a property.  Returns the size of the dictionary.
            //Console.WriteLine(drinkMachine.Count);

            ////We have another property, called .Key.  Prints the keys of the key value pair
            //foreach(KeyValuePair<int, string> drink in drinkMachine)
            //{
            //    Console.WriteLine(drink.Key);

            //}

            ////.Value property prints values of the key value pair
            //foreach(KeyValuePair<int, string> drink in drinkMachine)
            //{
            //    Console.WriteLine(drink.Value);
            //}

            ////Create a dictionary for a theater coat check with 10 elements.
            ////The key will be a number and the value will be the coat style.
            ////Print all values to the console

            //Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            //{
            //    {1, "Bomber Jacket" },
            //    {2, "Track Jacket" },
            //    {3, "Trench Coat" },
            //    {4, "Pea Coat" },
            //    {5, "Wind Breaker" },
            //    {6, "Soft Shell" },
            //    {7, "MacIntosh" },
            //    {8, "Rain Coat" },
            //    {9, "Fleece" },
            //    { 10, "Top Coat"}
            //};

            //foreach(KeyValuePair<int, string> coats in coatCheck)
            //{
            //    Console.WriteLine(coats.Value);
            //}

            //Dictionary<string, string> valetService = new Dictionary<string, string>()
            //{
            //    {"Klein", "Aston Martin" },
            //    {"Parlanti", "Volkswagen" },
            //    {"Olivo", "Jeep" },
            //    {"Kainec", "Toyota" },
            //    {"Gibson", "Kia" },
            //    {"Sweet", "Fiat" },
            //    {"Lacey", "BMW" },
            //    {"Romeo", "Buick" },
            //    {"Wilson", "Hyundai" },
            //    {"Rostocil", "Subaru" }
            //};

            //foreach(KeyValuePair<string, string> people in valetService)
            //{
            //    Console.WriteLine(people.Key);
            //}

            //Create a dictionary of 10 zoo animals.  The key will be
            //the animal type and the value will be the number of that
            //animal type at the zoo.  Print the animal with the highest
            //quantity to the console.

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>()
            {
                {"manatee", 5 },
                {"tiger", 3 },
                {"grizzly bear", 2 },
                {"polar bear", 1 },
                {"hippopatumus", 2 },
                {"penguin", 13 },
                {"giraffe", 3 },
                {"emu", 7 },
                {"elephant", 5 },
                {"liger", 3 }

            };

            int highest = 0;
            foreach(KeyValuePair<string, int> animal in zooAnimals)
            {
                if(animal.Value > highest)
                {
                    highest = animal.Value;
                }
            }

            foreach(KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value == highest)
                {
                    Console.WriteLine(animal.Key);
                }
            }

            int lowest = 100;
            foreach (KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value < lowest)
                {
                    lowest = animal.Value;
                }
            }

            foreach (KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value == lowest)
                {
                    Console.WriteLine(animal.Key);
                    
                }
            }
            //zooAnimals.Remove(Console.ReadLine());
            Console.WriteLine(zooAnimals.Count);

            Console.WriteLine("Please enter an animal name to check if zoo has it.");
            string userInput = Console.ReadLine().ToLower();

            
                if (zooAnimals.ContainsKey(userInput))
                {
                Console.WriteLine("The zoo has a " + userInput);
                }
                else

                {
                Console.WriteLine("The zoo does not currently have a " + userInput + ". Would you like to add one? (Yes or No");
                string userResponse = Console.ReadLine().ToUpper();
                    if (userResponse == "YES")
                    {
                    zooAnimals.Add(userInput, 1);
                    }
                    
            
        }
            
            foreach(KeyValuePair<string, int> animal in zooAnimals)
            {
                Console.WriteLine(animal.Key);
            }






        }
    }
}
