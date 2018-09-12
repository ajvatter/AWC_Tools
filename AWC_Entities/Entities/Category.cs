using System;
using System.Collections.Generic;
using System.Text;

namespace AWC_Entities.Entities
{
    public class Category 
    {
        public string Id { get; set; }        
        public string Name { get; set; }
        public bool Visible { get; set; }
        public IEnumerable<Unit_Category> Units { get; set; }
    }
}
