using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // Handle food logic here
        }

        public void Interact(string action)
        {
            // Handle interaction logic here
        }

        // Implement a method to update pet stats over time
        public void UpdateStats()
        {
            // Handle stat updates over time (e.g., increase hunger, decrease happiness)
        }

        internal bool CanPlayWith(Pet pet2)
        {
            throw new NotImplementedException();
        }

        internal void PlayWith(Pet pet2)
        {
            throw new NotImplementedException();
        }
    }
}
