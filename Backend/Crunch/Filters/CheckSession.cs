using Crunch.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace Crunch.Filters
{
    public class CheckSession : ActionFilterAttribute
    {
        public CheckSession()
        {

        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {


        }
    }

}
