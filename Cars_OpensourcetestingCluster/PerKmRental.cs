using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_OpensourcetestingCluster
{
    public class PerKmRental
    {
        private int vehicle { get; set; }
        private double distance_travelled { get; set; }
        private double fuel_used { get; set; }

        public PerKmRental(int Vehicle, double Distance_Travelled, double Fuel_used)
        {
            vehicle = Vehicle;
            distance_travelled = Distance_Travelled;
            fuel_used = Fuel_used;
        }

        public double Price()
            {
            return (distance_travelled * 1);
            }

        public double Fuel_used()
        {
            return fuel_used;
        }
        public double Distance_Travelled()
        {
            return distance_travelled; 
        }

    }
}
