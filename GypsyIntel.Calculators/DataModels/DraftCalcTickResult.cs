using System;
using System.Collections.Generic;
using System.Text;

namespace GypsyIntel.Calculators.DataModels
{
    public class DraftCalcTickResult
    {
        public int Tick { get; set; }
        public int SoldiersDrafted { get; set; }
        public int MilitaryPopulation { get; set; }
        public int PeasantPopulation { get; set; }
        public double DraftedPercent { get; set; }
    }
}
