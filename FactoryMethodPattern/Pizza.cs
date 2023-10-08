using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; } = new List<string>();
        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine("Adding ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"- {ingredient}");
            }
        }
        public void Bake()
        {
            Console.WriteLine($"Baking {Name} at 400 degrees for 20 minutes.");
        }
        public void Cut()
        {
            Console.WriteLine($"Cutting {Name} into slices.");
        }
        public void Box()
        {
            Console.WriteLine($"Placing {Name} in a pizza box.");
        }
    }




}
