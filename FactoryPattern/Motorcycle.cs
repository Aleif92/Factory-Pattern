namespace FactoryPattern;

public class Motorcycle: IVehicle
{
    public void Drive()
    {
        Console.WriteLine("You are now driving a motorcycle!");
    }
}