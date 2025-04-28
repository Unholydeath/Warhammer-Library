using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warhammer10thEdition
{
    public class Detachment
    {
        public string Name { get; init; }
        public string Rule { get; init; }
        public List<Stratagem> Stratagems { get; init; }
        public List<Enhancement> Enhancements { get; init; }

        public Detachment(string name, string rule, List<Stratagem> stratagems, List<Enhancement> enhancements) {
        
            Name = name;
            Rule = rule;
            Stratagems = stratagems;
            Enhancements = enhancements;
        
        }
    }
}
