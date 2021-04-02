namespace Wedding.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Wedding.Web.ViewModels.Home;

    public class ProgramController : Controller
    {
        public IActionResult Index(string id)
        {

            var viewModel = new InvitationViewModel();
            viewModel.Id = id;
            return this.View(viewModel);
        }
    }
}
