using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string color, double weight) : base(name, age, color, weight)
        {
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }
    
}

