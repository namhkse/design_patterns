public abstract class PizzaStore
{
    public abstract IPizza CreatePizza(string type);
    public IPizza OrderPizza(string type)
    {
        IPizza pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }
}