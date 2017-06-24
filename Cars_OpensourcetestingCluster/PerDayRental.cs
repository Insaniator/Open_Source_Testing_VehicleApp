using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_OpensourcetestingCluster
{
    public class PerDayRental
    {
        private int vehicle { get; set; }
        private double distance_travelled { get; set; }
        public double days_rented { get; set; }
        private double fuel_used { get; set; }

        public PerDayRental(int Vehicle, double Distance_Travelled, double Days_Rented, double Fuel_Used)
        {
            
            vehicle = Vehicle;
            distance_travelled = Distance_Travelled;
            days_rented = Days_Rented;
            fuel_used = Fuel_Used;
        }
        public double Price()
        {
            return (days_rented * 100);
        }

        public double Distance_Travelled()
        {
            return distance_travelled;
        }

        public double Fuel_Used()
        {
            return fuel_used;
        }
    }
}
