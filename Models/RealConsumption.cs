using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimulateEl.Models
{
    public class RealConsumption
    {
            [Key]
            public string Id { get; set; }
            public string Effect { get; set; }
            public string Timeframe { get; set; }
    }
}
