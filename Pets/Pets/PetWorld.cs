﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
namespace Pets
{
    public class PetWorld
    {
        private List<Pet> petCollection;
        private const int MaxHunger = 10; // Maximum hunger level before pet refuses to interact.
        private const int MaxHappiness = 100; // Maximum happiness level.

        public PetWorld()
        {
            petCollection = new List<Pet>();
        }
        public void Run()
        {
            Title = "====Virtual Pet App ====";
            WriteLine(@"  ____        _             _                  
 |  _ \  ___ | |_  ___     / \    _ __   _ __  
 | |_) |/ _ \| __|/ __|   / _ \  | '_ \ | '_ \ 
 |  __/|  __/| |_ \__ \  / ___ \ | |_) || |_) |
 |_|    \___| \__||___/ /_/   \_\| .__/ | .__/ 
                                 |_|    |_|    
");
            WriteLine("WELCOME TO CASTLE GAMING PET APP!");
            WriteLine("");
            WriteLine("");

            //LEO THE CAT
            Pet leoTheCat = new Pet("Leo", 12, "Cat", true);
            petCollection.Add(leoTheCat);
            //Ths causes an error because "ExperiencePoints" is private:
            //LeoTheCat.ExperiencePoints = 10;
            WriteLine(">>>> PET 1 <<<<");
            leoTheCat.Greet();
            leoTheCat.Eat("Some Dry food");
            WriteLine("");
            WriteLine("");

            //JUNIOR THE PARROT
            Pet juniorTheParrot = new Pet("Junior", 50, "Parrot", false);
            petCollection.Add(juniorTheParrot);
            WriteLine(">>>>Pet 2<<<<");
            juniorTheParrot.Greet();
            juniorTheParrot.Eat("a worm");
            juniorTheParrot.Sleep();
            WriteLine("");
            WriteLine("");

            //CALLIE THE UNICORN
            Pet callieTheUnicorn = new Pet("Callie", 25, "Unicorn", true);
            petCollection.Add(callieTheUnicorn);
            WriteLine(">>>>Pet 3<<<<");
            juniorTheParrot.Greet();
            juniorTheParrot.Eat("a rainbw");
            juniorTheParrot.Sleep();
            WriteLine("");

            bool running = true;
            while (running)
            {
                WriteLine("Select an option:");
                WriteLine("1. List pets in the store");
                WriteLine("2. Acquire pets from a pet store");
                WriteLine("3. Remove pets from your collection");
                WriteLine("4. Feed the pets");
                WriteLine("5. Interact with the pets");
                WriteLine("6. Allow pets to play between themselves");
                WriteLine("7. Request and view the current state of your pets");
                WriteLine("8. Exit");
                char option = ReadKey().KeyChar;
                WriteLine();

                switch (option)
                {
                    case '1':
                        ListPetsInStore();
                        break;
                    case '2':
                        AcquirePets();
                        break;
                    case '3':
                        RemovePets();
                        break;
                    case '4':
                        FeedPets();
                        break;
                    case '5':
                        InteractWithPets();
                        break;
                    case '6':
                        AllowPetsToPlay();
                        break;
                    case '7':
                        RequestAndDisplayPetState();
                        break;
                    case '8':
                        running = false;
                        break;
                    default:
                        WriteLine("Invalid option. Please try again.");
                        break;
                }
            }

