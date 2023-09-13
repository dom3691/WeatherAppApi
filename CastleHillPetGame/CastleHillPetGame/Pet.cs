using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CastleHillPetGame
{
    public class Pet
    {
        public string Name { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int MaxHunger { get; }
        public int MaxHappiness { get; }

        public Pet(string name, int maxHunger, int maxHappiness)
        {
            Name = name;
            MaxHunger = maxHunger;
            MaxHappiness = maxHappiness;
            Hunger = 2; // Starting hunger level
            Happiness = 5; // Starting happiness level
        }

        // Implement methods for feeding and interacting with pets
        public void Feed(string food)
        {
            Pet petToFeed = pets.FirstOrDefault(p => p.Name == name);
            if (petToFeed != null)
            {
                petToFeed.Feed(food);
                Console.WriteLine($"{petToFeed.Name} has been fed {food}.");
            }
            else
            {
                Console.WriteLine($"{name} not found in your collection.");
            }
        }

        public void Interact(string action)
        {
            Pet petToInteract = pets.FirstOrDefault(p => p.Name == name);
            if (petToInteract != null)
            {
                petToInteract.Interact(action);
                Console.WriteLine($"{petToInteract.Name} has been interacted with using {action}.");
            }
            else
            {
                Console.WriteLine($"{name} not found in your collection.");
            }
        }

        // Implement a method to update pet stats over time
        public void UpdateStats()
        {
            // Handle stat updates over time (e.g., increase hunger, decrease happiness)
        }   
    }
}
