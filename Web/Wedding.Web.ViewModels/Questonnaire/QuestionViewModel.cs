namespace Wedding.Web.ViewModels.Questonnaire
{
    using System.Collections.Generic;

    public class QuestionViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int GuestId { get; set; }

        public string RouteId { get; set; }

        public int FoodId { get; set; }

        public int OrganizedTransportId { get; set; }

        public int ChildrenId { get; set; }

        public string AlergicFoods { get; set; }

        public IEnumerable<KeyValuePair<string, string>> GuestNames { get; set; }

        public IEnumerable<KeyValuePair<string, string>> FoodNames { get; set; }

        public IEnumerable<KeyValuePair<string, string>> OrganizedTransport { get; set; }

        public IEnumerable<KeyValuePair<string, string>> Children { get; set; }
    }
}
