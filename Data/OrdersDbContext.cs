using DnsClient.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Switchel_PWA.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Switchel_PWA.Data
{
    public class OrdersDbContext : DbContext
    {
        public DbSet<OpenOrder> OpenOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var Endpoint = "https://f66190b5-0ee0-4-231-b9ee.documents.azure.com:443/";
            var Key = "ySYCJJw4m24Fchh4KS6IMWg5wg3NzFT4vGFFHNxw5RPNXhapOM84WsUSehyhXvaLNO4P2PQwhcjEeYk0blrfdw==";

            optionsBuilder.UseCosmos(
                                     Endpoint,
                                     Key,
                                      "ThirtyDayTrial")
                                     .UseLoggerFactory((Microsoft.Extensions.Logging.ILoggerFactory)GenerateLoggerFactory())
                                     .EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OpenOrder>().ToContainer("OpenOrder");
            //modelBuilder.Entity<User>().OwnsMany(s => s.Posts);
            base.OnModelCreating(modelBuilder);
        }

        private DnsClient.Internal.ILoggerFactory GenerateLoggerFactory()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder => builder.AddConsole().AddFilter(DbLoggerCategory.Database.Command.Name, (Microsoft.Extensions.Logging.LogLevel)DnsClient.Internal.LogLevel.Trace));

            return serviceCollection.BuildServiceProvider().GetService<DnsClient.Internal.ILoggerFactory>();
        }
    }
}
