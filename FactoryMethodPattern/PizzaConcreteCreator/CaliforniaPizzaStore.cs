using FactoryMethodPattern.PizzaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.PizzaConcreteCreator
{
    public class CaliforniaPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza()
        {
            return new HawaiianPizza();
        }
    }
}
