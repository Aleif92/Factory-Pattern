namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {int numberOfWheels;
            bool input = false;
            do
            {

                
                Console.WriteLine("How many wheels will your vehicle have? this determines the type of vehicle.");
                
                 input = int.TryParse(Console.ReadLine(), out numberOfWheels);

            }while (!input) ;
            

            var vehicle = VehicleFactory.GetVehicle(numberOfWheels);
            
            vehicle.Drive();

            // Console.WriteLine($"Your vehicle is a {vehicle}");




        }
    }
}
