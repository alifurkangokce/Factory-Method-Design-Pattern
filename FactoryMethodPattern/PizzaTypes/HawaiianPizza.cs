using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.PizzaTypes
{

    public class HawaiianPizza : Pizza
    {
        public HawaiianPizza()
        {
            Name = "Hawaiian Pizza";
            Ingredients.Add("Tomato sauce");
            Ingredients.Add("Mozzarella cheese");
            Ingredients.Add("Ham");
            Ingredients.Add("Pineapple chunks");
        }
    }
}
