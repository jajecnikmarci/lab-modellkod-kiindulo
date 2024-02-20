namespace Equipment;

public class SoundCard : EquipmentBase
{
    int yearOfCreation;
    int newPrice;

    public SoundCard(int yearOfCreation, int newPrice) : base(yearOfCreation,newPrice)
    {
    }

    public override double GetPrice()
    {
        return yearOfCreation < (DateTime.Today.Year - 4) ? 0 : newPrice - (DateTime.Today.Year - yearOfCreation) * 2000;
    }

    public int GetAge()
    {
        return DateTime.Today.Year - yearOfCreation;
    }
    public override string GetDescription()
    {
        return "Sound Card";
    }
}
