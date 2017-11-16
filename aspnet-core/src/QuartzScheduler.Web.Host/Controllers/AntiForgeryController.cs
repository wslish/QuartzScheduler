using Microsoft.AspNetCore.Antiforgery;
using QuartzScheduler.Controllers;

namespace QuartzScheduler.Web.Host.Controllers
{
    public class AntiForgeryController : QuartzSchedulerControllerBase
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
