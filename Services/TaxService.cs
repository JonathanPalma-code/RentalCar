﻿using System;

namespace RentalCar.Services
{
    class TaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100) return amount * 0.2;
            else return amount * 0.15;
        }
    }
}
