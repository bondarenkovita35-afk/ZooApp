﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Animals
{
    public class Cat : Animal 
    {
        public Cat(string name, int age, string color, double weight) : base(name, age, color, weight)
        {
        }
        public override void Speak() =>
        
            Console.WriteLine($"{Name} says: Meow!");
        
    }
}
