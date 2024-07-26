namespace FactoryPattern;

public class Semi: IVehicle
{
    public void Drive()
    {
        ConsoleLoger.VehicleStartUpdDialogue();
        Console.WriteLine("You are now driving a semi!");
    }
}