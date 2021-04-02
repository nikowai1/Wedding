namespace Wedding.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Wedding.Data.Models;

    public class ChildrenSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Children.Any())
            {
                return;
            }

            await dbContext.Children.AddAsync(new Children { Answer = "0" });
            await dbContext.Children.AddAsync(new Children { Answer = "1" });
            await dbContext.Children.AddAsync(new Children { Answer = "2" });
            await dbContext.Children.AddAsync(new Children { Answer = "3" });
            await dbContext.Children.AddAsync(new Children { Answer = "4" });
            await dbContext.Children.AddAsync(new Children { Answer = "5" });
        }
    }
}
