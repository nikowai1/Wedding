namespace Wedding.Services.Data
{
    using System.Threading.Tasks;

    public interface IPostsService
    {
        Task<int> CreateAsync(int guestId, int foodId, int organizedTransportId, int childrenId);
    }
}
