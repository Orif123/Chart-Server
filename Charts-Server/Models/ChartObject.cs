using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Charts_Server.Models
{
    public class ChartObject
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public List<int> Employees { get; set; }
    }
}
