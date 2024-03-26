using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Dealer
    {
        public int Capacity { get; private set; } = 10;
        public int SmallSize { get; private set; } = 1;
        public int MediumSize { get; private set; } = 3;
        public int LargeSize { get; private set; } = 5;

        public List<Carriage> DistributeAnimals(List<Animal> animals)
        {
            List<Carriage> carriages = new List<Carriage>();

            AddCarnivores(animals, carriages);
            AddMediumHerbivores(animals, carriages);
            FillCarriageWithHerbivores(animals, carriages);
            FillRemainingHerbivores(animals, carriages);
            return carriages;
        }
        public void AddCarnivores(List<Animal> animals, List<Carriage> carriages)
        {
            //elke carnivoor in een eigen carriage
            foreach (Carnivore carnivore in animals.OfType<Carnivore>())
            {
                Carriage carriage = new Carriage();
                carriage.animals.Add(carnivore);
                carriages.Add(carriage);
            }
        }
        public void AddMediumHerbivores(List<Animal> animals, List<Carriage> carriages)
        {
            //zijn er medium carnivoren
            foreach (Carriage carriage in carriages)
            {
                if (HasMediumCarnivore(animals))
                {
                    if (HasLargeHerbivore(animals))
                    {
                        AddLargeHerbivoreToCarriage(carriage, animals);
                    }
                }
            }
        }

        public void FillCarriageWithHerbivores(List<Animal> animals, List<Carriage> carriages)
        {
            //medium en grote herbivoren opvullen bij carnivoren
            bool moreMediumThanLarge = CountMediumHerbivores(animals) > CountLargeHerbivores(animals);
            if (moreMediumThanLarge)
            {
                foreach (Carriage carriage in carriages)
                {
                    if (HasSmallCarnivore(animals))
                    {
                        while (CountMediumHerbivores(animals) != 0 && carriage.GetCurrentSize() + MediumSize <= Capacity)
                        {
                            AddMediumHerbivoreToCarriage(carriage, animals);
                        }
                        while (CountLargeHerbivores(animals) != 0 && carriage.GetCurrentSize() + LargeSize <= Capacity)
                        {
                            AddLargeHerbivoreToCarriage(carriage, animals);
                        }
                    }
                }
            }
            else
            {
                foreach (Carriage carriage in carriages)
                {
                    if (HasSmallCarnivore(animals))
                    {
                        if (carriage.GetCurrentSize() + LargeSize <= Capacity)
                        {
                            if (HasLargeHerbivore(animals))
                            {
                                AddLargeHerbivoreToCarriage(carriage, animals);
                            }
                        }
                        if (carriage.GetCurrentSize() + MediumSize <= Capacity)
                        {
                            if (HasMediumHerbivore(animals))
                            {
                                AddMediumHerbivoreToCarriage(carriage, animals);
                            }
                        }
                    }
                }
            }
        }
        public List<Carriage> FillRemainingHerbivores(List<Animal> animals, List<Carriage> carriages)
        {
            //overige herbivoren in carriages stoppen
            animals.RemoveAll(animal => animal is Carnivore);

            while (animals.Count != 0)
            {
                Carriage carriage = new Carriage();
                while (CountLargeHerbivores(animals) != 0 && carriage.GetCurrentSize() + LargeSize <= Capacity)
                {
                    AddLargeHerbivoreToCarriage(carriage, animals);
                }
                while (CountMediumHerbivores(animals) != 0 && carriage.GetCurrentSize() + MediumSize <= Capacity)
                {
                    AddMediumHerbivoreToCarriage(carriage, animals);
                }
                while (CountSmallHerbivores(animals) != 0 && carriage.GetCurrentSize() + SmallSize <= Capacity)
                {
                    AddSmallHerbivoreToCarriage(carriage, animals);
                }
                carriages.Add(carriage);
            }
            return carriages;
        }
        private bool HasMediumCarnivore(List<Animal> animals)
        {
            return animals.OfType<Carnivore>().Any(carnivore => carnivore.Size == 3);
        }

        private bool HasLargeHerbivore(List<Animal> animals)
        {
            return animals.OfType<Herbivore>().Any(herbivore => herbivore.Size == 5);
        }

        private void AddLargeHerbivoreToCarriage(Carriage carriage, List<Animal> animals)
        {
            Animal largeHerbivore = animals.OfType<Herbivore>().First(herbivore => herbivore.Size == 5);
            carriage.animals.Add(largeHerbivore);
            animals.Remove(largeHerbivore);
        }

        private int CountMediumHerbivores(List<Animal> animals)
        {
            return animals.OfType<Herbivore>().Count(herbivore => herbivore.Size == 3);
        }

        private int CountLargeHerbivores(List<Animal> animals)
        {
            return animals.OfType<Herbivore>().Count(herbivore => herbivore.Size == 5);
        }

        private bool HasSmallCarnivore(List<Animal> animals)
        {
            return animals.OfType<Carnivore>().Any(carnivore => carnivore.Size == 1);
        }

        private void AddMediumHerbivoreToCarriage(Carriage carriage, List<Animal> animals)
        {
            Animal mediumHerbivore = animals.OfType<Herbivore>().First(herbivore => herbivore.Size == 3);
            carriage.animals.Add(mediumHerbivore);
            animals.Remove(mediumHerbivore);
        }

        private bool HasMediumHerbivore(List<Animal> animals)
        {
            return animals.OfType<Herbivore>().Any(herbivore => herbivore.Size == 3);
        }

        private void AddSmallHerbivoreToCarriage(Carriage carriage, List<Animal> animals)
        {
            Animal smallHerbivore = animals.OfType<Herbivore>().First(herbivore => herbivore.Size == 1);
            carriage.animals.Add(smallHerbivore);
            animals.Remove(smallHerbivore);
        }

        private int CountSmallHerbivores(List<Animal> animals)
        {
            return animals.OfType<Herbivore>().Count(herbivore => herbivore.Size == 1);
        }
    }

}

