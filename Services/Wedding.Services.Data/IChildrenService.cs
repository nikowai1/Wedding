namespace Wedding.Services.Data
{
    using System.Collections.Generic;

    public interface IChildrenService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllChildrenAsValuePairs();
    }
}
