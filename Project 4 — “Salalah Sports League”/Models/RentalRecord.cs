using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4____Salalah_Sports_League_.Models
{
    class RentalRecord
    {
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public int DaysRented { get; set; }
        public decimal TotalCost { get; set; }

        public RentalRecord(Customer customer, Car car, int days)
        {
            Customer = customer;
            Car = car;
            DaysRented = days;
            TotalCost = car.DailyRate * days;
            car.Status = CarStatus.Rented;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Customer.Name} rented {Car.Make} {Car.Model} for {DaysRented} days - Total: ${TotalCost}");
        }
    }
}
