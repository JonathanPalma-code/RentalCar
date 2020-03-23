using System;
using System.Globalization;
using RentalCar.Entities;
using RentalCar.Services;

namespace RentalCar
{
    class Print
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rental car details:");
            Console.Write("Car Model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime starDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Price p/Hour: ");
            double hour = double.Parse(Console.ReadLine());
            Console.Write("Price p/Day: ");
            double day = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(starDate, endDate, new Vehicle(carModel));

            RentalService rentalService = new RentalService(hour, day);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
