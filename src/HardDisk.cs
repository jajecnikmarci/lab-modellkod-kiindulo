namespace Equipment;

public class HardDisk : EquipmentBase
{
    private int yearOfCreation;
    private int newPrice;
    private int capacityGB;

    public HardDisk(int yearOfCreation, int newPrice, int capacityGB) : base(yearOfCreation, newPrice)
    {
        this.capacityGB = capacityGB;
    }

    public override double GetPrice()
    {
        return yearOfCreation < (DateTime.Today.Year - 4) ? 0 : newPrice - (DateTime.Today.Year - yearOfCreation) * 5000;
    }

    public int GetAge()
    {
        return DateTime.Today.Year - yearOfCreation;
    }
    public override string GetDescription()
    {
        return "Hard Disk";
    }
}
