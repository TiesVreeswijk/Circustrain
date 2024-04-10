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
        private int maxCapacity = 10;
        public List<Animal> animals = new List<Animal>();

        private int GetAnimalPoints(Animal animal)
        {
            return (int)animal.Size;
        }
        
        public int CalculateWagonSize()
        {
            int totalSize = 0;
            foreach (Animal animal in animals)
            {
                totalSize += GetAnimalPoints(animal);
            }

            return totalSize;
        }

        public void AddAnimal(Animal animal)
        {
            bool canAddAnimal = true;
            if ((int)animal.Size + CalculateWagonSize() <= maxCapacity)
            {
                foreach (Animal animalInWagon in animals)
                {

                    if (animalInWagon.Diet == DietType.Carnivore && animal.Diet == DietType.Herbivore && animal.Size <= animalInWagon.Size)
                    {
                        canAddAnimal = false;
                    }
                }
                if (canAddAnimal)
                {
                    animals.Add(animal);
                }
            }
        }

        public bool ContainsAnimalOfSizeAndDiet(List<Animal> animals, AnimalSize size, DietType diet)
        {
            foreach (Animal animal in animals)
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
