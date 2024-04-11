using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.Animal;

namespace WindowsFormsApp1
{
    public class Wagon
    {
        public const int MaxCapacity = 10;
        public IReadOnlyCollection<Animal> Animals => _animals.AsReadOnly();
        private List<Animal> _animals = new List<Animal>();

        private int GetAnimalPoints(Animal animal)
        {
            return (int)animal.Size;
        }
        
        public int CalculateWagonSize()
        {
            int totalSize = 0;
            foreach (Animal animal in Animals)
            {
                totalSize += GetAnimalPoints(animal);
            }

            return totalSize;
        }

        public bool TryToAddAnimal(Animal animal)
        {
            if ((int)animal.Size + CalculateWagonSize() <= MaxCapacity)
            {
                bool canAddAnimal = true;
                foreach (Animal animalInWagon in Animals)
                {

                    if (animalInWagon.Diet == DietType.Carnivore && animal.Diet == DietType.Herbivore && animal.Size <= animalInWagon.Size)
                    {
                        canAddAnimal = false;
                        break;
                    }
                }

                if (canAddAnimal)
                {
                    _animals.Add(animal);
                }

                return canAddAnimal;
            }
            else return false;
        }

        public bool ContainsAnimalOfSizeAndDiet(AnimalSize size, DietType diet)
        {
            foreach (Animal animal in _animals)
            {
                if (animal.Size == size && animal.Diet == diet)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
