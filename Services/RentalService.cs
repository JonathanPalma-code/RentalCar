﻿using System;
using System.Collections.Generic;
using System.Text;
using RentalCar.Entities;

namespace RentalCar.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.EndDate.Subtract(carRental.StartDate);
            double basicPayment;
            if (duration.TotalHours <= 12) basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            else basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
