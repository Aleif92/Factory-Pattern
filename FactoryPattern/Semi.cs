namespace FactoryPattern;

public class Semi: IVehicle
{
    public void Drive()
    {
        Console.WriteLine("You are now driving a semi!");
    }
}