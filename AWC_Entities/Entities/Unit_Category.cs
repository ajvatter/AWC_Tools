using System;
using System.Collections.Generic;
using System.Text;

namespace AWC_Entities.Entities
{
    public class Unit_Category
    {
        public string UnitId { get; set; }
        public Unit Unit { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
