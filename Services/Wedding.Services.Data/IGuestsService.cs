namespace Wedding.Services.Data
{
    using System.Collections.Generic;

    public interface IGuestsService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllGuestsAsValuePairs(string id);
    }
}
