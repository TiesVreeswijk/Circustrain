using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.Animal;

namespace WindowsFormsApp1
{
    public class Dealer
    {

        public int Capacity { get; private set; } = 10;
        List<Wagon> wagons = new List<Wagon>();

        public List<Wagon> DistributeAnimals(List<Animal> animals)
        {
            List<Animal> carnivores = animals.Where(animal => animal.Diet == Animal.DietType.Carnivore).ToList();
            List<Animal> herbivores = animals.Where(animal => animal.Diet == Animal.DietType.Herbivore).ToList();

            List<Animal> largeHerbivores = herbivores.Where(animal => animal.Size == AnimalSize.Large).ToList();
            List<Animal> middleHerbivores = herbivores.Where(animal => animal.Size == AnimalSize.Middle).ToList();
            List<Animal> smallHerbivores = herbivores.Where(animal => animal.Size == AnimalSize.Small).ToList();

            List<Animal> largeCarnivores = carnivores.Where(animal => animal.Size == AnimalSize.Large).ToList();
            List<Animal> middleCarnivores = carnivores.Where(animal => animal.Size == AnimalSize.Middle).ToList();
            List<Animal> smallCarnivores = carnivores.Where(animal => animal.Size == AnimalSize.Small).ToList();



            AddCarnivores(carnivores);
            AddLargeHerbivores(animals , largeHerbivores);
            FillWagonWithHerbivores(animals, middleHerbivores, largeHerbivores);
            FillRemainingHerbivores(smallHerbivores, middleHerbivores, largeHerbivores);
            return wagons;
        }

        public void AddCarnivores(List<Animal> carnivores)
        {
            //elke carnivoor in een eigen wagon
            foreach (Animal animal in carnivores)
            {
                Wagon wagon = new Wagon();
                wagon.animals.Add(animal);
                wagons.Add(wagon);
            }
        }

        public void AddLargeHerbivores(List<Animal> animals, List<Animal> largeHerbivores)
        {
            //zijn er medium carnivoren
            foreach (Wagon wagon in wagons)
            {
                if (wagon.ContainsAnimalOfSizeAndDiet(animals, AnimalSize.Middle, DietType.Carnivore) && largeHerbivores.Any())
                {
                    Animal largeHerbivore = largeHerbivores.FirstOrDefault();
                    wagon.AddAnimal(largeHerbivore);
                    largeHerbivores.Remove(largeHerbivore);
                }   
            }
        }

        public void FillWagonWithHerbivores(List<Animal> animals, List<Animal> middleHerbivores, List<Animal>largeHerbivores)
        {
            //medium en grote herbivoren opvullen bij carnivoren
            bool moreMediumThanLarge = middleHerbivores.Count > largeHerbivores.Count;
            if (moreMediumThanLarge)
            {
                foreach (Wagon wagon in wagons)
                {
                    if (wagon.ContainsAnimalOfSizeAndDiet(animals, AnimalSize.Small, DietType.Carnivore))
                    {
                        while (middleHerbivores.Any() && (int)wagon.GetCurrentSize() + (int)AnimalSize.Middle <= Capacity)
                        {
                            Animal middleHerbivore = middleHerbivores.FirstOrDefault();
                            wagon.AddAnimal(middleHerbivore);
                            middleHerbivores.Remove(middleHerbivore);
                        }
                        if (largeHerbivores.Any() && (int)wagon.GetCurrentSize() + (int)AnimalSize.Large <= Capacity)
                        {
                            Animal largeHerbivore = largeHerbivores.FirstOrDefault();
                            wagon.AddAnimal(largeHerbivore);
                            largeHerbivores.Remove(largeHerbivore);
                        }
                    }
                }
            }
            else
            {
                foreach (Wagon wagon in wagons)
                {
                    if (wagon.ContainsAnimalOfSizeAndDiet(animals, AnimalSize.Small, DietType.Carnivore))
                    {
                        while (largeHerbivores.Any() && (int)wagon.GetCurrentSize() + (int)AnimalSize.Large <= Capacity)
                        {
                            Animal largeHerbivore = largeHerbivores.FirstOrDefault();
                            wagon.AddAnimal(largeHerbivore);
                            largeHerbivores.Remove(largeHerbivore);
                        }
                        if (middleHerbivores.Any() && (int)wagon.GetCurrentSize() + (int)AnimalSize.Middle <= Capacity)
                        {
                            Animal middleHerbivore = middleHerbivores.FirstOrDefault();
                            wagon.AddAnimal(middleHerbivore);
                            middleHerbivores.Remove(middleHerbivore);
                        }
                    }
                }
            }
        }

        public void FillRemainingHerbivores(List<Animal> smallHerbivores, List<Animal> mediumHerbivores, List<Animal> largeHerbivores)
        {
            foreach (Wagon wagon in wagons)
            {
                while (largeHerbivores.Any() && (int)wagon.GetCurrentSize() + (int)AnimalSize.Large <= Capacity)
                {
                    Animal herbivore = largeHerbivores.FirstOrDefault();
                    wagon.AddAnimal(herbivore);
                    largeHerbivores.Remove(herbivore);
                }
                while (mediumHerbivores.Any() && (int)wagon.GetCurrentSize() + (int)AnimalSize.Middle <= Capacity)
                {
                    Animal herbivore = mediumHerbivores.FirstOrDefault();
                    wagon.AddAnimal(herbivore);
                    mediumHerbivores.Remove(herbivore);
                }
                while (smallHerbivores.Any() && (int)wagon.GetCurrentSize() + (int)AnimalSize.Small <= Capacity)
                {
                    Animal herbivore = smallHerbivores.FirstOrDefault();
                    wagon.AddAnimal(herbivore);
                    smallHerbivores.Remove(herbivore);
                }
            }
        }
    }
}

   





