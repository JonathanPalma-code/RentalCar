using System;

namespace RentalCar.Entities
{
    class CarRental
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime startDate, DateTime endDate, Vehicle vehicle)
        {
            StartDate = startDate;
            EndDate = endDate;
            Vehicle = vehicle;
        }
    }
}
