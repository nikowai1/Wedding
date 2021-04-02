namespace Wedding.Data.Models
{
    using System.Collections.Generic;

    using Wedding.Data.Common.Models;

    public class Food : BaseDeletableModel<int>
    {
        public Food()
        {
            this.Answers = new HashSet<Answer>();
        }

        public string Name { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
