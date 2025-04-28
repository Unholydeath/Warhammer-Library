using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class Stratagem
    {
        public string Name { get; init; }
        public string WhenToUse { get; init; }
        public string EligibleTargets { get; init; }
        public string Effect {  get; init; }
        public int PointCost { get; init; }

        public Stratagem(string name, string whenToUse, string eligibleTargets, string effect, int pointCost)
        {
            Name = name;
            WhenToUse = whenToUse;
            EligibleTargets = eligibleTargets;
            Effect = effect;
            PointCost = pointCost;
        }
    }
}
