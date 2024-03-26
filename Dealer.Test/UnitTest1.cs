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
        public void TestMethod1()
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
        public void TestMethod2()
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
        public void TestMethod3()
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
        public void TestMethod4()
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
        public void TestMethod5()
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
        public void TestMethod6()
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
        public void TestMethod7()
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
        public void TestMethod8()
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
        public void TestMethod9()
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
        public void TestMethod10()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbivoreCount = 5;
            int mediumHerbivoreCount = 5;
            int largeHerbivoreCount = 5;

            int smallCarnivoreCount = 2;
            int mediumCarnivoreCount = 2;
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
            Assert.IsTrue(trainWagons.Count == 8);
        }
        [TestMethod]
        public void TestMethod11()
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
        public void TestMethod12()
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
        public void TestMethod13()
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
        public void TestMethod14()
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

