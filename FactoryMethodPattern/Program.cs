// New York usulü Margherita pizza siparişi verme
using FactoryMethodPattern.PizzaConcreteCreator;
using FactoryMethodPattern;

PizzaStore newYorkStore = new NewYorkPizzaStore();
Pizza newYorkMargheritaPizza = newYorkStore.OrderPizza();

Console.WriteLine("\n");

// Chicago usulü Pepperoni pizza siparişi verme
PizzaStore chicagoStore = new ChicagoPizzaStore();
Pizza chicagoPepperoniPizza = chicagoStore.OrderPizza();

Console.WriteLine("\n");

// California usulü Hawaiian pizza siparişi verme
PizzaStore californiaStore = new CaliforniaPizzaStore();
Pizza californiaHawaiianPizza = californiaStore.OrderPizza();
