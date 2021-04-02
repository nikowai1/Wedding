namespace Wedding.Services.Data
{
    using System.Collections.Generic;

    public interface IMenusService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllMenusAsValuePairs();
    }
}
