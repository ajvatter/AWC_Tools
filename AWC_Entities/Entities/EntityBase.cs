using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AWC_Entities.Entities
{
    public class EntityBase
    {
        [Required]
        public string Id { get; set; }
    }
}
