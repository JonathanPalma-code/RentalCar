using System;

namespace RentalCar.Services
{
    class PortugalTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100) return amount * 0.2;
            else return amount * 0.15;
        }
    }
}
