namespace Wedding.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using Wedding.Data.Common.Repositories;
    using Wedding.Data.Models;

    public class ChildrenService : IChildrenService
    {
        private readonly IRepository<Children> childrenRepository;

        public ChildrenService(IRepository<Children> childrenRepository)
        {
            this.childrenRepository = childrenRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllChildrenAsValuePairs()
        {
            return this.childrenRepository.AllAsNoTracking()
                .Select(x => new
                {
                    x.Id,
                    x.Answer,
                }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Answer));
        }
    }
}
