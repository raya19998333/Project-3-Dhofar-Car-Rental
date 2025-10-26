using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4____Salalah_Sports_League_.Models
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal DailyRate { get; set; }
        public CarStatus Status { get; set; } = CarStatus.Available;

        public Car(string make, string model, decimal dailyRate)
        {
            Make = make;
            Model = model;
            DailyRate = dailyRate;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Make} {Model} - ${DailyRate}/day - {Status}");
        }
    }
}
