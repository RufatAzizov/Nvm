namespace CarStuff
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[100];
            int vehicleCount = 0;
            while (true)
            {
                Console.WriteLine("1 - Create new car");
                Console.WriteLine("2 - Create new bicycle");
                Console.WriteLine("3 - Create new plane");
                Console.WriteLine("4 - See all the vehicles");
                Console.WriteLine("5 - Delete vehicle");
                Console.WriteLine("6 - Exit\n");

                byte userChoice = Convert.ToByte(Console.ReadLine());


                switch (userChoice)
                {
                    #region Cases
                    case 1:
                        Console.WriteLine("Drive Time:");
                        uint driveTimeCar = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine("Drive Path:");
                        uint drivePathCar = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine("Horsepower:");
                        uint horsepowerCar = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine("Tank Size:");
                        uint tankSizeCar = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine("Current Oil:");
                        uint currentOilCar = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine("Fuel Type:");
                        string fuelTypeCar = Console.ReadLine();
                        Console.WriteLine("Door Count:");
                        byte doorCountCar = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("Win Code:");
                        string vinCodeCar = Console.ReadLine();

                        vehicles[vehicleCount] = new Car(driveTimeCar, drivePathCar, horsepowerCar, tankSizeCar, currentOilCar, fuelTypeCar, doorCountCar, vinCodeCar);
                        vehicleCount++;
                        Console.WriteLine("\nNew car created\n");
                        break;

                    case 2:
                        Console.WriteLine("Drive Time:");
                        uint driveTimeBicycle = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine("Drive Path:");
                        uint drivePathBicycle = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine("Wheel Thickness:");
                        uint wheelThicknessBicycle = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine("Pedal Kind:");
                        string pedalKindBicycle = Console.ReadLine();

                        vehicles[vehicleCount] = new Bicycle(driveTimeBicycle, drivePathBicycle, wheelThicknessBicycle, pedalKindBicycle);
                        vehicleCount++;
                        Console.WriteLine("\nNew bicycle created\n");
                        break;

                    case 3:
                        Console.WriteLine("Drive Time:");
                        uint driveTimePlane = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine("Drive Path:");
                        uint drivePathPlane = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine("Wing Length:");
                        double wingLengthPlane = double.Parse(Console.ReadLine());

                        vehicles[vehicleCount] = new Plane(driveTimePlane, drivePathPlane, wingLengthPlane);
                        vehicleCount++;
                        Console.WriteLine("\nNew plane created\n");
                        break;

                    case 4:
                        Console.WriteLine("All vehicles list:\n");
                        if (vehicleCount == 0) { Console.WriteLine("No vehicle has been created yet\n"); }
                        else
                        {
                            for (int i = 0; i < vehicleCount; i++)
                            {
                                Console.WriteLine($"Vehicle {i + 1} - Drive Time: {vehicles[i].DriveTime}, Drive Path: {vehicles[i].DrivePath}\n");
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("Type vehicle's index to delete it:");
                        int index = Convert.ToInt32(Console.ReadLine());
                        if (index >= 0 && index < vehicleCount)
                        {
                            for (int i = index; i < vehicleCount - 1; i++)
                            {
                                vehicles[i] = vehicles[i + 1];
                            }
                            vehicleCount--;
                            Console.WriteLine("Vehicle deleted");
                        }
                        else
                        {
                            Console.WriteLine("Wrong index, please try again");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Terminating...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Please try again");
                        break;
                        #endregion
                }
            }



        }
    }
}