using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWC_Platoon_Optimizer.Models.Api
{
    public class ApiUnitModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int ForceAlignment { get; set; }
        public int CombatType { get; set; }
        public string BaseId { get; set; }
        public string CategoryIdList { get; set; }
    }
}
