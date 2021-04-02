namespace Wedding.Services.Data
{
    using System.Linq;

    using Wedding.Data.Common.Repositories;
    using Wedding.Data.Models;
    using Wedding.Services.Mapping;

    public class InvitationsService : IInvitationsService
    {
        private readonly IDeletableEntityRepository<Invitation> invitationsRepository;

        public InvitationsService(IDeletableEntityRepository<Invitation> invitationsRepository)
        {
            this.invitationsRepository = invitationsRepository;
        }

        public T GetById<T>(string id)
        {
            return this.invitationsRepository.All()
                .Where(x => x.Id == id)
                .To<T>()
                .FirstOrDefault();
        }
    }
}
