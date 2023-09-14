using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pets
{
    public class Pet
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public bool IsAwake { get; set; }
        private int ExperiencePoints { get; set; }

        public Pet(string petName, int petAge, string petSpecies, bool petIsAwake)
        {
            // WriteLine("Pet being constructed");
            FullName = petName;
            Age = petAge;
            Species = petSpecies;
            IsAwake = petIsAwake;
        }

        public void Greet()
        {
            WriteLine($"My Name is {FullName}, the {Species}");
            WriteLine($"I am {Age} years old.");
            WriteLine($"Is awake? {IsAwake}");
        }

        public void Sleep()
        {
            IsAwake = false;
            WriteLine($"{FullName} is now hapilly snorring...Zzzz");
        }

        public void Eat(string foodName)
        {
            WriteLine($"{FullName} is now eating{foodName}.");
        }


    }
}
