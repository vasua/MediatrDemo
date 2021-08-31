using System;
using System.Reflection;
using System.Threading.Tasks;
using MediatR;
using MediatrDemo2.Commands;
using MediatrDemo2.Infrastructure;
using MediatrDemo2.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace MediatrDemo2
{
    public class Program
    {
        public static Task Main(string[] args)
        {
            var serviceProvider = BuildMediator();
            Task create = RunCreate(serviceProvider);
            Task get = RunGet(serviceProvider);

            return Task.WhenAll(create, get);
        }

        public static async Task RunGet(ServiceProvider provider)
        {
            var mediator = provider.GetRequiredService<IMediator>();
            Console.WriteLine("Let's Find security with Id: Bond");
            var createdSecurity = await mediator.Send(new GetSecurityById { Id = "Bond"});
            Console.WriteLine($"Our security has: Id - {createdSecurity.Id}; Name - {createdSecurity.Name}; Issue Price - {createdSecurity.IssuePrice}; Status - {createdSecurity.Status}");
        }

        public static async Task RunCreate(ServiceProvider provider)
        {
            var mediator = provider.GetRequiredService<IMediator>();
            Console.WriteLine("Let's add new security:");
            var createdSecurity = await mediator.Send(new CreateSecurity {Id = "Bond", Name = "Wells", IssuePrice = 80});
            Console.WriteLine($"Our security has: Id - {createdSecurity.Id}; Name - {createdSecurity.Name}; Issue Price - {createdSecurity.IssuePrice}; Status - {createdSecurity.Status}");
        }

        private static ServiceProvider BuildMediator()
        {
            var services = new ServiceCollection();

            services.AddMediatR(typeof(Program).GetTypeInfo().Assembly);
            services.AddSingleton<ISecurityRepository, SecurityRepository>();
            //services.AddDbContext<> with Entity Framework

            var provider = services.BuildServiceProvider();

            return provider;
        }

    }

}
