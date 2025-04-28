using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class Enhancement
    {
        public string Name { get; init; }
        public string EligibleUsers { get; init; }
        public string Ability {  get; init; }
        public int PointCost { get; init; }

        public Enhancement(string name, string eligibleUsers, string ability, int pointCost)
        {
            Name = name;
            EligibleUsers = eligibleUsers;
            Ability = ability;
            PointCost = pointCost;
        }
    }
}
