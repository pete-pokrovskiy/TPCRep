using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TPC.Web.Infrastructure.Filters
{
    public class UnderConstructionFilter : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //если выставлен ключ IsUnderConstruction
            if(ConfigSettings.Instance.IsUnderConstruction)
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary( new
                {
                    controller = "Home", action = "UnderConstruction"
                }));

            base.OnActionExecuting(filterContext);
        }
    }
}