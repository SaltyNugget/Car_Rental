using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Program
{
    public class Vehicle
    {

        private string Manufacturer;
        private string Model;
        private string Year;
        private string Registration_Number;
        
        

        //Vehicle Constructor

        public Vehicle (string manufacturer, string model, string year, string registration_Number)
        { 
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
            Registration_Number = registration_Number;
           

        }

        public Vehicle()
        {
        }

        public string manufacturer { get; set; }

       public string model { get; set; }

       public string year { get; set; }
     
       public string registration_Number { get; set; } 
            
       

      



        //Journey Class Method: Distance travelled
        public void AddJourney(double distanceTravelled)
        {
            Journeys.Add(new Journey(distanceTravelled));
        }

        //FuelPurchase class method: fuelQuantityPurchased, fuelCostPerL
        public void AddFuelPurchase(double fuelQuantityPurchased, double fuelCostPerL)
        {
            FuelPurchases.Add(new FuelPurchase(fuelQuantityPurchased, fuelCostPerL));
        }
        //Service class method
        public void AddService()
        {
            Services.Add(new Service(CalculateTotalDistanceTravelled()));
        }
        //PerKmRental class Method
        public void AddPerKmRental(double kmTravelled)
        {
            PerKmRentals.Add(new PerKmRental(kmTravelled));
        }
        //PerDayRental Method
        public void AddPerDayRental(int daysRented)
        {
            PerDayRentals.Add(new PerDayRental(daysRented));
        }

        //Total distance calculation
        public double CalculateTotalDistanceTravelled()
        {
            double totalDistance = 0;
            // add all journeys distances
            foreach (Journey j in Journeys)
            {
                totalDistance = totalDistance + j.DistanceTravelled;
            }
            return totalDistance;
        }

        // Total Revenue Calculation
        public double CalculateTotalRevenue()
        {
            double Total = 0;
            // add all revenue from Per Km Rentals
            foreach (PerKmRental km in PerKmRentals)
            {
                Total = Total + km.CalculateRentalCost();
            }
            // add all revenue from Per Day Rentals
            foreach (PerDayRental d in PerDayRentals)
            {
                Total = Total + d.CalculateRentalCost();
            }
            // subtract all fuel costs from revenue
            foreach (FuelPurchase f in FuelPurchases)
            {
                Total = Total - f.CalculateFuelCost();
            }
            return Total;
        }

        //Calculation for Distance since Last Service
        public double CalculateDistanceSinceLastService()
        {
            if (Services.Count > 0)
            {
                // calculate distance since last service
                return CalculateTotalDistanceTravelled() - Services.Last().TotalKmTravelled;
            }
            else
            {
                return CalculateTotalDistanceTravelled();
            }
        }

        public double CalculateFuelEconomy()
        {
            double FuelUsed = 0;
            // calculate fuel used
            foreach (FuelPurchase f in FuelPurchases)
            {
                FuelUsed = FuelUsed + f.FuelQuantityPurchased;
            }
            // prevent divide by zero
            if (FuelUsed > 0 && CalculateTotalDistanceTravelled() > 0)
            {
                // calculate fuel economy
                return (CalculateTotalDistanceTravelled() / FuelUsed) / 100;
            }
            else
            {
                return 0;
            }
        }

        public bool IsServiceRequired()
        {
            if (CalculateDistanceSinceLastService() >= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Call all the other Classes
        public List<Journey> Journeys = new List<Journey>();
        public List<FuelPurchase> FuelPurchases = new List<FuelPurchase>();
        public List<Service> Services = new List<Service>();
        public List<PerKmRental> PerKmRentals = new List<PerKmRental>();
        public List<PerDayRental> PerDayRentals = new List<PerDayRental>();


        //Print to RichTextBox---------
        public string PrintToScreen()
        {
            return "Manufacturer: " + Manufacturer + "\r\n" + "Model: " + Model + "\r\n" + "Year: " + Year + " \r\n" + "Registration Number: " +

                Registration_Number + " \r\n" + "Total Kilometers Travelled: " + CalculateTotalDistanceTravelled() + "KM" + "\r\n" + "Number of Service: " +

                Services.Count + "\r\n" + "Require Service: " + (IsServiceRequired() ? "Yes" : "No") + "\r\n" + "Total Revenue: $" + CalculateTotalRevenue().ToString("f2") + "\r\n" +

                "Fuel Economy: " + ((CalculateFuelEconomy() > 0) ? (CalculateFuelEconomy().ToString("f2") + "L/100Km") : "--");

                

        }

        //Print to listBox
        public string PrintToScreen2()
        {
            return "Manufacturer: " + Manufacturer + "   " + "Model: " + Model +"   "+"Year: " + Year +"   "+ "Registration Number: " + Registration_Number;
         }


    }


    }

