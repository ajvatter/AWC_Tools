using System;
using System.Collections.Generic;
using System.Text;

namespace AWC_Entities.Entities
{
    public class Unit : EntityBase
    {
        public string Name { get; set; }
        public ForceAlignment ForceAlignment { get; set; }
        public CombatType CombatType { get; set; }
        public bool Obtainable { get; set; }
        public string TextId { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }

    public enum ForceAlignment
    {
        LightSide = 2,
        DarkSide = 3
    }

    public enum CombatType
    {
        Ground = 1,
        Ship = 2
    }
}
