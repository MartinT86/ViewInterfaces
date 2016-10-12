using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewInterfaces.Models;

namespace ViewInterfaces.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HomeViewModel()
            {
                Title = "This is my title",
                SubTitle = "This is my sub title",
                ImageUrl = "http://martint86.github.io/images/avatar-martin.jpg",
                ImageCaption = "Caption for the image",
                BodyCopy = "Here is all the main copy for the page"
            };
            return View(model);
        }

        public ActionResult AnotherPage()
        {
            var model = new AnotherPageViewModel()
            {
                Title = "This is another title",
                SubTitle = "This is another sub title"
            };
            return View(model);
        }
    }
}