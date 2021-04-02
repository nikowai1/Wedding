namespace Wedding.Services.Data
{
    using Wedding.Data.Models;

    public interface IInvitationsService
    {
        T GetById<T>(string id);
    }
}