            WriteLine("Press Any Key to Exit");
            ReadKey();
        }

        private void ListPetsInStore()
        {
            WriteLine("Pets available in the store:");
            foreach (Pet pet in petCollection)
            {
                WriteLine($"{pet.FullName} - {pet.Species}");
            }
            WriteLine();
        }

        private void AcquirePets()
        {
            WriteLine("Enter the name of the pet you want to acquire:");
            string petName = ReadLine();

            // Check if the pet is available in the store
            Pet petToAcquire = petCollection.FirstOrDefault(p => p.FullName.Equals(petName, StringComparison.OrdinalIgnoreCase));

            if (petToAcquire != null)
            {
                petCollection.Remove(petToAcquire);
                WriteLine($"{petName} has been acquired and added to your collection.");
            }
            else
            {
                WriteLine($"{petName} is not available in the store.");
            }

            WriteLine();
        }

        private void RemovePets()
        {
            WriteLine("Enter the name of the pet you want to remove from your collection:");
            string petName = ReadLine();

            // Check if the pet is in your collection
            Pet petToRemove = petCollection.FirstOrDefault(p => p.FullName.Equals(petName, StringComparison.OrdinalIgnoreCase));

            if (petToRemove != null)
            {
                petCollection.Remove(petToRemove);
                WriteLine($"{petName} has been removed from your collection.");
            }
            else
            {
                WriteLine($"{petName} is not in your collection.");
            }

            WriteLine();
        }

        private void FeedPets()
        {
            WriteLine("Select a pet to feed:");
            int i = 1;
            foreach (Pet pet in petCollection)
            {
                WriteLine($"{i}. {pet.FullName}");
                i++;
            }

            int petIndex;
            if (int.TryParse(ReadLine(), out petIndex) && petIndex >= 1 && petIndex <= petCollection.Count)
            {
                Pet selectedPet = petCollection[petIndex - 1];
                WriteLine("Select a food to feed:");
                WriteLine("1. Bacon Snack");
                WriteLine("2. Dry dog food");
                WriteLine("3. Tuna");
                WriteLine("4. Dry cat food");
                int foodChoice;
                if (int.TryParse(ReadLine(), out foodChoice) && foodChoice >= 1 && foodChoice <= 4)
                {
                    string foodName = "";
                    switch (foodChoice)
                    {
                        case 1:
                            foodName = "Bacon Snack";
                            break;
                        case 2:
                            foodName = "Dry dog food";
                            break;
                        case 3:
                            foodName = "Tuna";
                            break;
                        case 4:
                            foodName = "Dry cat food";
                            break;
                    }

                    // Check if the pet likes the food and apply happiness and hunger effects.
                    int happinessEffect = 0;
                    int hungerEffect = 0;

                    if (selectedPet.Species == "Dog")
                    {
                        if (foodName == "Bacon Snack")
                        {
                            happinessEffect = 3;
                            hungerEffect = 3;
                        }
                        else if (foodName == "Dry dog food")
                        {
                            happinessEffect = -4;
                            hungerEffect = 2;
                        }
                        // Add similar checks for other food types for dogs.
                    }
                    else if (selectedPet.Species == "Cat")
                    {
                        if (foodName == "Bacon Snack")
                        {
                            happinessEffect = 3;
                            hungerEffect = 3;
                        }
                        else if (foodName == "Dry cat food")
                        {
                            happinessEffect = -4;
                            hungerEffect = 2;
                        }
                        // Add similar checks for other food types for cats.
                    }
                    // Add similar checks for other pet species.

                    // Apply the effects to the pet's happiness and hunger levels.
                    selectedPet.HappinessLevel += happinessEffect;
                    selectedPet.HungerLevel += hungerEffect;

                    // Ensure happiness level does not exceed the maximum.
                    if (selectedPet.HappinessLevel > MaxHappiness)
                        selectedPet.HappinessLevel = MaxHappiness;

                    // Ensure hunger level does not go above the maximum.
                    if (selectedPet.HungerLevel > MaxHunger)
                        selectedPet.HungerLevel = MaxHunger;

                    WriteLine($"{selectedPet.FullName} has been fed {foodName}.");
                    WriteLine($"{selectedPet.FullName}'s happiness level: {selectedPet.HappinessLevel}");
                    WriteLine($"{selectedPet.FullName}'s hunger level: {selectedPet.HungerLevel}");
                }
                else
                {
                    WriteLine("Invalid food choice.");
                }
            }
            else
            {
                WriteLine("Invalid pet selection.");
            }

            WriteLine();
        }

        private void InteractWithPets()
        {
            WriteLine("Select a pet to interact with:");
            int i = 1;
            foreach (Pet pet in petCollection)
            {
                WriteLine($"{i}. {pet.FullName}");
                i++;
            }

            int petIndex;
            if (int.TryParse(ReadLine(), out petIndex) && petIndex >= 1 && petIndex <= petCollection.Count)
            {
                Pet selectedPet = petCollection[petIndex - 1];
                WriteLine("Select an interaction:");
                WriteLine("1. Pet");
                WriteLine("2. Rub Belly");
                WriteLine("3. Fetch");
                WriteLine("4. Ignore");
                WriteLine("5. Scold");
                int interactionChoice;
                if (int.TryParse(ReadLine(), out interactionChoice) && interactionChoice >= 1 && interactionChoice <= 5)
                {
                    int happinessEffect = 0;
                    int hungerEffect = 0;

                    // Check for valid interactions based on pet species and apply effects.
                    switch (selectedPet.Species)
                    {
                        case "Dog":
                            switch (interactionChoice)
                            {
                                case 1: // Pet
                                    happinessEffect = 3;
                                    hungerEffect = 3;
                                    break;
                                case 2: // Rub Belly
                                    happinessEffect = 3;
                                    break;
                                case 3: // Fetch
                                    happinessEffect = -4;
                                    hungerEffect = 2;
                                    break;
                                case 4: // Ignore
                                    happinessEffect = -4;
                                    hungerEffect = 2;
                                    break;
                                case 5: // Scold
                                    happinessEffect = -4;
                                    hungerEffect = 2;
                                    break;
                            }
                            break;
                        case "Cat":
                            // Add similar switch cases for interactions with cats.
                            break;
                            // Add cases for other pet species.
                    }

                    // Check and apply the effects to happiness and hunger levels.
                    selectedPet.HappinessLevel += happinessEffect;
                    selectedPet.HungerLevel += hungerEffect;

                    // Ensure happiness level does not go below 0 and does not exceed the maximum.
                    if (selectedPet.HappinessLevel < 0)
                        selectedPet.HappinessLevel = 0;
                    if (selectedPet.HappinessLevel > MaxHappiness)
                        selectedPet.HappinessLevel = MaxHappiness;

                    // Ensure hunger level does not go above the maximum.
                    if (selectedPet.HungerLevel > MaxHunger)
                        selectedPet.HungerLevel = MaxHunger;

                    WriteLine($"{selectedPet.FullName} is interacting.");
                    WriteLine($"{selectedPet.FullName}'s happiness level: {selectedPet.HappinessLevel}");
                    WriteLine($"{selectedPet.FullName}'s hunger level: {selectedPet.HungerLevel}");
                }
                else
                {
                    WriteLine("Invalid interaction choice.");
                }
            }
            else
            {
                WriteLine("Invalid pet selection.");
            }

            WriteLine();

            //WriteLine("Select a pet to interact with:");
            //int i = 1;
            //foreach (Pet pet in petCollection)
            //{
            //    WriteLine($"{i}. {pet.FullName}");
            //    i++;
            //}

            //int petIndex;
            //if (int.TryParse(ReadLine(), out petIndex) && petIndex >= 1 && petIndex <= petCollection.Count)
            //{
            //    Pet selectedPet = petCollection[petIndex - 1];
            //    WriteLine("Select an interaction:");
            //    WriteLine("1. Pet");
            //    WriteLine("2. Rub Belly");
            //    WriteLine("3. Fetch");
            //    WriteLine("4. Ignore");
            //    WriteLine("5. Scold");
            //    int interactionChoice;
            //    if (int.TryParse(ReadLine(), out interactionChoice) && interactionChoice >= 1 && interactionChoice <= 5)
            //    {
            //        int happinessEffect = 0;
            //        int hungerEffect = 0;

            //        switch (interactionChoice)
            //        {
            //            case 1:
            //                selectedPet.Greet();
            //                break;
            //            case 2:
            //                WriteLine($"{selectedPet.FullName} enjoys belly rubs.");
            //                break;
            //            case 3:
            //                WriteLine($"{selectedPet.FullName} plays fetch.");
            //                break;
            //            case 4:
            //                WriteLine($"{selectedPet.FullName} feels ignored.");
            //                break;
            //            case 5:
            //                WriteLine($"{selectedPet.FullName} has been scolded.");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        WriteLine("Invalid interaction choice.");
            //    }
            //}
            //else
            //{
            //    WriteLine("Invalid pet selection.");
            //}

            //WriteLine();
        }

        private void AllowPetsToPlay()
        {
            WriteLine("Select the first pet to play:");
            int i = 1;
            foreach (Pet pet in petCollection)
            {
                WriteLine($"{i}. {pet.FullName}");
                i++;
            }

            int petIndex1;
            if (int.TryParse(ReadLine(), out petIndex1) && petIndex1 >= 1 && petIndex1 <= petCollection.Count)
            {
                Pet pet1 = petCollection[petIndex1 - 1];

                WriteLine("Select the second pet to play:");
                i = 1;
                foreach (Pet pet in petCollection)
                {
                    WriteLine($"{i}. {pet.FullName}");
                    i++;
                }

                int petIndex2;
                if (int.TryParse(ReadLine(), out petIndex2) && petIndex2 >= 1 && petIndex2 <= petCollection.Count)
                {
                    Pet pet2 = petCollection[petIndex2 - 1];

                    // Check if the selected pets are different and allow them to play.
                    if (pet1 != pet2)
                    {
                        // Implement rules for pet interactions here.
                        // You can use a table similar to the one provided earlier for interaction effects.

                        // Example: If both pets are dogs, they have +3 happiness and +3 hunger.

                        // Update pet states based on the rules.
                        // pet1.HappinessLevel += happinessEffectForPet1;
                        // pet1.HungerLevel += hungerEffectForPet1;
                        // pet2.HappinessLevel += happinessEffectForPet2;
                        // pet2.HungerLevel += hungerEffectForPet2;

                        WriteLine($"{pet1.FullName} and {pet2.FullName} are playing together!");
                    }
                    else
                    {
                        WriteLine("You can't select the same pet to play with itself.");
                    }
                }
                else
                {
                    WriteLine("Invalid selection for the second pet.");
                }
            }
            else
            {
                WriteLine("Invalid selection for the first pet.");
            }
            WriteLine();
        }

        private void RequestAndDisplayPetState()
        {
            WriteLine("Current state of your pets:");
            foreach (Pet pet in petCollection)
            {
                pet.Greet();
            }
            WriteLine();
        }

    }
}
