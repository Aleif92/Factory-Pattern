namespace FactoryPattern;

public class Motorcycle: IVehicle
{
    public void Drive()
    {
        ConsoleLoger.VehicleStartUpdDialogue();
        Console.WriteLine("You are now driving a motorcycle!");
    }
}