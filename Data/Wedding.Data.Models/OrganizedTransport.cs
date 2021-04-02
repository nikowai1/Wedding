namespace Wedding.Data.Models
{
    using System.Collections.Generic;

    using Wedding.Data.Common.Models;

    public class OrganizedTransport : BaseModel<int>
    {
        public OrganizedTransport()
        {
            this.Answers = new HashSet<Answer>();
        }

        public string Answer { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
