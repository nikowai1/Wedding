namespace Wedding.Services.Data
{
    using System.Linq;

    using Wedding.Data.Common.Repositories;
    using Wedding.Data.Models;

    public class BackgroundImageService : IBackgroundImageService
    {
        private readonly IRepository<BackgroundImage> backgroundImageRepository;

        public BackgroundImageService(IRepository<BackgroundImage> backgroundImageRepository)
        {
            this.backgroundImageRepository = backgroundImageRepository;
        }

        public string GetImageUrl()
        {
            return this.backgroundImageRepository.All()
                .Select(x => x.ImageUrl).First();
        }
    }
}
