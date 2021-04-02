namespace Wedding.Data.Models
{
    using Wedding.Data.Common.Models;

    public class BackgroundImage : BaseModel<int>
    {
        public string ImageUrl { get; set; }
    }
}
