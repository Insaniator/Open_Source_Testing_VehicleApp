using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_OpensourcetestingCluster
{
    class Maintence
    {
        bool oil_level;
        bool water_level;
        bool windscreen_wipers;
        bool front_Lights;
        bool rear_Lights;
        bool indicators;
        

        public Maintence(bool Oil_Level, bool Water_Level, bool Windscreen_Wipers, bool Front_Lights, bool Rear_Lights, bool Indicators)
        {
            oil_level = Oil_Level;
            water_level = Water_Level;
            windscreen_wipers = Windscreen_Wipers;
            front_Lights = Front_Lights;
            rear_Lights = Rear_Lights;
            indicators = Indicators;
        }
    }
}
