using System.Linq;
using Crunch.Areas.Admin.Models;
using Crunch.Data;
using Microsoft.AspNetCore.Http;

namespace Crunch.Areas.Admin.Authentication
{

    public interface IAdminAuth
    {
       AdminM admin{ get; }
    }
    public class AdminAuth : IAdminAuth
    {
        private readonly Context _context;
        private readonly IHttpContextAccessor _accessor;

        public AdminAuth(Context context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        public AdminM admin
        {
            get
            {
                string token = string.Empty;

                bool hasHeader = this._accessor.HttpContext.Request.Cookies.TryGetValue("Admintoken", out token);

                if (!hasHeader)
                {
                    return null;
                }

                AdminM admin = _context.Admins.FirstOrDefault(a => a.Token == token);

                if (admin == null)
                {
                    return null;
                }

                return admin;

            }
        }
    }
}
