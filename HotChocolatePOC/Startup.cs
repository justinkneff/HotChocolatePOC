using HotChocolate;
using HotChocolatePOC.Query;
using HotChocolatePOC.Types;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: WebJobsStartup(typeof(HotChocolatePOC.Startup))]
namespace HotChocolatePOC
{
    class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            ConfigureServices(builder.Services);
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Query.Query>();

            services.AddGraphQL(sp => SchemaBuilder.New()
                .AddServices(sp)
                .AddQueryType<QueryType>() // Can only have one QueryType object
                .AddMutationType<MutationType>()
                .AddType<MyObjectType>()
                .AddType<MyOtherObjectType>()
                .AddType<ExpensesType>()
                .Create());
        }
    }
}
