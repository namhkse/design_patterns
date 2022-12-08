public class SimplePizzaFactory
{
    public Pizza CreatePizza(string type)
    {
        Pizza pizza = null;
        if (type == "cheese") pizza = new CheesePizza();
        if (type == "greek") pizza = new GreekPizza();
        if (type == "pepperoni") pizza = new PepperoniPizza();
        return pizza;
    }
}