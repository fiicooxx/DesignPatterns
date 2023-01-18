using Decorator;

var pizzaBase = new MediumPizza();
var mediumPizzaWithCheese = new CheesePizzaDecorator(pizzaBase);
var mediumPIzzaWithCheeseAndSalami = new SalamiPizzaDecorator(mediumPizzaWithCheese);

Console.WriteLine(mediumPIzzaWithCheeseAndSalami.CalculatePrice());