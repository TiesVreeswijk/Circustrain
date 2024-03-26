using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Animal
    {
        public AnimalSize Size { get; set; }
        public DietType Diet { get; set; }
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
