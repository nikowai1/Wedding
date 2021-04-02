namespace Wedding.Web.ViewModels.Home
{
    using Wedding.Data.Models;
    using Wedding.Services.Mapping;

    public class InvitationViewModel : IMapFrom<Invitation>
    {
        public string Id { get; set; }

        public string InvitationUrl { get; set; }

        public BackgroundImageViewModel BackgroundImage { get; set; }
    }
}
