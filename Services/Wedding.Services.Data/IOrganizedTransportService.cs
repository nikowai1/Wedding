namespace Wedding.Services.Data
{
    using System.Collections.Generic;

    public interface IOrganizedTransportService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllOrganizedAnswersAsValuePairs();
    }
}
