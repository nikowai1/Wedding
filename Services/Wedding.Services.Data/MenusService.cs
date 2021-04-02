namespace Wedding.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using Wedding.Data.Common.Repositories;
    using Wedding.Data.Models;

    public class MenusService : IMenusService
    {
        private readonly IDeletableEntityRepository<Food> foodsRepository;

        public MenusService(IDeletableEntityRepository<Food> foodsRepository)
        {
            this.foodsRepository = foodsRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllMenusAsValuePairs()
        {
            return this.foodsRepository.AllAsNoTracking()
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}
