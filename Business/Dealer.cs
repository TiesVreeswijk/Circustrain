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
            AddLargeHerbivores(largeHerbivores);
            FillWagonWithHerbivores(animals, wagons);
            FillRemainingHerbivores(animals, wagons);
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

        public void AddLargeHerbivores(List<Animal> largeherbivores)
        {
            //zijn er medium carnivoren
            foreach (Wagon wagon in wagons)
            {
                if (wagon.ContainsAnimalOfSizeAndDiet(animals, AnimalSize.Middle, DietType.Carnivore) && largeHerbivores)
                {
                    if ()
                    {
                        wagon.AddAnimal(animal);
                    }
                }   
            }
        }

        public void FillWagonWithHerbivores(List<Animal> animals, List<Wagon> wagons)
        {
            //medium en grote herbivoren opvullen bij carnivoren
            bool moreMediumThanLarge = CountMediumHerbivores(animals) > CountLargeHerbivores(animals);
            if (moreMediumThanLarge)
            {
                foreach (Wagon wagon in wagons)
                {
                    if (HasSmallCarnivore(animals))
                    {
                        while (CountMediumHerbivores(animals) != 0 && (int)wagon.GetCurrentSize() + (int)MediumSize <= Capacity)
                        {
                            AddMediumHerbivoreToWagon(wagon, animals);
                        }
                        while (CountLargeHerbivores(animals) != 0 && (int)wagon.GetCurrentSize() + (int)LargeSize <= Capacity)
                        {
                            AddLargeHerbivoreToWagon(wagon, animals);
                        }
                    }
                }
            }
            else
            {
                foreach (Wagon wagon in wagons)
                {
                    if (HasSmallCarnivore(animals))
                    {
                        if (wagon.GetCurrentSize() + (int)LargeSize <= Capacity)
                        {
                            if (HasLargeHerbivore(animals))
                            {
                                AddLargeHerbivoreToWagon(wagon, animals);
                            }
                        }
                        if (wagon.GetCurrentSize() + (int)MediumSize <= Capacity)
                        {
                            if (HasMediumHerbivore(animals))
                            {
                                AddMediumHerbivoreToWagon(wagon, animals);
                            }
                        }
                    }
                }
            }
        }

        public List<Wagon> FillRemainingHerbivores(List<Animal> animals, List<Wagon> wagons)
        {
            //overige herbivoren in wagons stoppen
            animals.RemoveAll(animal => animal is Carnivore);

            while (animals.Count != 0)
            {
                Wagon wagon = new Wagon();
                while (CountLargeHerbivores(animals) != 0 && (int)wagon.GetCurrentSize() + (int)LargeSize <= Capacity)
                {
                    AddLargeHerbivoreToWagon(wagon, animals);
                }
                while (CountMediumHerbivores(animals) != 0 && (int)wagon.GetCurrentSize() + (int)MediumSize <= Capacity)
                {
                    AddMediumHerbivoreToWagon(wagon, animals);
                }
                while (CountSmallHerbivores(animals) != 0 && (int)wagon.GetCurrentSize() + (int)SmallSize <= Capacity)
                {
                    AddSmallHerbivoreToWagon(wagon, animals);
                }
                wagons.Add(wagon);
            }
            return wagons;
        }
    }
}

   





