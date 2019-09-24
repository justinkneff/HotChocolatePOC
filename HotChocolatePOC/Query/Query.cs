using System;
using System.Collections.Generic;
using System.Text;
using HotChocolatePOC.Models;

namespace HotChocolatePOC.Query
{
    public class Query
    {
        //{ myObject {id firstName lastName } }
        public MyObject MyObject()
        {
            return new MyObject() { ID = 1, FirstName = "Lydia", LastName = "Stroman", Alert = false, Title = "Mrs"};
        }
    }
}
