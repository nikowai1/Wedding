namespace Wedding.Web.Controllers
{
    using System.Diagnostics;
    using System.Net;

    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using Wedding.Services.Data;
    using Wedding.Web.ViewModels;
    using Wedding.Web.ViewModels.Home;
    using Wedding.Web.ViewModels.Questonnaire;

    public class HomeController : BaseController
    {
        private readonly IInvitationsService invitationsService;
        private readonly IBackgroundImageService backgroundImageService;

        public HomeController(IInvitationsService invitationsService, IBackgroundImageService backgroundImageService)
        {
            this.invitationsService = invitationsService;
            this.backgroundImageService = backgroundImageService;
        }

        public IActionResult Index(string id)
        {
            var viewModel = this.invitationsService.GetById<InvitationViewModel>(id);

            if (viewModel == null)
            {
                return this.NotFound();
            }


            return this.View(viewModel);
        }
    }
}
