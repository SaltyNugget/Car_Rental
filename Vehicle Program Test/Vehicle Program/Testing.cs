using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Program
{
   public class Testing
    {
        //Per Day Rental Test
        public int PerDayRental(int ChargingRate, int NumberOfDays)
        {
            return ChargingRate * NumberOfDays;
        }

        //Per Kilometre Rental Test
        public int PerKmRental(int KmTravelled, int ChargingRate)
        {
            return KmTravelled * ChargingRate;
        }

        //Fuel Purchase Test
        public double FuelPurchase(double FuelCost, int FuelQuantity)
        {
            return FuelCost * FuelQuantity;
        }

        
    }
}
