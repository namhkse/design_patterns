public class NYPizzaStore : PizzaStore
{
    public override IPizza CreatePizza(string type)
    {
        Pizza pizza = null;
        if (type == "cheese") pizza = new NYStyleCheesePizza();
        if (type == "veggie") pizza = new NYStyleVeggiePizza();
        if (type == "pepperoni") pizza = new NYStylePepperoniPizza();
        return pizza;
    }
}