using System;
using System.Globalization;
using RentalCar.Entities;

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
            DateTime starDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(starDate, endDate, new Vehicle(carModel));


        }
    }
}
