using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class Detachment
    {
        public string Name { get; protected set; }
        public string Rule { get; protected set; }
        public List<Stratagem> Stratagems { get; protected set; }
        public List<Enhancement> Enhancements { get; protected set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetRule(string rule)
        {
            Rule = rule;
        }

        public void AddStratagem(Stratagem stratagem)
        {
            if (Stratagems == null)
            {
                Stratagems = new List<Stratagem>();
            }
            Stratagems.Add(stratagem);
        }

        public void RemoveStratagem(Stratagem stratagem)
        {
            if (Stratagems != null)
            {
                Stratagems.Remove(stratagem);
            }
        }

        public void SetStratagems(List<Stratagem> stratagems)
        {
            Stratagems = stratagems;
        }

        public void AddEnhancement(Enhancement enhancement)
        {
            if (Enhancements == null)
            {
                Enhancements = new List<Enhancement>();
            }
            Enhancements.Add(enhancement);
        }

        public void RemoveEnhancement(Enhancement enhancement)
        {
            if (Enhancements != null)
            {
                Enhancements.Remove(enhancement);
            }
        }

        public void SetEnhancements(List<Enhancement> enhancements)
        {
            Enhancements = enhancements;
        }

        public Detachment()
        {
            Name = string.Empty;
            Rule = string.Empty;
            Stratagems = new List<Stratagem>();
            Enhancements = new List<Enhancement>();
        }
    }
}
