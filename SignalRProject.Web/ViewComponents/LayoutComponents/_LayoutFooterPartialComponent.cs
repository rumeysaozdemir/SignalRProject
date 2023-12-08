using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.Web.ViewComponents.LayoutComponents
{
	public class _LayoutFooterPartialComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();	
		}
	}
}
