using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Cool.App.Controllers;

public class HomeController : AbpController
{
    public ActionResult Index()
    {
        return Redirect("~/swagger");
    }

    public ActionResult Test()
    {
        return Ok(new { Message = "Works Fine" });
    }
}
