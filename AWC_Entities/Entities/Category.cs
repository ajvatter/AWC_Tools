using System;
using System.Collections.Generic;
using System.Text;

namespace AWC_Entities.Entities
{
    public class Category : EntityBase
    {
        public string TextId { get; set; }
        public string Name { get; set; }
        public bool Visible { get; set; }
        public virtual ICollection<Unit> Units { get; set; }
    }
}
