using System;
using System.Collections.Generic;
using System.Text;

namespace AWC_Entities.Entities
{
    public class Player : EntityBase
    {
        public string Name { get; set; }
        public int Level { get; set; }        
        public GuildMemberLevel GuildMemberLevel { get; set; }
        public virtual Guild Guild { get; set; }
    }

    public enum GuildMemberLevel
    {
        Leader = 1,
        Officer = 2,
        Member = 3
    }
}
