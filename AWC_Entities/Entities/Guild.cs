using System;
using System.Collections.Generic;
using System.Text;

namespace AWC_Entities.Entities
{
    public class Guild
    {        
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Members { get; set; }
        public virtual ICollection<Player> Roster { get; set; }

    }
}
