using System;
using System.Collections.Generic;
using System.Text;

namespace HotChocolatePOC.Models
{
    public class Address
    {
        public int id { get; set; }
        public string name { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
