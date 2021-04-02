namespace Wedding.Data.Models
{
    using System.Collections.Generic;

    using Wedding.Data.Common.Models;

    public class Guest : BaseDeletableModel<int>
    {
        public Guest()
        {
            this.Answers = new HashSet<Answer>();
        }

        public string Name { get; set; }

        public string InvitationId { get; set; }

        public Invitation Invitation { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
