using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Carriage
    {
        public List<Animal> animals = new List<Animal>();
        public int GetCurrentSize()
        {
            int totalSize = 0;
            foreach (Animal animal in animals)
            {
                totalSize += animal.Size;
            }
            return totalSize;
        }
    }
}
