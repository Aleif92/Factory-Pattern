namespace FactoryPattern;

public class Car: IVehicle
{
    public void Drive()
    {
        ConsoleLoger.VehicleStartUpdDialogue();
        Console.WriteLine("You are now driving a car!");
    }
}