using GypsyIntel.Calculators.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GypsyIntel.Calculators
{
    public class DraftCalculator
    {

        public async Task<List<DraftCalcTickResult>> CalculateDraft(SoldiersPerTick soldiersPerTick)
        {
            return await Task.Run(() =>
            {
                List<DraftCalcTickResult> calcResult = new List<DraftCalcTickResult>();
                double currentDraftPercent = Convert.ToDouble(soldiersPerTick.MilitaryPopulation) / Convert.ToDouble(soldiersPerTick.MaxPopulation);
                int maxPopulation = soldiersPerTick.MaxPopulation;
                double targetDraft = soldiersPerTick.TargetDraft / 100;
                double affluentPercent = soldiersPerTick.Affluent;
                int peasants = soldiersPerTick.Peasants;
                int militaryPopulation = soldiersPerTick.MilitaryPopulation;

                int tick = 1;
                while (currentDraftPercent <= targetDraft)
                {
                    var soldiersDrafted =
                        Convert.ToInt32(
                            peasants *
                            (double.Parse(soldiersPerTick.DraftSpeed) * 100) *
                            (soldiersPerTick.PersonalityBonus == "War Hero" ? 1.2 : 1) *
                            (soldiersPerTick.Patriotism ? 1.3 : 1) *
                            (soldiersPerTick.Dragon ? .8 : 1) *
                            (soldiersPerTick.Affluent != 0 ? 1.2 * ((affluentPercent - (Convert.ToDouble(tick) * .25)) / 100) : 1) *
                            (soldiersPerTick.Science != 0 ? (1 + (soldiersPerTick.Science / 100)) : 1)
                        ) / 100
                    ;

                    peasants = peasants - soldiersDrafted;
                    militaryPopulation = militaryPopulation + soldiersDrafted;
                    currentDraftPercent = Convert.ToDouble(militaryPopulation) / Convert.ToDouble(maxPopulation);

                    calcResult.Add(new DraftCalcTickResult
                    {
                        Tick = tick,
                        MilitaryPopulation = militaryPopulation,
                        PeasantPopulation = peasants,
                        DraftedPercent = Math.Round(currentDraftPercent * 100, 2),
                        SoldiersDrafted = soldiersDrafted
                    });


                    tick++;
                }


                return calcResult;
            });
        }
    }
}
