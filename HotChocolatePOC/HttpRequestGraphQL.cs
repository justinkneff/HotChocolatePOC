using System;
using System.IO;
using System.Threading.Tasks;
using HotChocolate.Execution;
using HotChocolate.Language;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace HotChocolatePOC
{
    public class GraphQL
    {
        private readonly IQueryExecutor _executor;
        public GraphQL(IQueryExecutor executor)
        {
            _executor = executor;
        }

        [FunctionName("HttpRequest")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger 'Member' function processed a request.");

            var graphQLRequest = JsonConvert.DeserializeObject<GraphQLRequest>(await req.ReadAsStringAsync());

            log.LogInformation(graphQLRequest.Query);

            var query = QueryRequestBuilder.New()
                .SetQuery(graphQLRequest.Query)
                .SetOperation(graphQLRequest.OperationName);

            var result = await _executor.ExecuteAsync(query.Create());

            return new OkObjectResult(result);
        }
    }
}
