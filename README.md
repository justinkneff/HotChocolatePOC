# HotChocolatePOC
Code First Approach
https://hotchocolate.io/docs/code-first

Following this function
https://github.com/OneCyrus/GraphQL-AzureFunctions-HotChocolate

Returns Stack Exception on runtime
````
{
    "data": {},
    "extensions": {},
    "errors": [
        {
            "message": "Unexpected Execution Error",
            "code": null,
            "path": null,
            "locations": [],
            "exception": {
                "ClassName": "System.NullReferenceException",
                "Message": "Object reference not set to an instance of an object.",
                "Data": null,
                "InnerException": null,
                "HelpURL": null,
                "StackTraceString": "   at lambda_method(Closure , IResolverContext )\r\n   at DryIoc.Factory.<>c__DisplayClass26_1.<ApplyReuse>b__2() in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\DryIoc\\Container.cs:line 6596\r\n   at DryIoc.Scope.TryGetOrAdd(ImMap`1 items, Int32 id, CreateScopedValue createValue, Int32 disposalOrder) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\DryIoc\\Container.cs:line 7840\r\n   at DryIoc.Scope.GetOrAdd(Int32 id, CreateScopedValue createValue, Int32 disposalOrder) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\DryIoc\\Container.cs:line 7825\r\n   at DryIoc.Factory.ApplyReuse(Expression serviceExpr, Request request) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\DryIoc\\Container.cs:line 6595\r\n   at DryIoc.Factory.GetExpressionOrDefault(Request request) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\DryIoc\\Container.cs:line 6555\r\n   at DryIoc.Factory.GetDelegateOrDefault(Request request) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\DryIoc\\Container.cs:line 6625\r\n   at DryIoc.Container.ResolveAndCacheDefaultFactoryDelegate(Type serviceType, IfUnresolved ifUnresolved) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\DryIoc\\Container.cs:line 210\r\n   at DryIoc.Container.DryIoc.IResolver.Resolve(Type serviceType, IfUnresolved ifUnresolved) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\DryIoc\\Container.cs:line 195\r\n   at Microsoft.Azure.WebJobs.Script.WebHost.DependencyInjection.JobHostServiceProvider.GetService(Type serviceType, IfUnresolved ifUnresolved) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\JobHostServiceProvider.cs:line 101\r\n   at Microsoft.Azure.WebJobs.Script.WebHost.DependencyInjection.JobHostServiceProvider.GetService(Type serviceType) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\JobHostServiceProvider.cs:line 79\r\n   at lambda_method(Closure , IServiceProvider , QueryDelegate )\r\n   at HotChocolate.Execution.ClassMiddlewareFactory.<>c__DisplayClass0_0`1.<Create>b__1(IServiceProvider s, QueryDelegate n)\r\n   at HotChocolate.Execution.ClassMiddlewareFactory.<>c__DisplayClass2_0`1.<CreateDelegate>b__0(IQueryContext context)\r\n   at HotChocolate.Execution.ExceptionMiddleware.InvokeAsync(IQueryContext context)",
                "RemoteStackTraceString": null,
                "RemoteStackIndex": 0,
                "ExceptionMethod": null,
                "HResult": -2147467261,
                "Source": "Anonymously Hosted DynamicMethods Assembly",
                "WatsonBuckets": null
            },
            "extensions": {
                "message": "Object reference not set to an instance of an object.",
                "stackTrace": "   at lambda_method(Closure , IResolverContext )\r\n   at DryIoc.Factory.<>c__DisplayClass26_1.<ApplyReuse>b__2() in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\DryIoc\\Container.cs:line 6596\r\n   at DryIoc.Scope.TryGetOrAdd(ImMap`1 items, Int32 id, CreateScopedValue createValue, Int32 disposalOrder) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\DryIoc\\Container.cs:line 7840\r\n   at DryIoc.Scope.GetOrAdd(Int32 id, CreateScopedValue createValue, Int32 disposalOrder) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\DryIoc\\Container.cs:line 7825\r\n   at DryIoc.Factory.ApplyReuse(Expression serviceExpr, Request request) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\DryIoc\\Container.cs:line 6595\r\n   at DryIoc.Factory.GetExpressionOrDefault(Request request) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\DryIoc\\Container.cs:line 6555\r\n   at DryIoc.Factory.GetDelegateOrDefault(Request request) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\DryIoc\\Container.cs:line 6625\r\n   at DryIoc.Container.ResolveAndCacheDefaultFactoryDelegate(Type serviceType, IfUnresolved ifUnresolved) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\DryIoc\\Container.cs:line 210\r\n   at DryIoc.Container.DryIoc.IResolver.Resolve(Type serviceType, IfUnresolved ifUnresolved) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\DryIoc\\Container.cs:line 195\r\n   at Microsoft.Azure.WebJobs.Script.WebHost.DependencyInjection.JobHostServiceProvider.GetService(Type serviceType, IfUnresolved ifUnresolved) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\JobHostServiceProvider.cs:line 101\r\n   at Microsoft.Azure.WebJobs.Script.WebHost.DependencyInjection.JobHostServiceProvider.GetService(Type serviceType) in C:\\azure-webjobs-sdk-script\\src\\WebJobs.Script.WebHost\\DependencyInjection\\JobHostServiceProvider.cs:line 79\r\n   at lambda_method(Closure , IServiceProvider , QueryDelegate )\r\n   at HotChocolate.Execution.ClassMiddlewareFactory.<>c__DisplayClass0_0`1.<Create>b__1(IServiceProvider s, QueryDelegate n)\r\n   at HotChocolate.Execution.ClassMiddlewareFactory.<>c__DisplayClass2_0`1.<CreateDelegate>b__0(IQueryContext context)\r\n   at HotChocolate.Execution.ExceptionMiddleware.InvokeAsync(IQueryContext context)"
            }
        }
    ],
    "contextData": {}
}
````
