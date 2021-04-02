using System;
using System.Linq;
using System.Threading.Tasks;
using Wedding.Data.Models;

namespace Wedding.Data.Seeding
{
    public class OrganizedTransportSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.OrganizedTransports.Any())
            {
                return;
            }

            await dbContext.OrganizedTransports.AddAsync(new OrganizedTransport { Answer = "Да" });
            await dbContext.OrganizedTransports.AddAsync(new OrganizedTransport { Answer = "Не" });
        }
    }
}
