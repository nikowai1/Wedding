namespace Wedding.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using Wedding.Data.Common.Repositories;
    using Wedding.Data.Models;

    public class OrganizedTransportService : IOrganizedTransportService
    {
        private readonly IRepository<OrganizedTransport> organizedTransportRepository;

        public OrganizedTransportService(IRepository<OrganizedTransport> organizedTransportRepository)
        {
            this.organizedTransportRepository = organizedTransportRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllOrganizedAnswersAsValuePairs()
        {
            return this.organizedTransportRepository.AllAsNoTracking()
                .Select(x => new
                {
                    x.Id,
                    x.Answer,
                }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Answer));
        }
    }
}
