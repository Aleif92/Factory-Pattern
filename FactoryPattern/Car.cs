namespace FactoryPattern;

public class Car: IVehicle
{
    public void Drive()
    {
        Console.WriteLine("You are now driving a car!");
    }
}