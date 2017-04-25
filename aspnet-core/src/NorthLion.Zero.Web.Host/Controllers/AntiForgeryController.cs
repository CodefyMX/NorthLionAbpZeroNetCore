using NorthLion.Zero.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace NorthLion.Zero.Web.Host.Controllers
{
    public class AntiForgeryController : ZeroControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}