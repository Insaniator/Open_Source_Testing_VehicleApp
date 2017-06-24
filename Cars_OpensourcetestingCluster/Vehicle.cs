using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars_OpensourcetestingCluster.Properties;

namespace Cars_OpensourcetestingCluster
{
    public class Vehicle
    {
        private int id { get; set; }
        private string manufacturer { get; set; }
        private string model { get; set; }
        private string make_year { get; set; }
        private string registration { get; set; }

        public double kilometres_Travelled { get; set; }
        public double revenue_earned { get; set; }
        public int total_Services { get; set; }
        public double fuel_tank { get; set; }
        public double kilo_service { get; set; }

        public Vehicle (int Id, string Manufacturer, string Model, string Make_year, string Registration, double Kilometres_Travelled, int Total_Services, double Fuel_tank, double Revenue_Earned, double Kilo_Service)
        {
            id = Id;
            manufacturer = Manufacturer;
            model = Model;
            make_year = Make_year;
            registration = Registration;
            kilometres_Travelled = Kilometres_Travelled;
            total_Services = Total_Services;
            fuel_tank = Fuel_tank;
            revenue_earned = Revenue_Earned;
            kilo_service = Kilo_Service;
        }

        public bool Requires_Service()
        {
            if(kilo_service < 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public double Fuel_Economy()
        {
            return (fuel_tank*100 /kilometres_Travelled);

        }
        public string Model()
        {
            return model;

        }
        public string Manufactorur()
        {
            return manufacturer;

        }
        public string Registration()
        {
            return registration;
        }

        public string Make_year()
        {
            return make_year;
        }
        public double Km_Travelled()
        {
            return kilometres_Travelled;
        }

    }
}
