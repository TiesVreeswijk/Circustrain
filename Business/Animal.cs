using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Animal
    {
        public AnimalSize Size { get; private set; }
        public DietType Diet { get; private set; }

        public Animal(AnimalSize size, DietType diet)
        {
            Size = size;
            Diet = diet;
        }
        
        public enum AnimalSize
        {
            Small = 1,
            Middle = 3,
            Large = 5
        }

        public enum DietType
        {
            Carnivore,
            Herbivore
        }
    }
}
