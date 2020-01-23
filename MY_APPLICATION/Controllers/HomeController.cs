//using System.Linq;

namespace MY_APPLICATION.Controllers
{
	public partial class HomeController : Infrastructure.BaseController
	{
		public HomeController() : base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Index()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Action1()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.Authorize]
		public virtual System.Web.Mvc.ViewResult Action2()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		[System.Web.Mvc.Authorize(Roles = "Administrator")]
		public virtual System.Web.Mvc.ViewResult Action3()
		{
			return View();
		}
	}
}
