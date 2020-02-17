using System;
using System.ComponentModel.DataAnnotations;

namespace GypsyIntel.Calculators.DataModels
{
    public class SoldiersPerTick
    {
        [Required]
        [Range(1, 500000)]
        public int MaxPopulation { get; set; }

        [Required]
        [Range(1, 100)]
        public double TargetDraft { get; set; }

        [Required]
        [Range(1, 100)]
        public int MilitaryPopulation { get; set; }

        [Required]
        public int Peasants { get; set; }

        [Required]
        public string DraftSpeed { get; set; }

        [Required]
        public string RaceBonus { get; set; }

        [Required]
        public string PersonalityBonus { get; set; }
        
        [Required]
        public bool Patriotism { get; set; }

        public bool Dragon { get; set; }

        [Required]
        [Range(0, 200)]
        public double Affluent { get; set; }

        [Required]
        [Range(0, 200)]
        public double Science { get; set; }

        
    }
}
