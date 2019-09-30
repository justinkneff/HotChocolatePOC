using System;
using System.Collections.Generic;
using System.Text;

namespace HotChocolatePOC.Models
{
    public class Member
    {
        //like 1
        public int PersonID { get; set; }
        //like "Phil"
        public string FirstName { get; set; }
        //like "Jackson"
        public string LastName { get; set; }
        //like "Coach"
        public string Title { get; set; }
    }
}
