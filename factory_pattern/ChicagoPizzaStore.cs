public class ChicagoPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        Pizza pizza = null;
        if (type == "cheese") pizza = new ChicagoStyleCheesePizza();
        if (type == "veggie") pizza = new ChicagoStyleVeggiePizza();
        if (type == "pepperoni") pizza = new ChicagoStylePepperoniPizza();
        return pizza;
    }
}