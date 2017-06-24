using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars_OpensourcetestingCluster;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cars_OpensourcetestingCluster
{
    class Services
    {

            public bool oil_level { get; set; }
            public bool water_level { get; set; }
            public bool windscreen_wipers { get; set; }
            public bool front_Lights { get; set; }
            public bool rear_Lights { get; set; }
            public bool indicators { get; set; }


            public Services(bool Oil_Level, bool Water_Level, bool Windscreen_Wipers, bool Front_Lights, bool Rear_Lights, bool Indicators)
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
