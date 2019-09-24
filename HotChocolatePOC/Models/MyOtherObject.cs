using System;
using System.Collections.Generic;
using System.Text;

namespace HotChocolatePOC.Models
{
    public class MyOtherObject
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public List<Expenses> expenses { get; set; }
    }
}
