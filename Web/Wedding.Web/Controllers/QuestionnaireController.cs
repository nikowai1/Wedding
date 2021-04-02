namespace Wedding.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Wedding.Services.Data;
    using Wedding.Web.ViewModels.Questonnaire;

    public class QuestionnaireController : Controller
    {
        private readonly IGuestsService guestsService;
        private readonly IMenusService menusService;
        private readonly IPostsService postsService;
        private readonly IOrganizedTransportService organizedTransportService;
        private readonly IChildrenService childrenService;

        public QuestionnaireController(
            IGuestsService guestsService,
            IMenusService menusService,
            IPostsService postsService,
            IOrganizedTransportService organizedTransportService,
            IChildrenService childrenService)
        {
            this.guestsService = guestsService;
            this.menusService = menusService;
            this.postsService = postsService;
            this.organizedTransportService = organizedTransportService;
            this.childrenService = childrenService;
        }

        public IActionResult Post(string id)
        {
            var viewModel = new QuestionViewModel();
            viewModel.GuestNames = this.guestsService.GetAllGuestsAsValuePairs(id);
            viewModel.FoodNames = this.menusService.GetAllMenusAsValuePairs();
            viewModel.OrganizedTransport = this.organizedTransportService.GetAllOrganizedAnswersAsValuePairs();
            viewModel.Children = this.childrenService.GetAllChildrenAsValuePairs();
            viewModel.Id = id;
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Post(QuestionViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var postId = await this.postsService.CreateAsync(input.GuestId, input.FoodId, input.OrganizedTransportId, input.ChildrenId);

            return this.RedirectToAction("Questionnaire/Post");
        }
    }
}
