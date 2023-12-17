using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Volo.Abp.AspNetCore.Mvc;

namespace Cool.App.Controllers;

public class HomeController : AbpController
{
    private readonly IConfiguration _configuration;

    public HomeController(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public ActionResult Index()
    {
        return Redirect("~/swagger");
    }

    public ActionResult Test()
    {
        //return BadRequest();
        return Ok(new
        {
            Message = "Works Fine",
            Id = 10,
            Value = _configuration.GetValue<string>("CoolKey")
        });
    }
}
