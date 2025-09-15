using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Animals
{
    public class Animal
    {
       

        public string Name { get; set; }
        public int Age { get; set; }

        public string Color { get; set; }

        public double Weight { get; set; }
        public Animal(string name, int age, string color, double weight)
        {
            Name = name;
            Age = age;
            Color = color;
            Weight = weight;




        }
        public virtual void Speak()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
        public string GetInfo()
        {
            return $"{Name}, Age: {Age}, Color: {Color}, Weight: {Weight}kg";
        }
    }
}
