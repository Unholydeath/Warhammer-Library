using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class Enhancement
    {
        public string Name { get; protected set; }
        public string EligibleUsers { get; protected set; }
        public string Ability {  get; protected set; }
        public int PointCost { get; protected set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetEligibleUsers(string eligibleUsers)
        {
            EligibleUsers = eligibleUsers;
        }

        public void SetAbility(string ability)
        {
            Ability = ability;
        }

        public void SetPointCost(int pointCost)
        {
            PointCost = pointCost;
        }

        public Enhancement()
        {
            Name = "";
            EligibleUsers = "";
            Ability = "";
            PointCost = 0;
        }
    }
}
