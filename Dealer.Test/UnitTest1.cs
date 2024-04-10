using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    using System.Threading.Tasks;
    using WindowsFormsApp1;
using static WindowsFormsApp1.Animal;


namespace dealer.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DistributeAnimals_Scenario1_WagonCount2()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbivoreCount = 0;
            int mediumHerbivoreCount = 3;
            int largeHerbivoreCount = 2;

            int smallCarnivoreCount = 1;
            int mediumCarnivoreCount = 0;
            int largeCarnivoreCount = 0;


            for (int i = 0; i < smallCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Carnivore));
            }

            for (int i = 0; i < mediumCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Carnivore));
            }

            for (int i = 0; i < largeCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Carnivore));
            }

            for (int i = 0; i < smallHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Herbivore));
            }

            for (int i = 0; i < mediumHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Herbivore));
            }

            for (int i = 0; i < largeHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Herbivore));
            }

            Dealer Dealer = new Dealer();
            List<Wagon> trainWagons = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainWagons.Count == 2);
        }

        [TestMethod]
        public void DistributeAnimals_Scenario2_WagonCount2()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbivoreCount = 5;
            int mediumHerbivoreCount = 2;
            int largeHerbivoreCount = 1;

            int smallCarnivoreCount = 1;
            int mediumCarnivoreCount = 0;
            int largeCarnivoreCount = 0;


            for (int i = 0; i < smallCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Carnivore));
            }

            for (int i = 0; i < mediumCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Carnivore));
            }

            for (int i = 0; i < largeCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Carnivore));
            }

            for (int i = 0; i < smallHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Herbivore));
            }

            for (int i = 0; i < mediumHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Herbivore));
            }

            for (int i = 0; i < largeHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Herbivore));
            }

            Dealer Dealer = new Dealer();
            List<Wagon> trainWagons = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainWagons.Count == 2);
        }

        [TestMethod]
        public void DistributeAnimals_Scenario3_WagonCount4()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbivoreCount = 1;
            int mediumHerbivoreCount = 1;
            int largeHerbivoreCount = 1;

            int smallCarnivoreCount = 1;
            int mediumCarnivoreCount = 1;
            int largeCarnivoreCount = 1;


            for (int i = 0; i < smallCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Carnivore));
            }

            for (int i = 0; i < mediumCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Carnivore));
            }

            for (int i = 0; i < largeCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Carnivore));
            }

            for (int i = 0; i < smallHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Herbivore));
            }

            for (int i = 0; i < mediumHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Herbivore));
            }

            for (int i = 0; i < largeHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Herbivore));
            }

            Dealer Dealer = new Dealer();
            List<Wagon> trainWagons = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainWagons.Count == 4);
        }

        [TestMethod]
        public void DistributeAnimals_Scenario4_WagonCount5()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbivoreCount = 1;
            int mediumHerbivoreCount = 5;
            int largeHerbivoreCount = 1;

            int smallCarnivoreCount = 1;
            int mediumCarnivoreCount = 1;
            int largeCarnivoreCount = 2;


            for (int i = 0; i < smallCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Carnivore));
            }

            for (int i = 0; i < mediumCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Carnivore));
            }

            for (int i = 0; i < largeCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Carnivore));
            }

            for (int i = 0; i < smallHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Herbivore));
            }

            for (int i = 0; i < mediumHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Herbivore));
            }

            for (int i = 0; i < largeHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Herbivore));
            }

            Dealer Dealer = new Dealer();
            List<Wagon> trainWagons = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainWagons.Count == 5);
        }

        [TestMethod]
        public void DistributeAnimals_Scenario5_WagonCount2()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbivoreCount = 1;
            int mediumHerbivoreCount = 1;
            int largeHerbivoreCount = 2;

            int smallCarnivoreCount = 1;
            int mediumCarnivoreCount = 0;
            int largeCarnivoreCount = 0;


            for (int i = 0; i < smallCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Carnivore));
            }

            for (int i = 0; i < mediumCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Carnivore));
            }

            for (int i = 0; i < largeCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Carnivore));
            }

            for (int i = 0; i < smallHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Herbivore));
            }

            for (int i = 0; i < mediumHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Herbivore));
            }

            for (int i = 0; i < largeHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Herbivore));
            }

            Dealer Dealer = new Dealer();
            List<Wagon> trainWagons = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainWagons.Count == 2);
        }

        [TestMethod]
        public void DistributeAnimals_Scenario6_WagonCount3()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbivoreCount = 0;
            int mediumHerbivoreCount = 2;
            int largeHerbivoreCount = 3;

            int smallCarnivoreCount = 3;
            int mediumCarnivoreCount = 0;
            int largeCarnivoreCount = 0;


            for (int i = 0; i < smallCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Carnivore));
            }

            for (int i = 0; i < mediumCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Carnivore));
            }

            for (int i = 0; i < largeCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Carnivore));
            }

            for (int i = 0; i < smallHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Herbivore));
            }

            for (int i = 0; i < mediumHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Herbivore));
            }

            for (int i = 0; i < largeHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Herbivore));
            }

            Dealer Dealer = new Dealer();
            List<Wagon> trainWagons = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainWagons.Count == 3);
        }

        [TestMethod]
        public void DistributeAnimals_Scenario7_WagonCount13()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbivoreCount = 0;
            int mediumHerbivoreCount= 5;
            int largeHerbivoreCount = 6;

            int smallCarnivoreCount = 7;
            int mediumCarnivoreCount= 3;
            int largeCarnivoreCount = 3;


            for (int i = 0; i < smallCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Carnivore));
            }

            for (int i = 0; i < mediumCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Carnivore));
            }

            for (int i = 0; i < largeCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Carnivore));
            }

            for (int i = 0; i < smallHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Herbivore));
            }

            for (int i = 0; i < mediumHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Herbivore));
            }

            for (int i = 0; i < largeHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Herbivore));
            }

            Dealer Dealer = new Dealer();
            List<Wagon> trainWagons = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainWagons.Count == 13);
        }
        [TestMethod]
        public void DistributeAnimals_Scenario8_WagonCount2()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbivoreCount = 5;
            int mediumHerbivoreCount = 3;
            int largeHerbivoreCount = 1;

            int smallCarnivoreCount = 0;
            int mediumCarnivoreCount = 0;
            int largeCarnivoreCount = 0;


            for (int i = 0; i < smallCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Carnivore));
            }

            for (int i = 0; i < mediumCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Carnivore));
            }

            for (int i = 0; i < largeCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Carnivore));
            }

            for (int i = 0; i < smallHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Herbivore));
            }

            for (int i = 0; i < mediumHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Herbivore));
            }

            for (int i = 0; i < largeHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Herbivore));
            }

            Dealer Dealer = new Dealer();
            List<Wagon> trainWagons = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainWagons.Count == 2);
        }
        [TestMethod]
        public void DistributeAnimals_Scenario9_WagonCount6()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbivoreCount = 0;
            int mediumHerbivoreCount = 0;
            int largeHerbivoreCount = 3;

            int smallCarnivoreCount = 1;
            int mediumCarnivoreCount = 3;
            int largeCarnivoreCount = 2;


            for (int i = 0; i < smallCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Carnivore));
            }

            for (int i = 0; i < mediumCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Carnivore));
            }

            for (int i = 0; i < largeCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Carnivore));
            }

            for (int i = 0; i < smallHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Herbivore));
            }

            for (int i = 0; i < mediumHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Herbivore));
            }

            for (int i = 0; i < largeHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Herbivore));
            }

            Dealer Dealer = new Dealer();
            List<Wagon> trainWagons = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainWagons.Count == 6);
        }
        [TestMethod]
        public void DistributeAnimals_Scenario10_WagonCount2()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbivoreCount = 1;
            int mediumHerbivoreCount = 3;
            int largeHerbivoreCount = 2;

            int smallCarnivoreCount = 0;
            int mediumCarnivoreCount =0;
            int largeCarnivoreCount = 0;


            for (int i = 0; i < smallCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Carnivore));
            }

            for (int i = 0; i < mediumCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Carnivore));
            }

            for (int i = 0; i < largeCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Carnivore));
            }

            for (int i = 0; i < smallHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Herbivore));
            }

            for (int i = 0; i < mediumHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Herbivore));
            }

            for (int i = 0; i < largeHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Herbivore));
            }

            Dealer Dealer = new Dealer();
            List<Wagon> trainWagons = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainWagons.Count == 2);
        }
        [TestMethod]
        public void DistributeAnimals_Scenario11_WagonCount2()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbivoreCount = 0;
            int mediumHerbivoreCount = 3;
            int largeHerbivoreCount = 2;

            int smallCarnivoreCount = 1;
            int mediumCarnivoreCount = 0;
            int largeCarnivoreCount = 0;


            for (int i = 0; i < smallCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Carnivore));
            }

            for (int i = 0; i < mediumCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Carnivore));
            }

            for (int i = 0; i < largeCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Carnivore));
            }

            for (int i = 0; i < smallHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Herbivore));
            }

            for (int i = 0; i < mediumHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Herbivore));
            }

            for (int i = 0; i < largeHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Herbivore));
            }

            Dealer Dealer = new Dealer();
            List<Wagon> trainWagons = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainWagons.Count == 2);
        }
        [TestMethod]
        public void DistributeAnimals_Scenario12_WagonCount2()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbivoreCount = 0;
            int mediumHerbivoreCount = 2;
            int largeHerbivoreCount = 2;

            int smallCarnivoreCount = 2;
            int mediumCarnivoreCount = 0;
            int largeCarnivoreCount = 0;


            for (int i = 0; i < smallCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Carnivore));
            }

            for (int i = 0; i < mediumCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Carnivore));
            }

            for (int i = 0; i < largeCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Carnivore));
            }

            for (int i = 0; i < smallHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Herbivore));
            }

            for (int i = 0; i < mediumHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Herbivore));
            }

            for (int i = 0; i < largeHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Herbivore));
            }

            Dealer Dealer = new Dealer();
            List<Wagon> trainWagons = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainWagons.Count == 2);
        }
        [TestMethod]
        public void DistributeAnimals_Scenario13_WagonCount3()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbivoreCount = 0;
            int mediumHerbivoreCount = 6;
            int largeHerbivoreCount = 2;

            int smallCarnivoreCount = 2;
            int mediumCarnivoreCount = 0;
            int largeCarnivoreCount = 0;


            for (int i = 0; i < smallCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Carnivore));
            }

            for (int i = 0; i < mediumCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Carnivore));
            }

            for (int i = 0; i < largeCarnivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Carnivore));
            }

            for (int i = 0; i < smallHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Small, DietType.Herbivore));
            }

            for (int i = 0; i < mediumHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Middle, DietType.Herbivore));
            }

            for (int i = 0; i < largeHerbivoreCount; i++)
            {
                animals.Add(new Animal(AnimalSize.Large, DietType.Herbivore));
            }

            Dealer Dealer = new Dealer();
            List<Wagon> trainWagons = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainWagons.Count == 3);
        }
    }
}

