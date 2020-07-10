using System.Linq;
using Crunch.Data;
using Crunch.Models;
using Microsoft.AspNetCore.Http;


namespace Crunch.Injection
{

    public interface IAuth
    {
        User User { get; }
    }

    public class Auth : IAuth
    {
        private readonly Context _context;
        private readonly IHttpContextAccessor _accessor;

        public Auth(Context context, IHttpContextAccessor accessor)
        {
            _context = context;
            _accessor = accessor;
        }

        public User User
        {
            get
            {
                string token = string.Empty;

                bool hasHeader = this._accessor.HttpContext.Request.Cookies.TryGetValue("token", out token);

                if (!hasHeader)
                {
                    return null;
                }

                User user = _context.users.FirstOrDefault(u => u.Token == token);

                if (user == null)
                {
                    return null;
                }

                return user;

            }
        }
    }
}
