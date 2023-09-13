using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleHillPetGame
{
    public class PetCollection
    {
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
            // Remove a pet from the collection by name
        }

        public void ListPets()
        {
            // Display a list of pets in the collection
        }

        public void PlayWithPets(string pet1Name, string pet2Name)
        {
            // Implement logic for pets playing together
        }

        public void ViewPetStats(string name)
        {
            // Display the current state of a pet
        }
    }
}
