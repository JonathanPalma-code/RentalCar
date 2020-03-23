using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCar.Services
{
    interface ITaxService
    {
        double Tax(double amount);
    }
}
