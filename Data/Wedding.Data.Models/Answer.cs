namespace Wedding.Data.Models
{
    using Wedding.Data.Common.Models;

    public class Answer : BaseDeletableModel<int>
    {
        public int GuestId { get; set; }

        public Guest Guest { get; set; }

        public int FoodId { get; set; }

        public Food Food { get; set; }

        public int OrganizedTransportId { get; set; }

        public OrganizedTransport OrganizedTransport { get; set; }

        public int ChildrenId { get; set; }

        public Children Children { get; set; }
    }
}
