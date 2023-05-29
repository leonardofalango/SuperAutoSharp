namespace SAS;
public class Shop
{
    private List<Machine> stock = new List<Machine>();
    public IEnumerable<Machine> Stock => stock;
    private void getStock()
    {
        List<Machine> newStock = new List<Machine>();
        newStock = RandomMachines.GetRandomMachines();
        this.stock = newStock;
    }

    public Shop()
        => getStock();
    public void ShowStock()
    {
        Console.WriteLine("----------------------\nLOJA ATUAL:\n");
        foreach (var item in stock)
            Console.WriteLine($"{item.Name}: {item.Atk} / {item.Def}");
            
        Console.WriteLine();
    }

    public void RemoveFromStock(Machine machine)
        => stock.Remove(machine);

}
