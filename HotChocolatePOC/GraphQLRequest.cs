﻿using Newtonsoft.Json.Linq;

namespace HotChocolatePOC
{
    public class GraphQLRequest
    {
        public string OperationName { get; set; }
        public string Query { get; set; }
        public JObject Variables { get; set; }
    }
}
