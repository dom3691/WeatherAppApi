using System;

namespace CastleHillPetGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PetCollection petCollection = new PetCollection();

            while (true)
            {
                // Display menu options and handle user input to perform actions
                Console.WriteLine("1. List pets");
                Console.WriteLine("2. Acquire a pet");
                Console.WriteLine("3. Remove a pet");
                Console.WriteLine("4. Feed a pet");
                Console.WriteLine("5. Interact with a pet");
                Console.WriteLine("6. Play with pets");
                Console.WriteLine("7. View pet stats");
                Console.WriteLine("8. Quit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        petCollection.ListPets();
                        break;
                    case "2":
                        // Implement acquiring a pet from the store
                        break;
                    case "3":
                        // Implement removing a pet from the collection
                        break;
                    case "4":
                        // Implement feeding a pet
                        break;
                    case "5":
                        // Implement interacting with a pet
                        break;
                    case "6":
                        // Implement playing with pets
                        break;
                    case "7":
                        // Implement viewing pet stats
                        break;
                    case "8":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            //Console.WriteLine("Hello World!");
        }
    }
}
