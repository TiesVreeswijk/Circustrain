using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    using System.Threading.Tasks;
    using WindowsFormsApp1;


namespace dealer.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbCount = 0;
            int mediumHerbCount = 3;
            int largeHerbCount = 2;

            int smallCarnCount = 1;
            int mediumCarnCount = 0;
            int largeCarnCount = 0;


            for (int i = 0; i < smallHerbCount; i++)
            {
                animals.Add(new Herbivore(1));
            }

            for (int i = 0; i < mediumHerbCount; i++)
            {
                animals.Add(new Herbivore(3));
            }

            for (int i = 0; i < largeHerbCount; i++)
            {
                animals.Add(new Herbivore(5));
            }

            for (int i = 0; i < smallCarnCount; i++)
            {
                animals.Add(new Carnivore(1));
            }

            for (int i = 0; i < mediumCarnCount; i++)
            {
                animals.Add(new Carnivore(3));
            }

            for (int i = 0; i < largeCarnCount; i++)
            {
                animals.Add(new Carnivore(5));
            }

            Dealer Dealer = new Dealer();
            List<Carriage> trainCarriages = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainCarriages.Count == 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbCount = 5;
            int mediumHerbCount = 2;
            int largeHerbCount = 1;

            int smallCarnCount = 1;
            int mediumCarnCount = 0;
            int largeCarnCount = 0;


            for (int i = 0; i < smallHerbCount; i++)
            {
                animals.Add(new Herbivore(1));
            }

            for (int i = 0; i < mediumHerbCount; i++)
            {
                animals.Add(new Herbivore(3));
            }

            for (int i = 0; i < largeHerbCount; i++)
            {
                animals.Add(new Herbivore(5));
            }

            for (int i = 0; i < smallCarnCount; i++)
            {
                animals.Add(new Carnivore(1));
            }

            for (int i = 0; i < mediumCarnCount; i++)
            {
                animals.Add(new Carnivore(3));
            }

            for (int i = 0; i < largeCarnCount; i++)
            {
                animals.Add(new Carnivore(5));
            }

            Dealer Dealer = new Dealer();
            List<Carriage> trainCarriages = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainCarriages.Count == 2);
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbCount = 1;
            int mediumHerbCount = 1;
            int largeHerbCount = 1;

            int smallCarnCount = 1;
            int mediumCarnCount = 1;
            int largeCarnCount = 1;


            for (int i = 0; i < smallHerbCount; i++)
            {
                animals.Add(new Herbivore(1));
            }

            for (int i = 0; i < mediumHerbCount; i++)
            {
                animals.Add(new Herbivore(3));
            }

            for (int i = 0; i < largeHerbCount; i++)
            {
                animals.Add(new Herbivore(5));
            }

            for (int i = 0; i < smallCarnCount; i++)
            {
                animals.Add(new Carnivore(1));
            }

            for (int i = 0; i < mediumCarnCount; i++)
            {
                animals.Add(new Carnivore(3));
            }

            for (int i = 0; i < largeCarnCount; i++)
            {
                animals.Add(new Carnivore(5));
            }

            Dealer Dealer = new Dealer();
            List<Carriage> trainCarriages = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainCarriages.Count == 4);
        }

        [TestMethod]
        public void TestMethod4()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbCount = 1;
            int mediumHerbCount = 5;
            int largeHerbCount = 1;

            int smallCarnCount = 1;
            int mediumCarnCount = 1;
            int largeCarnCount = 2;


            for (int i = 0; i < smallHerbCount; i++)
            {
                animals.Add(new Herbivore(1));
            }

            for (int i = 0; i < mediumHerbCount; i++)
            {
                animals.Add(new Herbivore(3));
            }

            for (int i = 0; i < largeHerbCount; i++)
            {
                animals.Add(new Herbivore(5));
            }

            for (int i = 0; i < smallCarnCount; i++)
            {
                animals.Add(new Carnivore(1));
            }

            for (int i = 0; i < mediumCarnCount; i++)
            {
                animals.Add(new Carnivore(3));
            }

            for (int i = 0; i < largeCarnCount; i++)
            {
                animals.Add(new Carnivore(5));
            }

            Dealer Dealer = new Dealer();
            List<Carriage> trainCarriages = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainCarriages.Count == 5);
        }

        [TestMethod]
        public void TestMethod5()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbCount = 1;
            int mediumHerbCount = 1;
            int largeHerbCount = 2;

            int smallCarnCount = 1;
            int mediumCarnCount = 0;
            int largeCarnCount = 0;


            for (int i = 0; i < smallHerbCount; i++)
            {
                animals.Add(new Herbivore(1));
            }

            for (int i = 0; i < mediumHerbCount; i++)
            {
                animals.Add(new Herbivore(3));
            }

            for (int i = 0; i < largeHerbCount; i++)
            {
                animals.Add(new Herbivore(5));
            }

            for (int i = 0; i < smallCarnCount; i++)
            {
                animals.Add(new Carnivore(1));
            }

            for (int i = 0; i < mediumCarnCount; i++)
            {
                animals.Add(new Carnivore(3));
            }

            for (int i = 0; i < largeCarnCount; i++)
            {
                animals.Add(new Carnivore(5));
            }

            Dealer Dealer = new Dealer();
            List<Carriage> trainCarriages = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainCarriages.Count == 2);
        }

        [TestMethod]
        public void TestMethod6()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbCount = 0;
            int mediumHerbCount = 2;
            int largeHerbCount = 3;

            int smallCarnCount = 3;
            int mediumCarnCount = 0;
            int largeCarnCount = 0;


            for (int i = 0; i < smallHerbCount; i++)
            {
                animals.Add(new Herbivore(1));
            }

            for (int i = 0; i < mediumHerbCount; i++)
            {
                animals.Add(new Herbivore(3));
            }

            for (int i = 0; i < largeHerbCount; i++)
            {
                animals.Add(new Herbivore(5));
            }

            for (int i = 0; i < smallCarnCount; i++)
            {
                animals.Add(new Carnivore(1));
            }

            for (int i = 0; i < mediumCarnCount; i++)
            {
                animals.Add(new Carnivore(3));
            }

            for (int i = 0; i < largeCarnCount; i++)
            {
                animals.Add(new Carnivore(5));
            }

            Dealer Dealer = new Dealer();
            List<Carriage> trainCarriages = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainCarriages.Count == 3);
        }

        [TestMethod]
        public void TestMethod7()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbCount = 0;
            int mediumHerbCount= 5;
            int largeHerbCount = 6;

            int smallCarnCount = 7;
            int mediumCarnCount= 3;
            int largeCarnCount = 3;


            for (int i = 0; i < smallHerbCount; i++)
            {
                animals.Add(new Herbivore(1));
            }

            for (int i = 0; i < mediumHerbCount; i++)
            {
                animals.Add(new Herbivore(3));
            }

            for (int i = 0; i < largeHerbCount; i++)
            {
                animals.Add(new Herbivore(5));
            }

            for (int i = 0; i < smallCarnCount; i++)
            {
                animals.Add(new Carnivore(1));
            }

            for (int i = 0; i < mediumCarnCount; i++)
            {
                animals.Add(new Carnivore(3));
            }

            for (int i = 0; i < largeCarnCount; i++)
            {
                animals.Add(new Carnivore(5));
            }

            Dealer Dealer = new Dealer();
            List<Carriage> trainCarriages = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainCarriages.Count == 13);
        }
        [TestMethod]
        public void TestMethod8()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbCount = 5;
            int mediumHerbCount = 3;
            int largeHerbCount = 1;

            int smallCarnCount = 0;
            int mediumCarnCount = 0;
            int largeCarnCount = 0;


            for (int i = 0; i < smallHerbCount; i++)
            {
                animals.Add(new Herbivore(1));
            }

            for (int i = 0; i < mediumHerbCount; i++)
            {
                animals.Add(new Herbivore(3));
            }

            for (int i = 0; i < largeHerbCount; i++)
            {
                animals.Add(new Herbivore(5));
            }

            for (int i = 0; i < smallCarnCount; i++)
            {
                animals.Add(new Carnivore(1));
            }

            for (int i = 0; i < mediumCarnCount; i++)
            {
                animals.Add(new Carnivore(3));
            }

            for (int i = 0; i < largeCarnCount; i++)
            {
                animals.Add(new Carnivore(5));
            }

            Dealer Dealer = new Dealer();
            List<Carriage> trainCarriages = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainCarriages.Count == 2);
        }
        [TestMethod]
        public void TestMethod9()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbCount = 0;
            int mediumHerbCount = 0;
            int largeHerbCount = 3;

            int smallCarnCount = 1;
            int mediumCarnCount = 3;
            int largeCarnCount = 2;


            for (int i = 0; i < smallHerbCount; i++)
            {
                animals.Add(new Herbivore(1));
            }

            for (int i = 0; i < mediumHerbCount; i++)
            {
                animals.Add(new Herbivore(3));
            }

            for (int i = 0; i < largeHerbCount; i++)
            {
                animals.Add(new Herbivore(5));
            }

            for (int i = 0; i < smallCarnCount; i++)
            {
                animals.Add(new Carnivore(1));
            }

            for (int i = 0; i < mediumCarnCount; i++)
            {
                animals.Add(new Carnivore(3));
            }

            for (int i = 0; i < largeCarnCount; i++)
            {
                animals.Add(new Carnivore(5));
            }

            Dealer Dealer = new Dealer();
            List<Carriage> trainCarriages = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainCarriages.Count == 6);
        }
        [TestMethod]
        public void TestMethod10()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbCount = 5;
            int mediumHerbCount = 5;
            int largeHerbCount = 5;

            int smallCarnCount = 2;
            int mediumCarnCount = 2;
            int largeCarnCount = 2;


            for (int i = 0; i < smallHerbCount; i++)
            {
                animals.Add(new Herbivore(1));
            }

            for (int i = 0; i < mediumHerbCount; i++)
            {
                animals.Add(new Herbivore(3));
            }

            for (int i = 0; i < largeHerbCount; i++)
            {
                animals.Add(new Herbivore(5));
            }

            for (int i = 0; i < smallCarnCount; i++)
            {
                animals.Add(new Carnivore(1));
            }

            for (int i = 0; i < mediumCarnCount; i++)
            {
                animals.Add(new Carnivore(3));
            }

            for (int i = 0; i < largeCarnCount; i++)
            {
                animals.Add(new Carnivore(5));
            }

            Dealer Dealer = new Dealer();
            List<Carriage> trainCarriages = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainCarriages.Count == 8);
        }
        [TestMethod]
        public void TestMethod11()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbCount = 1;
            int mediumHerbCount = 3;
            int largeHerbCount = 2;

            int smallCarnCount = 0;
            int mediumCarnCount =0;
            int largeCarnCount = 0;


            for (int i = 0; i < smallHerbCount; i++)
            {
                animals.Add(new Herbivore(1));
            }

            for (int i = 0; i < mediumHerbCount; i++)
            {
                animals.Add(new Herbivore(3));
            }

            for (int i = 0; i < largeHerbCount; i++)
            {
                animals.Add(new Herbivore(5));
            }

            for (int i = 0; i < smallCarnCount; i++)
            {
                animals.Add(new Carnivore(1));
            }

            for (int i = 0; i < mediumCarnCount; i++)
            {
                animals.Add(new Carnivore(3));
            }

            for (int i = 0; i < largeCarnCount; i++)
            {
                animals.Add(new Carnivore(5));
            }

            Dealer Dealer = new Dealer();
            List<Carriage> trainCarriages = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainCarriages.Count == 2);
        }
        [TestMethod]
        public void TestMethod12()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbCount = 0;
            int mediumHerbCount = 3;
            int largeHerbCount = 2;

            int smallCarnCount = 1;
            int mediumCarnCount = 0;
            int largeCarnCount = 0;


            for (int i = 0; i < smallHerbCount; i++)
            {
                animals.Add(new Herbivore(1));
            }

            for (int i = 0; i < mediumHerbCount; i++)
            {
                animals.Add(new Herbivore(3));
            }

            for (int i = 0; i < largeHerbCount; i++)
            {
                animals.Add(new Herbivore(5));
            }

            for (int i = 0; i < smallCarnCount; i++)
            {
                animals.Add(new Carnivore(1));
            }

            for (int i = 0; i < mediumCarnCount; i++)
            {
                animals.Add(new Carnivore(3));
            }

            for (int i = 0; i < largeCarnCount; i++)
            {
                animals.Add(new Carnivore(5));
            }

            Dealer Dealer = new Dealer();
            List<Carriage> trainCarriages = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainCarriages.Count == 2);
        }
        [TestMethod]
        public void TestMethod13()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbCount = 0;
            int mediumHerbCount = 2;
            int largeHerbCount = 2;

            int smallCarnCount = 2;
            int mediumCarnCount = 0;
            int largeCarnCount = 0;


            for (int i = 0; i < smallHerbCount; i++)
            {
                animals.Add(new Herbivore(1));
            }

            for (int i = 0; i < mediumHerbCount; i++)
            {
                animals.Add(new Herbivore(3));
            }

            for (int i = 0; i < largeHerbCount; i++)
            {
                animals.Add(new Herbivore(5));
            }

            for (int i = 0; i < smallCarnCount; i++)
            {
                animals.Add(new Carnivore(1));
            }

            for (int i = 0; i < mediumCarnCount; i++)
            {
                animals.Add(new Carnivore(3));
            }

            for (int i = 0; i < largeCarnCount; i++)
            {
                animals.Add(new Carnivore(5));
            }

            Dealer Dealer = new Dealer();
            List<Carriage> trainCarriages = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainCarriages.Count == 2);
        }
        [TestMethod]
        public void TestMethod14()
        {
            List<Animal> animals = new List<Animal>();

            int smallHerbCount = 0;
            int mediumHerbCount = 6;
            int largeHerbCount = 2;

            int smallCarnCount = 2;
            int mediumCarnCount = 0;
            int largeCarnCount = 0;


            for (int i = 0; i < smallHerbCount; i++)
            {
                animals.Add(new Herbivore(1));
            }

            for (int i = 0; i < mediumHerbCount; i++)
            {
                animals.Add(new Herbivore(3));
            }

            for (int i = 0; i < largeHerbCount; i++)
            {
                animals.Add(new Herbivore(5));
            }

            for (int i = 0; i < smallCarnCount; i++)
            {
                animals.Add(new Carnivore(1));
            }

            for (int i = 0; i < mediumCarnCount; i++)
            {
                animals.Add(new Carnivore(3));
            }

            for (int i = 0; i < largeCarnCount; i++)
            {
                animals.Add(new Carnivore(5));
            }

            Dealer Dealer = new Dealer();
            List<Carriage> trainCarriages = Dealer.DistributeAnimals(animals);
            Assert.IsTrue(trainCarriages.Count == 3);
        }
    }
}

