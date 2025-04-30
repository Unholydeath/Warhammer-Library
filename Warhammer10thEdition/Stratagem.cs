using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class Stratagem
    {
        public string Name { get; protected set; }
        public string WhenToUse { get; protected set; }
        public string EligibleTargets { get; protected set; }
        public string Effect {  get; protected set; }
        public int PointCost { get; protected set; }

       
        public void SetName(string name)
        {
            Name = name;
        }

        public void SetWhenToUse(string whenToUse)
        {
            WhenToUse = whenToUse;
        }

        public void SetEligibleTargets(string eligibleTargets)
        {
            EligibleTargets = eligibleTargets;
        }

        public void SetEffect(string effect)
        {
            Effect = effect;
        }

        public void SetPointCost(int pointCost)
        {
            PointCost = pointCost;
        }

        public Stratagem()
        {
            Name = "";
            WhenToUse = "";
            EligibleTargets = "";
            Effect = "";
            PointCost = 0;
        }
    }
}
