namespace Wedding.Data.Models
{
    using System;
    using System.Collections.Generic;

    using Wedding.Data.Common.Models;

    public class Invitation : BaseDeletableModel<string>
    {
        public Invitation()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Guests = new HashSet<Guest>();
        }

        public string InvitationUrl { get; set; }

        public virtual ICollection<Guest> Guests { get; set; }
    }
}
