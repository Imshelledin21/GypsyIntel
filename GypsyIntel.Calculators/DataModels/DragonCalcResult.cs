using System;
using System.Collections.Generic;
using System.Text;

namespace GypsyIntel.Calculators.DataModels
{
    public class DragonCalcResult
    {
        public string Relation { get; set; }
        public string DragonType { get; set; }
        public int DragonCost { get; set; }
        public int DragonHp { get; set; }
        public string ColorCode { get; set; }

        public void CalcColorCode()
        {
            switch (DragonType){
                case "Sapphire":
                    ColorCode = "#cddffb";
                    break;
                case "Ruby":
                    ColorCode = "#fabbc8";
                    break;
                case "Gold":
                    ColorCode = "#fff3b1";
                    break;
                case "Emerald":
                    ColorCode = "#b8e9c9";
                    break;
                default:
                    ColorCode = "#ffffff";
                    break;
            }
        }
    }

    public class TargetKingdomNetworth
    {
        public int Networth { get; set; }
    }
}
