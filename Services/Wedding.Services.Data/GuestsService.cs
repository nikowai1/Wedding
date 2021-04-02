namespace Wedding.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using Wedding.Data.Common.Repositories;
    using Wedding.Data.Models;

    public class GuestsService : IGuestsService
    {
        private readonly IDeletableEntityRepository<Guest> guestsRepository;
        private readonly IDeletableEntityRepository<Invitation> invitationRepository;

        public GuestsService(IDeletableEntityRepository<Guest> guestsRepository, IDeletableEntityRepository<Invitation> invitationRepository)
        {
            this.guestsRepository = guestsRepository;
            this.invitationRepository = invitationRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllGuestsAsValuePairs(string id)
        {
            return this.guestsRepository.AllAsNoTracking()
                .Where(x => x.InvitationId == id)
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}
