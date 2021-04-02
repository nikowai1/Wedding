namespace Wedding.Services.Data
{
    using System.Threading.Tasks;

    using Wedding.Data.Common.Repositories;
    using Wedding.Data.Models;

    public class PostsService : IPostsService
    {
        private readonly IDeletableEntityRepository<Answer> answerRepository;

        public PostsService(IDeletableEntityRepository<Answer> answerRepository)
        {
            this.answerRepository = answerRepository;
        }

        public async Task<int> CreateAsync(int guestId, int foodId, int organizedTransportId, int childrenId)
        {
            var post = new Answer
            {
                GuestId = guestId,
                FoodId = foodId,
                OrganizedTransportId = organizedTransportId,
                ChildrenId = childrenId,
            };

            await this.answerRepository.AddAsync(post);
            await this.answerRepository.SaveChangesAsync();

            return post.Id;
        }
    }
}
