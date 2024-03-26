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

            int smallCarnCount = (int)NumUpDownSmallCarnivore.Value;
            int mediumCarnCount = (int)NumUpDownMediumCarnivore.Value;
            int largeCarnCount = (int)NumUpDownLargeCarnivore.Value;

            int smallHerbCount = (int)NumUpDownSmallHerbivore.Value;
            int mediumHerbCount = (int)NumUpDownMediumHerbivore.Value;
            int largeHerbCount = (int)NumUpDownLargeHerbivore.Value;

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
            Dealer dealer = new Dealer();
            List<Carriage> carriages = dealer.DistributeAnimals(animals);
        }
    }
}
