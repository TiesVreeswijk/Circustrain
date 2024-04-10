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
            animals.Add(animal);
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
