using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.PizzaTypes
{
    public class MargheritaPizza : Pizza
    {
        public MargheritaPizza()
        {
            Name = "Margherita Pizza";
            Ingredients.Add("Tomato sauce");
            Ingredients.Add("Mozzarella cheese");
            Ingredients.Add("Fresh basil leaves");
        }
    }
}
