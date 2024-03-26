using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Animal;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSortAnimals_Click(object sender, EventArgs e)
        {
            List<Animal> animals = new List<Animal>();

            int smallCarnivoreCount = (int)NumUpDownSmallCarnivore.Value;
            int mediumCarnivoreCount = (int)NumUpDownMediumCarnivore.Value;
            int largeCarnivoreCount = (int)NumUpDownLargeCarnivore.Value;

            int smallHerbivoreCount = (int)NumUpDownSmallHerbivore.Value;
            int mediumHerbivoreCount = (int)NumUpDownMediumHerbivore.Value;
            int largeHerbivoreCount = (int)NumUpDownLargeHerbivore.Value;

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
            Dealer dealer = new Dealer();
            dealer.DistributeAnimals(animals);
        }
    }
}
