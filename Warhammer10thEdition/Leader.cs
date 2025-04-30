using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class Leader : Unit
    {
        public List<Unit> LeadUnits { get; protected set; }
        public string Buff {  get; protected set; }
        public bool IsWarlord { get; protected set; }
        public bool IsEpicHero { get; protected set; }
        public Enhancement Enhancement { get; protected set; }

        public void AddLeadUnit(Unit unit)
        {
            if (LeadUnits == null)
            {
                LeadUnits = new List<Unit>();
            }
            LeadUnits.Add(unit);
        }

        public void RemoveLeadUnit(Unit unit)
        {
            if (LeadUnits != null)
            {
                LeadUnits.Remove(unit);
            }
        }

        public void SetLeadUnits(List<Unit> leadUnits)
        {
            LeadUnits = leadUnits;
        }

        public void SetBuff(string buff)
        {
            Buff = buff;
        }

        public void SetIsWarlord(bool isWarlord)
        {
            IsWarlord = isWarlord;
        }

        public void SetIsEpicHero(bool isEpicHero)
        {
            IsEpicHero = isEpicHero;
        }

        public void SetEnhancement(Enhancement enhancement)
        {
            Enhancement = enhancement;
        }

        public Leader()
        {
            LeadUnits = new List<Unit>();
            Buff = string.Empty;
            IsWarlord = false;
            IsEpicHero = false;
            Enhancement = null;
        }
    }
}
