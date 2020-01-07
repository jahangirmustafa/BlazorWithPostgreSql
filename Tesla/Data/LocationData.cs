using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tesla.Data
{
    public class LocationData
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
