namespace Wedding.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Wedding.Data.Models;

    public class FoodSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Foods.Any())
            {
                return;
            }

            await dbContext.AddAsync(new Food { Name = "Меню със свинско месо" });
            await dbContext.AddAsync(new Food { Name = "Вегетарианско меню" });
        }
    }
}
