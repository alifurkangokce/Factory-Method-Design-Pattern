using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.PizzaTypes
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";
            Ingredients.Add("Tomato sauce");
            Ingredients.Add("Mozzarella cheese");
            Ingredients.Add("Pepperoni slices");
        }
    }
}
