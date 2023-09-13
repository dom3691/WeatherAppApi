using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleHillPetGame
{
    public class PetCollection
    {

        public class Dog : Pet
        {
            public Dog(string name) : base(name, 10, 10)
            {
                // Dog-specific initialization here
            }

            // Implement Dog-specific methods and behaviors
        }

        public class Cat : Pet
        {
            public Cat(string name) : base(name, 8, 5)
            {
                // Cat-specific initialization here
            }

            public void Purr()
            {
                Console.WriteLine($"{Name} is purring.");
                // Implement cat-specific purring behavior here
            }
        }

        private List<Pet> pets;

        public PetCollection()
        {
            pets = new List<Pet>();
        }

        public void AcquirePet(string name, string type)
        {
            if (type == "Dog")
            {
                pets.Add(new Dog(name));
            }
            else if (type == "Cat")
            {
                pets.Add(new Cat(name));
            }
        }

        public void RemovePet(string name)
        {
            // Remove a pet from the collection by  // Remove a pet from the collection by name
            Pet petToRemove = pets.FirstOrDefault(p => p.Name == name);
            if (petToRemove != null)
            {
                pets.Remove(petToRemove);
                Console.WriteLine($"{name} has been removed from your collection.");
            }
            else
            {
                Console.WriteLine($"{name} not found in your collection.");
            }
        }

        public void ListPets()
        {
            // Display a list of pets in the collection
        }

        public void PlayWithPets(string pet1Name, string pet2Name)
        {
            Pet pet1 = pets.FirstOrDefault(p => p.Name == pet1Name);
            Pet pet2 = pets.FirstOrDefault(p => p.Name == pet2Name);

            if (pet1 != null && pet2 != null)
            {
                // Check if pets can play together (based on your rules)
                if (pet1.CanPlayWith(pet2))
                {
                    // Implement play logic
                    pet1.PlayWith(pet2);
                    Console.WriteLine($"{pet1.Name} and {pet2.Name} are playing together!");
                }
                else
                {
                    Console.WriteLine($"{pet1.Name} and {pet2.Name} can't play together.");
                }
            }
            else
            {
                Console.WriteLine("One or both of the specified pets are not in your collection.");
            }
        }

        public void ViewPetStats(string name)
        {
            public void ViewPetStats(string name)
            {
                Pet petToView = pets.FirstOrDefault(p => p.Name == name);
                if (petToView != null)
                {
                    Console.WriteLine($"Name: {petToView.Name}");
                    Console.WriteLine($"Hunger: {petToView.Hunger}/{petToView.MaxHunger}");
                    Console.WriteLine($"Happiness: {petToView.Happiness}/{petToView.MaxHappiness}");
                }
                else
                {
                    Console.WriteLine($"{name} not found in your collection.");

                }

            }
        }
    }
}
