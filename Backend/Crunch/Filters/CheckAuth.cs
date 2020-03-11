
/*using Crunch.Injection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Filters
{
    public class CheckAuth : ActionFilterAttribute
    {
        private readonly IAuth _auth;

        public CheckAuth(IAuth auth)
        {
            _auth = auth;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (_auth.User == null)
            {
                context.Result = new RedirectResult("~/account/index");
            }
        }
    }
}*/