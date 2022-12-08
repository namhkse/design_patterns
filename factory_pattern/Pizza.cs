public interface IPizza
{
    string Name { get; }

    void Bake();
    void Box();
    void Cut();
    void Prepare();
}

public abstract class Pizza : IPizza
{

    public string Name { get => this.GetType().Name; }

    public virtual void Prepare()
    {
        System.Console.WriteLine($"Prepare {this.GetType().Name}");
    }
    public virtual void Bake()
    {
        System.Console.WriteLine($"Bake {this.GetType().Name}");
    }
    public virtual void Cut()
    {
        System.Console.WriteLine($"Cut {this.GetType().Name}");
    }
    public virtual void Box()
    {
        System.Console.WriteLine($"Box {this.GetType().Name}");
    }
}

public class CheesePizza : Pizza { }
public class GreekPizza : Pizza { }
public class PepperoniPizza : Pizza { }

public class NYStyleCheesePizza : Pizza { }
public class NYStyleVeggiePizza : Pizza { }
public class NYStylePepperoniPizza : Pizza { }

public class ChicagoStyleCheesePizza : Pizza { }
public class ChicagoStyleVeggiePizza : Pizza { }
public class ChicagoStylePepperoniPizza : Pizza { }


