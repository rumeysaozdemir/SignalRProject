﻿using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.Web.ViewComponents.DefaultComponents
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
