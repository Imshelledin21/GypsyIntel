using GypsyIntel.Buildings.BuildingCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace GypsyIntel.BuildingCalculator.Buildings
{
    public class BarrenLand : Building
    { 

        public BarrenLand(double buildingEfficiency, double percentOfBuilding) : base(buildingEfficiency, percentOfBuilding)
        {
            Description = "Houses 15 people and Produces 2 bushels per hour. (Unaffected by BE)";
            LivingSpace = 15;
            Jobs = 0;
            FlatRateBase = new Dictionary<string, int>
            {
                { "Food", 2 }
            };
        }
    }
}
