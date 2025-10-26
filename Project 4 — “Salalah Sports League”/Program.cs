using Project_4____Salalah_Sports_League_.Models;

namespace Project_4____Salalah_Sports_League_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            // Create cars
            Car car1 = new Car("Toyota", "Corolla", 50);
            Car car2 = new Car("Honda", "Civic", 60);
            Car car3 = new Car("Nissan", "Altima", 55);

            // Create customers
            Customer cust1 = new Customer("Ali", "96812345678");
            Customer cust2 = new Customer("Fatima", "96887654321");

            // Create rental records
            List<RentalRecord> rentals = new List<RentalRecord>();
            rentals.Add(new RentalRecord(cust1, car1, 3)); // Ali rents Toyota for 3 days
            rentals.Add(new RentalRecord(cust2, car3, 2)); // Fatima rents Nissan for 2 days

            // Print all rentals
            Console.WriteLine("Rental Records:");
            foreach (var rental in rentals)
            {
                rental.PrintInfo();
            }

            // Check available cars
            Console.WriteLine("\nAvailable Cars:");
            List<Car> allCars = new List<Car> { car1, car2, car3 };
            foreach (var car in allCars)
            {
                if (car.Status == CarStatus.Available)
                    car.PrintInfo();
            }

            // Calculate total revenue
            decimal revenue = 0;
            foreach (var rental in rentals) revenue += rental.TotalCost;
            Console.WriteLine($"\nTotal Revenue: ${revenue}");
        
    }
    }
}
