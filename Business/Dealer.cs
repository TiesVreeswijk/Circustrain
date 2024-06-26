﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.Animal;

namespace WindowsFormsApp1
{
    public class Dealer
    {
        public IReadOnlyCollection<Wagon> Wagons => _wagons.AsReadOnly();
        //public int Capacity { get; private set; } = 10;
        private List<Wagon> _wagons = new List<Wagon>();

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

            return _wagons;
        }
        
        private void AddCarnivores(List<Animal> carnivores)
        {
            //elke carnivoor in een eigen wagon
            foreach (Animal animal in carnivores)
            {
                Wagon wagon = new Wagon();
                wagon.TryToAddAnimal(animal);
                _wagons.Add(wagon);
            }
        }

        private void AddLargeHerbivores(List<Animal> animals, List<Animal> largeHerbivores)
        {
            //zijn er medium carnivoren
            foreach (Wagon wagon in _wagons)
            {
                if (!largeHerbivores.Any()) break;

                if (wagon.ContainsAnimalOfSizeAndDiet(AnimalSize.Middle, DietType.Carnivore))
                {
                    Animal largeHerbivore = largeHerbivores.FirstOrDefault();
                    if(wagon.TryToAddAnimal(largeHerbivore))
                    {
                        largeHerbivores.Remove(largeHerbivore);
                    }

                }   
            }
        }

        private void FillWagonWithHerbivores(List<Animal> animals, List<Animal> middleHerbivores, List<Animal> largeHerbivores)
        {
            // Determine the order of preference for adding _animals based on their count
            var preferredOrder = middleHerbivores.Count > largeHerbivores.Count
                                 ? new[] { AnimalSize.Middle, AnimalSize.Large }
                                 : new[] { AnimalSize.Large, AnimalSize.Middle };

            foreach (Wagon wagon in _wagons)
            {
                if (wagon.ContainsAnimalOfSizeAndDiet(AnimalSize.Small, DietType.Carnivore))
                {
                    foreach (var size in preferredOrder)
                    {
                        FillWagonWithHerbivoresBySize(wagon, size == AnimalSize.Middle ? middleHerbivores : largeHerbivores, size);
                    }
                }
            }
        }

        private void FillWagonWithHerbivoresBySize(Wagon wagon, List<Animal> herbivores, AnimalSize size)
        {
            while (herbivores.Any())
            {
                var herbivore = herbivores.FirstOrDefault();
                if (wagon.TryToAddAnimal(herbivore))
                {
                    herbivores.Remove(herbivore);
                }
                else break;
            }
        }


        private List<Wagon> FillRemainingHerbivores(List<Animal> smallHerbivores, List<Animal> middleHerbivores, List<Animal> largeHerbivores)
        {
            List<Animal> animals = new List<Animal>();
            animals.AddRange(largeHerbivores);
            animals.AddRange(middleHerbivores);
            animals.AddRange(smallHerbivores);
            while (animals.Count != 0)
            {
                Wagon wagon = new Wagon();
                while (largeHerbivores.Count != 0)
                {
                    Animal largeHerbivore = largeHerbivores.FirstOrDefault();
                    if (wagon.TryToAddAnimal(largeHerbivore))
                    {
                        largeHerbivores.Remove(largeHerbivore);
                        animals.Remove(largeHerbivore);
                    }
                    else break;
                }

                while (middleHerbivores.Count != 0)
                {
                    Animal animal = middleHerbivores.FirstOrDefault();
                    if (wagon.TryToAddAnimal(animal))
                    {
                        middleHerbivores.Remove(animal);
                        animals.Remove(animal);
                    }
                    else break;
                }

                while (smallHerbivores.Count != 0)
                {
                    Animal animal = smallHerbivores.FirstOrDefault();
                    if (wagon.TryToAddAnimal(animal))
                    {
                        smallHerbivores.Remove(animal);
                        animals.Remove(animal);
                    }
                    else break;
                }
                _wagons.Add(wagon);
            }

            return _wagons;
        }
    }
}

   





