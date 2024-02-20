namespace Equipment;

public class EquipmentInventory
{
    private System.Collections.Generic.List<IEquipment> equipment;
    public EquipmentInventory()
    {
        equipment = new List<IEquipment>();
    }

    public void ListAll()
    {
        foreach (IEquipment eq in equipment)
        {
            Console.WriteLine($"Leírás: {eq.GetDescription()}\t" +
                $"Életkor: {eq.GetAge()}\tÉrtéke: {eq.GetPrice()}");
        }
    }
    public void AddEquipment(IEquipment eq)
    {
        equipment.Add(eq);
    }
}
