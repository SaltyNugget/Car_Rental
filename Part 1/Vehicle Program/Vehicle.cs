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
        private int Total_travelled = 0;
        private int Total_Services = 0;
        private int Total_Cost = 0;
        private int Km_LastS = 0;


        //Vehicle Constructor

        public Vehicle (string manufacturer, string model, string year, string registration_Number)
        { 
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
            Registration_Number = registration_Number;
           

        }

        public Vehicle(int total_service)
        {
            Total_Services = total_service;
        }

        public Vehicle()
        {
        }

        public string manufacturer { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public string registration_Number { get; set; } 
        public int total_service { get; set; }
        public int total_cost { get; set; }
        public int km_lastS { get; set; }
        




        //Journey class Method----------
        public void AddJourney(Journey pJourney)
        {

            Total_travelled += pJourney.Total_travelled;

        }

        public void AddServicing(Servicing vServicing)
        {
            Km_LastS += vServicing.Last_service;
        }



        //Print to screen Method---------
        public string PrintToScreen()
        {
            return "Manufacturer: " + Manufacturer +"\r\n"+ "Model: " + Model + "\r\n"  + "Year: " + Year +"\r\n"+ "Registration Number: " + Registration_Number+ "\r\n"  + "Total Kilometres Travelled: " + Total_travelled + "KM" + "\r\n"  + "Number of Services: " + Total_Services + "\r\n" +
               "Total Cost of Services:" + "$" + Total_Cost + "\r\n" + "Kms since last Services:" + Total_Services + "Km";

        }
        public string PrintToScreen2()
        {
            return "Manufacturer: " + Manufacturer + "   " + "Model: " + Model + "   " + "Year: " + Year + "   " + "Registration Number: " + Registration_Number + "   ";
        }


    }


    }

