using System;
using System.Collections.Generic;
using System.Text;

namespace GypsyIntel.Calculators.DataModels.IntelModels
{
    public class Throne
    {
        public string Race { get; set; }
        public string Ruler { get; set; }
        public string Land { get; set; }
        public string Peasants { get; set; }
        public string BuildingEfficiency { get; set; }
        public string Money { get; set; }
        public string Food { get; set; }
        public string Runes { get; set; }
        public string TradeBalance { get; set; }
        public string Networth { get; set; }
        public string Soldiers { get; set; }
        public string OffSpec { get; set; }
        public string DefSpec { get; set; }
        public string Elites { get; set; }
        public string Thieves { get; set; }
        public string Wizards { get; set; }
        public string WarHorses { get; set; }
        public string Prisoners { get; set; }
        public string OffensivePoints { get; set; }
        public string DefensivePoints { get; set; }
        public List<ActiveSpells> ActiveSpells { get; set; }
    }
}
