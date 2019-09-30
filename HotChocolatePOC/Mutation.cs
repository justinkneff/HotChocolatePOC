using System;
using System.Collections.Generic;
using System.Text;
using HotChocolatePOC.Models;

namespace HotChocolatePOC
{
    public class Mutation
    {
        public Mutation()
        {
        }

        public Address CreateAddress(Member member, Address address)
        {
            return address;
        }
    }
}
