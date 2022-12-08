public class Program
{
    public static void Main(string[] args)
    {
        var nyStore = new NYPizzaStore();
        var chicagoStore = new ChicagoPizzaStore();
        var pizza = nyStore.OrderPizza("cheese");
        System.Console.WriteLine($"Dog orders {pizza.Name}");
        pizza = chicagoStore.OrderPizza("veggie");
        System.Console.WriteLine($"Cat orders {pizza.Name}");
    }
}