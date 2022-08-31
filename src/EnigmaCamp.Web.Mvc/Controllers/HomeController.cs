using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using EnigmaCamp.Controllers;

namespace EnigmaCamp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : EnigmaCampControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
