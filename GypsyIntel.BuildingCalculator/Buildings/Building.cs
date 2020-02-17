using GypsyIntel.BuildingCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace GypsyIntel.Buildings.BuildingCalculator
{
    public abstract class Building
    {
        public virtual int LivingSpace { get; set; }
        public int Jobs { get; set; }
        public string Description { get; protected set; }
        public Dictionary<string, double> PercentEffectBase { get; protected set; }
        public Dictionary<string, int> FlatRateBase { get; protected set; }
        public double BasePercentMax { get; protected set; }

        private double BuildingEfficiency;
        private double PercentOfBuilding;

        private BuildingEffectCalculator _calculator;

        public Building(double buildingEfficiency, double percentOfBuilding)
        {
            BuildingEfficiency = buildingEfficiency;
            PercentOfBuilding = percentOfBuilding;
            _calculator = new BuildingEffectCalculator();
        }

        public virtual Dictionary<string, double> CalculateBuildingEffects()
        {
            throw new NotImplementedException();
        }



        
    }
}
