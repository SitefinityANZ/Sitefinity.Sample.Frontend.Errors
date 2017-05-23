using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Modules.Pages.Configuration;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Web.UI;

namespace SitefinityWebApp.Mvc.Controllers
{

    [ControllerToolboxItem(Name = "Errors", Title = "Errors", SectionName = "Errors")]
    public class ErrorController : Controller, ICustomWidgetVisualizationExtended
    {
        public string EmptyLinkText
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsEmpty
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string WidgetCssClass
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ActionResult Index()
        {
            Response.Status = "403 Forbidden";
            Response.StatusCode = 403;
            Response.StatusDescription = "Forbidden!";

            return View("Default");
        }
    }
}