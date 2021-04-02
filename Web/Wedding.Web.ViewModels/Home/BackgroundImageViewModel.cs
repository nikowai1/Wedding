namespace Wedding.Web.ViewModels.Home
{
    using Wedding.Data.Models;
    using Wedding.Services.Mapping;

    public class BackgroundImageViewModel : IMapFrom<BackgroundImage>
    {
        public string ImageUrl { get; set; }
    }
}
