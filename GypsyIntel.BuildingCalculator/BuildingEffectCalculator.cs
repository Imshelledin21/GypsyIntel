using System;
using System.Collections.Generic;
using System.Text;

namespace GypsyIntel.BuildingCalculator
{
    public class BuildingEffectCalculator
    {
        public double CalculateFlatRateEffect(int baseEffect, int numberOfBuildings, double buildingEfficiency)
        {
            return baseEffect * numberOfBuildings * buildingEfficiency;
        }

        public double CalculatePercentBasedEffect(double baseEffect, double buildingEfficiency, double percentOfBuilding)
        {
            return baseEffect * buildingEfficiency * percentOfBuilding * (100 - percentOfBuilding);
        }
    }
}
