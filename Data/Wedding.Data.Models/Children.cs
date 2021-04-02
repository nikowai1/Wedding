namespace Wedding.Data.Models
{
    using System.Collections.Generic;

    using Wedding.Data.Common.Models;

    public class Children : BaseDeletableModel<int>
    {
        public Children()
        {
            this.Answers = new HashSet<Answer>();
        }

        public string Answer { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
