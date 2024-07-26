namespace FactoryPattern;

public class ConsoleLoger
{
    public static void VehicleStartUpdDialogue()
    {

        Console.WriteLine("Put key in ignition");
        Thread.Sleep(1000);
        Console.WriteLine("Turn key");
        Thread.Sleep(1000);
    }
    
}