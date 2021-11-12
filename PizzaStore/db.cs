namespace PizzaStore.DB;

public record Pizza
{
    public int Id {get;set;}
    public string? Name {get;set;}
}

// A "in-memory" db store
public class PizzaDB 
{
    private static List<Pizza> _pizzas = new List<Pizza>()
    {
        new Pizza { Id = 1, Name = "Pizza 1" },
        new Pizza { Id = 2, Name = "Pizza 2" },
        new Pizza { Id = 3, Name = "Pizza 3" }
    };

    public static List<Pizza> GetPizzas() 
    {
        return _pizzas;
    }

    public static Pizza? GetPizza(int id)
    {
        return _pizzas.SingleOrDefault(pizza => pizza.Id == id);
    }

    public static Pizza CreatePizza(Pizza pizza)
    {
        _pizzas.Add(pizza);
        return pizza;
    }

    public static Pizza UpdatePizza(Pizza update)
    {
        _pizzas = _pizzas.Select(pizza => {
            if (pizza.Id == update.Id)
            {
                pizza.Name = update.Name;
            }
            return pizza;
        }).ToList();
        
        return update;
    }

    public static void RemovePizza(int id)
    {
        _pizzas = _pizzas.FindAll(pizza => pizza.Id == id).ToList();
    }
}
