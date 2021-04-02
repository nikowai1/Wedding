namespace Wedding.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Wedding.Data.Models;

    public class InvitationSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Invitations.Any())
            {
                return;
            }

            await dbContext.Invitations.AddAsync(new Invitation { InvitationUrl = "https://bit.ly/3cX0UJf" });
            await dbContext.Invitations.AddAsync(new Invitation { InvitationUrl = "https://bit.ly/2PhIYAW" });
        }
    }
}
