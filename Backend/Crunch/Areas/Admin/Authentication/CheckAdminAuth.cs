using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Crunch.Areas.Admin.Authentication
{
    public class CheckAdminAuth : ActionFilterAttribute
    {
        private readonly IAdminAuth _auth;

        public CheckAdminAuth(IAdminAuth auth)
        {
            _auth = auth;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (_auth.admin == null)
            {
               context.Result = new RedirectResult("/admin/Login");
            }
        }
    }
}