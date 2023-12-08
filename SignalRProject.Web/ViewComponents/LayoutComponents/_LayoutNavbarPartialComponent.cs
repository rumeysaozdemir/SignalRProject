using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.Web.ViewComponents.LayoutComponents
{
	public class _LayoutNavbarPartialComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
