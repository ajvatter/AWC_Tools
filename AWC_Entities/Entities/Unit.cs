using System;
using System.Collections.Generic;
using System.Text;

namespace AWC_Entities.Entities
{
    public class Unit
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ForceAlignment ForceAlignment { get; set; }
        public CombatType CombatType { get; set; }
        public bool Obtainable { get; set; }
        public string TextId { get; set; }
        public IEnumerable<Unit_Category> Categories { get; set; }
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
