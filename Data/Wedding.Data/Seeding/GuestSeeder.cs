namespace Wedding.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Wedding.Data.Models;

    public class GuestSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Guests.Any())
            {
                return;
            }

            await dbContext.Guests.AddAsync(new Guest { Name = "Ники" });
            await dbContext.Guests.AddAsync(new Guest { Name = "Данчо" });
            await dbContext.Guests.AddAsync(new Guest { Name = "Боби" });
            await dbContext.Guests.AddAsync(new Guest { Name = "Станчо" });
            await dbContext.Guests.AddAsync(new Guest { Name = "Таня" });
        }
    }
}
