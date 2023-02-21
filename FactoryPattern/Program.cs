namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                Console.WriteLine("How many tires does your vehicle have?");
                var userInput = (Console.ReadLine());

                VehicleFactory factory = new VehicleFactory();
                IVehicle myVehicle = factory.CreateVehicle(userInput);

                myVehicle.Drive();
                Console.WriteLine();
                Console.WriteLine("Good! Let's make another vehicle!");
                Console.WriteLine();


            } 
        } 


        
    }
}
