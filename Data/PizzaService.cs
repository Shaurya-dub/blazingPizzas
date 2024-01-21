namespace BlazingPizza.Data;

public class PizzaService
{
    public async Task<PizzaTwo[]> GetPizzasAsync()
    {
        // Call your data access technology here
        await Task.Delay(1000);
        return new PizzaTwo[] {
        new() {PizzaId = 1, Name = "Margherita", Vegetarian=true},
        new() {PizzaId = 2, Name = "Peperoni", Vegetarian=false},
        new() {PizzaId = 3, Name = "Hawaiian", Vegetarian=false},
        new() {PizzaId = 4, Name = "Fiorentina", Vegetarian=true},
        new() {PizzaId = 5, Name = "Italiano", Vegetarian=false},

    };
    }
}
