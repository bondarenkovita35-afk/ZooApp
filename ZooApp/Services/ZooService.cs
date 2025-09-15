using System.Collections.Generic;
using ZooApp.Animals;

namespace ZooApp.Services
{
    public class ZooService
    {
        public void Run()
        {
            var animals = new List<Animal>
            {
                new Dog("Buddy", 3, "White", 12.5),
                new Cat("Whiskers", 2, "Black", 4.2),
                new Bird("Tweety", 1, "Yellow", 0.3)
            };
            foreach (var animal in animals)
            {
              
            
            
            
                Console.WriteLine(animal.GetInfo());
                animal.Speak();
            }
        }
    }
}
