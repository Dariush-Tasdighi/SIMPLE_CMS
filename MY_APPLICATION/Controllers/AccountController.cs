//using System.Linq;

namespace MY_APPLICATION.Controllers
{
	public class AccountController : Infrastructure.BaseController
	{
		public AccountController() : base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ActionResult Login()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		[System.Web.Mvc.ValidateAntiForgeryToken]
		public System.Web.Mvc.ActionResult Login(ViewModels.Account.LoginViewModel viewModel)
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ActionResult Register()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		[System.Web.Mvc.ValidateAntiForgeryToken]
		public System.Web.Mvc.ActionResult Register(ViewModels.Account.RegisterViewModel viewModel)
		{
			return View();
		}
	}
}
